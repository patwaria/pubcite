using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace PubCite
{

    class GSScraper
    {


        private string latestSearch = "default";
        private HtmlDocument doc;

        private void loadHtmlDocument(string authName)
        {

            // CONNECTIONS
            latestSearch = authName;
            authName = authName.Replace(" ", "+");
            string url = "http://scholar.google.com/scholar?q=" + authName + "&btnG=&hl=en&as_sdt=0,5";
            // Console.WriteLine("loaded !!!");
            HtmlWeb web = new HtmlWeb();
            doc = web.Load(url);
        }


        // SUGGESTIONS FROM SEARCH PAGE
        public SG.AuthSuggestion getAuthSuggestions(string authName)
        {

            List<string> names = new List<string>();
            List<string> links = new List<string>();

            if (latestSearch.Equals("default") || (!latestSearch.Equals(authName)))
            {
                loadHtmlDocument(authName);
            }

            /*
            // DID U MEAN TAG
            string xpath = "//*[@class=\"gs_med\"]";
            HtmlNode dymNode = doc.DocumentNode.SelectSingleNode(xpath);

            if (dymNode != null)
            {
                Console.WriteLine("\nDID YOU MEAN TAG ");
                Console.WriteLine(dymNode.InnerText);
            }
            */

            // AUTHOR SUGGESTIONS
            string profiles_url = null;
            string xpath = "//*[@class=\"gs_rt2\"]";
            HtmlNodeCollection profileNode = doc.DocumentNode.SelectNodes(xpath);
            if (profileNode != null)
            {
                foreach (HtmlNode node in profileNode)
                {
                    HtmlNode urlNode = node.SelectSingleNode(".//a");
                    if (urlNode != null)
                    {
                        profiles_url = urlNode.GetAttributeValue("href", "Not Found");
                        names.Add(urlNode.InnerText);
                        if (!profiles_url.Equals("Not Found"))
                        {
                            profiles_url = "http://scholar.google.com" + profiles_url;
                            profiles_url = profiles_url.Replace("amp;", "");
                        }
                        links.Add(profiles_url);
                    }
                }
                return new SG.AuthSuggestion(names, links, true);
            }
            else return new SG.AuthSuggestion(null, null, false);
        }


        // RESULTS FROM AUTHOR PROFILE PAGE
        public SG.Author getAuthStatistics(string authUrl)
        {

            GSAuthScraper authScraper = new GSAuthScraper(authUrl);
            SG.Author author = new SG.Author(authScraper.getName(), authScraper.getHIndex(), authScraper.getIIndex());

            //Console.WriteLine(author.Name + "," + author.getHIndex() + "," + author.getI10Index());
            foreach (SG.Paper paper in authScraper.getPapersOfCurrentPage())
            {
                author.addPaper(paper);
            }
            return author;
        }





        // SEARCH PAGE RESULTS
        public SG.ClassifyAuthors getAuthors(string authName)
        {

            // IF THIS IS THE FIRST SEARCH OR PREVIOUS SEARCH IS DIFFERENT
            if (latestSearch.Equals("default") || (!latestSearch.Equals(authName)))
            {
                loadHtmlDocument(authName);
            }

            SG.ClassifyAuthors results = new SG.ClassifyAuthors();

            string xpath = "//div[@class=\"gs_ri\"]";
            string title, titleLink, authors, publication, publisher, cited_by_url;
            int year, rank = 1, no_of_citations;
            HtmlNodeCollection searchResults = doc.DocumentNode.SelectNodes(xpath);
            if (searchResults == null) return null;
            else
            {

                foreach (HtmlNode n in searchResults)
                {

                    // TITLE AND TITLE LINK
                    HtmlNode child = n.SelectSingleNode(".//*[@class=\"gs_rt\"]");
                    title = child.InnerText;
                    HtmlNode url_node = child.SelectSingleNode(".//a");
                    if (url_node != null)
                    {
                        titleLink = url_node.GetAttributeValue("href", "Not Found");
                        if (!titleLink.Equals("Not Found"))
                        {
                            titleLink = "http://scholar.google.com" + titleLink;
                            titleLink = titleLink.Replace("amp;", "");
                        }
                    }
                    // AUTHORS AND PUBLICATION
                    child = n.SelectSingleNode(".//*[@class=\"gs_a\"]");
                    authors = "Not Found";
                    publication = "Not Found";
                    publisher = "Not Found";
                    year = 1970;
                    if (child != null)
                    {
                        string[] names = child.InnerText.Split('-');
                        if (names.Length == 1) authors = names[0];
                        else if (names.Length == 2)
                        {
                            authors = names[0];
                            bool flag = false;
                            names[1].Trim();
                            try { year = Convert.ToInt32(names[1]); }
                            catch (FormatException fe) { flag = true; }
                            if (flag)
                            {
                                string[] p = names[1].Split(',');
                                try { year = Convert.ToInt32(p[1]); }
                                catch (Exception e) { }
                                publication = p[0];
                            }
                        }
                        else
                        {
                            authors = names[0];
                            publisher = names[2];
                            bool flag = false;
                            names[1].Trim();
                            try { year = Convert.ToInt32(names[1]); }
                            catch (FormatException fe) { flag = true; }
                            if (flag)
                            {
                                string[] p = names[1].Split(',');
                                try { year = Convert.ToInt32(p[1]); }
                                catch (Exception e) { }
                                publication = p[0];
                            }
                        }
                    }


                    // CITATION STUFF
                    no_of_citations = 0;
                    cited_by_url = "Not Found";
                    child = n.SelectSingleNode(".//*[@class=\"gs_fl\"]");
                    if (child != null) child = child.FirstChild;
                    if (child != null)
                    {
                        string text = child.InnerText;
                        cited_by_url = child.GetAttributeValue("href", "Not Found");
                        if (!cited_by_url.Equals("Not Found"))
                        {
                            cited_by_url = "http://scholar.google.com" + cited_by_url;
                            cited_by_url = cited_by_url.Replace("amp;", "");
                        }

                        try
                        {
                            text = text.Replace("Cited by", "");
                            text = text.Trim();
                            no_of_citations = Convert.ToInt32(text);
                        }
                        catch (Exception e) { }
                    }

                    publisher.Trim();
                    publication.Trim();
                    SG.Paper paper = new SG.Paper(title, authors, year, publication, publisher, no_of_citations, cited_by_url, rank);
                    results.addPaper(paper);
                    rank++;
                }

            }
            return results;
        }


        //  JOURNAL SEARCH RESULTS
        public SG.ClassifyJournals getJournals(string journalName)
        {

            // IF THIS IS THE FIRST SEARCH OR PREVIOUS SEARCH IS DIFFERENT
            if (latestSearch.Equals("default") || (!latestSearch.Equals(journalName)))
            {
                loadHtmlDocument(journalName);
            }

            SG.ClassifyJournals results = new SG.ClassifyJournals();

            string xpath = "//div[@class=\"gs_ri\"]";
            string title, titleLink, authors, publication, publisher, cited_by_url;
            int year, rank = 1, no_of_citations;
            HtmlNodeCollection searchResults = doc.DocumentNode.SelectNodes(xpath);
            if (searchResults == null) return null;
            else
            {

                foreach (HtmlNode n in searchResults)
                {

                    // TITLE AND TITLE LINK
                    HtmlNode child = n.SelectSingleNode(".//*[@class=\"gs_rt\"]");
                    title = child.InnerText;
                    HtmlNode url_node = child.SelectSingleNode(".//a");
                    if (url_node != null)
                    {
                        titleLink = url_node.GetAttributeValue("href", "Not Found");
                        if (!titleLink.Equals("Not Found"))
                        {
                            titleLink = "http://scholar.google.com" + titleLink;
                            titleLink = titleLink.Replace("amp;", "");
                        }
                    }

                    // AUTHORS AND PUBLICATION
                    child = n.SelectSingleNode(".//*[@class=\"gs_a\"]");
                    authors = "Not Found";
                    publication = "Not Found";
                    publisher = "Not Found";
                    year = 1970;
                    if (child != null)
                    {
                        string[] names = child.InnerText.Split('-');
                        if (names.Length == 1) authors = names[0];
                        else if (names.Length == 2)
                        {
                            authors = names[0];
                            bool flag = false;
                            names[1].Trim();
                            try { year = Convert.ToInt32(names[1]); }
                            catch (FormatException fe) { flag = true; }
                            if (flag)
                            {
                                string[] p = names[1].Split(',');
                                try { year = Convert.ToInt32(p[1]); }
                                catch (Exception e) { }
                                publication = p[0];
                            }
                        }
                        else
                        {
                            authors = names[0];
                            publisher = names[2];
                            bool flag = false;
                            names[1].Trim();
                            try { year = Convert.ToInt32(names[1]); }
                            catch (FormatException fe) { flag = true; }
                            if (flag)
                            {
                                string[] p = names[1].Split(',');
                                try { year = Convert.ToInt32(p[1]); }
                                catch (Exception e) { }
                                publication = p[0];
                            }
                        }
                    }


                    // CITATION STUFF
                    no_of_citations = 0;
                    cited_by_url = "Not Found";
                    child = n.SelectSingleNode(".//*[@class=\"gs_fl\"]");
                    if (child != null) child = child.FirstChild;
                    if (child != null)
                    {
                        string text = child.InnerText;
                        cited_by_url = child.GetAttributeValue("href", "Not Found");
                        if (!cited_by_url.Equals("Not Found"))
                        {
                            cited_by_url = "http://scholar.google.com" + cited_by_url;
                            cited_by_url = cited_by_url.Replace("amp;", "");
                        }
                        try
                        {
                            text = text.Replace("Cited by", "");
                            text = text.Trim();
                            no_of_citations = Convert.ToInt32(text);
                        }
                        catch (Exception e) { }
                    }


                    SG.Paper paper = new SG.Paper(title, authors, year, publication, publisher, no_of_citations, cited_by_url, rank);
                    results.addPaper(paper);
                    rank++;
                }

            }
            return results;
        }



        /*
                static void Main(string[] args)
                {

                    Console.WriteLine("here1");
                    string url = "http://scholar.google.com/scholar?q=albert+einstin&btnG=&hl=en&as_sdt=0,5";
                    HtmlWeb web = new HtmlWeb();
                    HtmlDocument doc = web.Load(url);



            



                    // USER PROFILES TAG
                    string profiles_url = "No Url";
                    int flag = 0;
                    string xpath = "//*[@class=\"gs_rt\"]";
                    HtmlNode profileNode = doc.DocumentNode.SelectSingleNode(xpath);
                    if (profileNode != null)
                    {
                        HtmlNode urlNode = profileNode.SelectSingleNode(".//a");
                        if (urlNode != null)
                        {
                            profiles_url = urlNode.GetAttributeValue("href", "No url");
                            if (profiles_url == "No Url") Console.WriteLine("Profile Url not found..!!!");
                            Console.WriteLine("\nUSER PROFILES INFO==============================");
                            Console.WriteLine(urlNode.InnerText + " => " + profiles_url);
                            HtmlNodeCollection urls = profileNode.ParentNode.SelectNodes("./table//a");
                            foreach (HtmlNode n in urls)
                            {
                                flag++;
                                Console.WriteLine(n.InnerText + " => " + n.GetAttributeValue("href", "No URL"));
                            }
                        }
                    }


                    if (flag == 1)
                    {
                        // AUTHOR PAGE
                        profiles_url = "http://scholar.google.com" + profiles_url;
                        profiles_url = profiles_url.Replace("amp;", "");
                       // Program prog = new Program(profiles_url);
                       // prog.getData();
                    }

                    else
                    {
                        //SEARCH RESULTS PAGE

                        var count = 0;
                        do
                        {

                            xpath = "//div[@class=\"gs_ri\"]";
                            HtmlNodeCollection searchResults = doc.DocumentNode.SelectNodes(xpath);
                            if (searchResults == null) Console.WriteLine("No results found");
                            else
                            {

                                foreach (HtmlNode n in searchResults)
                                {
                                    count++;
                                    HtmlNode child = n.FirstChild;
                                    Console.WriteLine("=====================================================\n");
                                    Console.WriteLine("SEARCH RESULT : " + count);
                                    Console.WriteLine("TITLE : " + child.InnerText);
                                    HtmlNode url_node = child.SelectSingleNode(".//a");
                                    if (url_node != null) Console.WriteLine("TITLE-LINK : " + child.SelectSingleNode(".//a").GetAttributeValue("href", "No url"));

                                    child = child.NextSibling;
                                    HtmlNodeCollection cit_urls = child.SelectNodes(".//a");
                                    if (cit_urls != null)
                                    {
                                        Console.WriteLine("CITATIONS : ");
                                        foreach (HtmlNode cn in cit_urls) Console.WriteLine(cn.InnerText + " => " + cn.GetAttributeValue("href", "No URL"));
                                    }
                                    child = child.NextSibling;
                                    Console.WriteLine("SUMMARY :");
                                    Console.WriteLine(child.InnerText);

                                    child = child.NextSibling;
                                    if (child != null) child = child.FirstChild;
                                    if (child != null) Console.WriteLine(child.FirstChild.InnerText + " => " + child.FirstChild.GetAttributeValue("href", "No URL"));

                                }

                                //next page
                                xpath = "//div[@id=\"gs_n\"]//table//td[@align=\"left\"]//a";
                                HtmlNode next_node = doc.DocumentNode.SelectSingleNode(xpath);
                                if (next_node == null) { Console.WriteLine("No more results"); break; }
                                string next_url = next_node.GetAttributeValue("href", "No url");
                                if (next_url.Equals("No url")) { Console.WriteLine("No more results"); break; }
                                next_url = "http://scholar.google.com" + next_url;
                                next_url = next_url.Replace("amp;", "");
                                Console.WriteLine(next_url);
                                doc = web.Load(next_url);

                            }

                        } while (count < 100);


                    }
                    Console.ReadLine();
                }*/
    }
}

