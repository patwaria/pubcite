using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace PubCite
{

    class GSScraper
    {


        private SettingsRecord setRecords = new SettingsRecord();
        private Settings setts;
        private HtmlDocument doc;

     

        bool checkForCaptcha() {
            bool tmp = false;
            if (doc.DocumentNode.InnerHtml.Contains("We're sorry...") && doc.DocumentNode.InnerHtml.Contains("... but your computer or network may be sending automated queries. To protect our users, we can't process your request right now.")) tmp = true;
            if (doc.DocumentNode.InnerHtml.Contains("action=\"Captcha\"") && doc.DocumentNode.InnerHtml.Contains("Our systems have detected unusual traffic from your computer network.")) tmp = true;
            return tmp;
        }


        // SUGGESTIONS FROM SEARCH PAGE
        public SG.AuthSuggestion getAuthSuggestions(string authName)//,ref string next_URL)
        {
            List<string> names = new List<string>();
            List<string> links = new List<string>();

            /*
            if (latestSearch.Equals("default") || (!latestSearch.Equals(authName)))
            {
                loadHtmlDocument(authName);
            }

            
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
            authName = authName.Trim();
            authName = Regex.Replace(authName, @"\s+", "+");
            string url = "http://scholar.google.co.in/citations?view_op=search_authors&mauthors=" + authName + "&hl=en&oi=ao";
            HtmlWeb web = new HtmlWeb();

            try
            {
                doc = web.Load(url);
            }
            catch (Exception e) {
                return null;
            }



            string profiles_url = null;
            string xpath = "//*[@class=\"cit-dark-large-link\"]";
            //string xpath = "//*[@class=\"\"]";
            HtmlNodeCollection profileNode = doc.DocumentNode.SelectNodes(xpath);
            if (profileNode != null)
            {
                foreach (HtmlNode urlNode in profileNode)
                {
                    //HtmlNode urlNode = node.SelectSingleNode(".//a");
                    if (urlNode != null)
                    {
                        profiles_url = urlNode.GetAttributeValue("href", "");
                        names.Add(urlNode.InnerText);
                        if (!profiles_url.Equals(""))
                        {
                            profiles_url = "http://scholar.google.com" + profiles_url;
                            profiles_url = profiles_url.Replace("amp;", "");
                        }
                        links.Add(profiles_url);
                    }

                }


                //NEXT PAGE URL EXTRACTION
                HtmlNode next = doc.DocumentNode.SelectSingleNode("//*[@class=\"g-section cit-dgb\"]//tr/td[2]/a");
                string next_URL;
                if (next != null)
                {
                    next_URL = next.Attributes["href"].Value;
                    next_URL = "http://scholar.google.com" + next_URL;
                    next_URL = next_URL.Replace("amp;", "");
                }
                else next_URL = null;

                //TAKING RESULTS FROM NEXT PAGE
                SG.AuthSuggestion suggestions = new SG.AuthSuggestion(names,links,true);
                getAuthSuggestionsNextPage(next_URL, ref suggestions, ref next_URL);

                return suggestions;
            }
            else return new SG.AuthSuggestion(null, null, false);
        }



        // SUGGESTIONS FROM NEXT PAGE
        public bool getAuthSuggestionsNextPage(string this_url,ref SG.AuthSuggestion suggestions,ref string next_URL)
        {

            if (this_url == null) return false;

            
            List<string> names = new List<string>();
            List<string> links = new List<string>();

            names = suggestions.getSuggestions();
            links = suggestions.getSuggestionsURL();
            /*
            if (latestSearch.Equals("default") || (!latestSearch.Equals(authName)))
            {
                loadHtmlDocument(authName);
            }

            
            // DID U MEAN TAG
            string xpath = "//*[@class=\"gs_med\"]";
            HtmlNode dymNode = doc.DocumentNode.SelectSingleNode(xpath);

            if (dymNode != null)
            {
                Console.WriteLine("\nDID YOU MEAN TAG ");
                Console.WriteLine(dymNode.InnerText);
            }
            */

            // CONNECTIONS
            HtmlWeb web = new HtmlWeb();
            try
            {
                doc = web.Load(this_url);
            }
            catch (Exception e) { return false; }



            string profiles_url = null;
            string xpath = "//*[@class=\"cit-dark-large-link\"]";
            //string xpath = "//*[@class=\"\"]";
            HtmlNodeCollection profileNode = doc.DocumentNode.SelectNodes(xpath);
            if (profileNode != null)
            {
                foreach (HtmlNode urlNode in profileNode)
                {
                    //HtmlNode urlNode = node.SelectSingleNode(".//a");
                    if (urlNode != null)
                    {
                        profiles_url = urlNode.GetAttributeValue("href", "");
                        names.Add(urlNode.InnerText);
                        if (!profiles_url.Equals(""))
                        {
                            profiles_url = "http://scholar.google.com" + profiles_url;
                            profiles_url = profiles_url.Replace("amp;", "");
                        }
                        links.Add(profiles_url);
                    }
                }
            }
            else return false;

            
            //NEXT PAGE URL EXTRACTION
            HtmlNode next = doc.DocumentNode.SelectSingleNode("//*[@class=\"g-section cit-dgb\"]//tr/td[2]/a[2]");
            if (next != null)
            {
                next_URL = next.Attributes["href"].Value;
                next_URL = "http://scholar.google.com" + next_URL;
                next_URL = next_URL.Replace("amp;", "");
            }
            else next_URL = null;

            return true;
        }






        // RESULTS FROM AUTHOR PROFILE PAGE
        public SG.Author getAuthStatistics(string authUrl)
        {
            bool isOK = true;
            if (authUrl == null) return null;
            authUrl += "&pagesize=100";
            GSAuthScraper authScraper = new GSAuthScraper(authUrl, 0,ref isOK);
            if (!isOK) return null;
            authScraper.getCitationStats();
            SG.Author author = new SG.Author(authScraper.getName(), authScraper.getAffiliation(), authScraper.getHomePage(), authScraper.getHIndex(), authScraper.getIIndex());
            //Console.WriteLine(author.Name + "," + author.getHIndex() + "," + author.getI10Index());
            List<SG.Paper> papers = authScraper.getPapersOfCurrentPage();
            if (papers == null) return null;
            if (papers.Count == 0) return author;
            foreach (SG.Paper paper in papers) author.addPaper(paper);
            return author;
        }

        public bool? getAuthStatisticsNextPage(string authUrl, ref SG.Author author)
        {
            bool isOK = true;
            setts = setRecords.ReadSettings();
            int maxResults = setts.GSMaxResults;
            int num = author.getNumberOfPapers();
            if (num < 0) return false;
            if (num % 100 != 0) return false;
            if (num >= maxResults) return false;
            authUrl += ("&pagesize=100&cstart=" + num);
            GSAuthScraper authScraper = new GSAuthScraper(authUrl, num, ref isOK);
            if (!isOK) return null;
            List<SG.Paper> papers = authScraper.getPapersOfCurrentPage();
            if (papers == null) return null;
            if (papers.Count == 0) return false;
            foreach (SG.Paper paper in papers)
            {
                if (num == maxResults) return false;
                author.addPaper(paper);
                num++;
            }
            return true;
        }









        // SEARCH PAGE RESULTS
        public SG.Author getAuthors(string authName, string affiliation, string keywords, ref string next_url)
        {

            // CONNECTIONS

            SG.Author result = new SG.Author(authName);
            if (authName == null) authName = "";
            else
            {
                authName.Trim();
                authName = Regex.Replace(authName, @"\s+", "+");
                //authName = authName.Insert(0, "author:");
                //Console.WriteLine(authName);
            }
            if (affiliation == null) affiliation = "";
            else
            {
                affiliation = affiliation.Trim();
                affiliation = Regex.Replace(affiliation, @"\s+", "+");
            }
            if (keywords == null) keywords = "";
            else
            {
                keywords = keywords.Trim();
                keywords = Regex.Replace(keywords, @"\s+", "+");
            }



            //string url = "http://scholar.google.com/scholar?q=" + authName + "&btnG=&hl=en&as_sdt=1.";//keywords + "&as_epq=&as_oq=" //affiliation + "&as_eq=&as_occt=any&as_sauthors=" + authName;// + "&as_publication=&as_ylo=&as_yhi=&btnG=&hl=en&as_sdt=0%2C5";
            string url = "http://scholar.google.com/scholar?as_q=&as_epq=&as_oq=&as_eq=&as_occt=any&as_sauthors="  + authName + "&as_publication=&as_ylo=&as_yhi=&btnG=&hl=en&as_sdt=0,5&num=20";

            Console.WriteLine(url);
            HtmlWeb web = new HtmlWeb();

            try
            {
                doc = web.Load(url);
            }
            catch (Exception e) {
                return null;
            }


            //Console.WriteLine(doc.DocumentNode.InnerHtml);


            string xpath = "//div[@class=\"gs_ri\"]";
            string title, titleLink, authors, publication, publisher, cited_by_url, summary;
            int year, rank = 1, no_of_citations;
            HtmlNodeCollection searchResults = doc.DocumentNode.SelectNodes(xpath);
            if (searchResults == null)
            {
                if (checkForCaptcha())
                {
                    Console.WriteLine("Captcha problem ...");
                    return null;
                }
                Console.WriteLine("No results ...");
                return result;
            }
            else
            {
                Console.WriteLine(url);
                foreach (HtmlNode n in searchResults)
                {

                    // TITLE AND TITLE LINK
                    HtmlNode child = n.SelectSingleNode(".//*[@class=\"gs_rt\"]");
                    title = child.InnerText;
                    titleLink = "";
                    HtmlNode url_node = child.SelectSingleNode(".//a");
                    if (url_node != null)
                    {
                        titleLink = url_node.GetAttributeValue("href", "");
                        if (!titleLink.Equals(""))
                        {
                            //titleLink = "http://scholar.google.com" + titleLink;
                            titleLink = titleLink.Replace("amp;", "");
                        }
                    }
                    // AUTHORS AND PUBLICATION
                    child = n.SelectSingleNode(".//*[@class=\"gs_a\"]");
                    authors = "";
                    publication = "";
                    publisher = "";
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

                    // SUMMARY
                    child = n.SelectSingleNode(".//*[@class=\"gs_rs\"]");
                    summary = "";
                    if (child != null)
                    {
                        summary = child.InnerText;
                    }


                    // CITATION STUFF
                    no_of_citations = 0;
                    cited_by_url = "";
                    child = n.SelectSingleNode(".//*[@class=\"gs_fl\"]");
                    if (child != null) child = child.FirstChild;
                    if (child != null)
                    {
                        string text = child.InnerText;

                        try
                        {
                            text = text.Replace("Cited by", "");
                            text = text.Trim();
                            no_of_citations = Convert.ToInt32(text);
                        }
                        catch (Exception e) { }

                        cited_by_url = no_of_citations != 0 ? child.GetAttributeValue("href", "") : "";
                        if (!cited_by_url.Equals(""))
                        {
                            cited_by_url = "http://scholar.google.com" + cited_by_url;
                            cited_by_url = cited_by_url.Replace("amp;", "");
                        }

                    }

                    publisher.Trim();
                    publication.Trim();
                    SG.Paper paper = new SG.Paper(title, titleLink, authors, summary, year, publication, publisher, no_of_citations, cited_by_url, rank);
                    result.addPaper(paper);
                    rank++;
                }


                //NEXT PAGE URL
                HtmlNode bottom = doc.DocumentNode.SelectSingleNode(".//*[@id=\"gs_n\"]//table//td[@align=\"left\"]//a");
                if (bottom != null)
                {
                    url = bottom.GetAttributeValue("href", "");
                    if (!url.Equals(""))
                    {
                        url = "http://scholar.google.com" + url;
                        url = url.Replace("amp;", "");
                        next_url = url;
                    }
                    else next_url = null;
                }
                else next_url = null;

            }
            return result;
        }


        // SEARCH PAGE RESULTS NEXT PAGE
        public bool? getAuthorsNextPage(string this_url, ref SG.Author author, ref string next_url)
        {

            setts = setRecords.ReadSettings();
            int maxResults = setts.GSMaxResults;
            int num = author.getNumberOfPapers();
            if (num >= maxResults) return false;
            
            // CONNECTIONS
            if (this_url == null) return false;
            HtmlWeb web = new HtmlWeb();

            try
            {
                doc = web.Load(this_url);
            }
            catch (Exception e) {
                return null;
            }


            //Console.WriteLine(doc.DocumentNode.InnerHtml);


            string xpath = "//div[@class=\"gs_ri\"]";
            string title, titleLink, authors, publication, publisher, cited_by_url, summary;
            int year, rank = author.getNumberOfPapers() + 1, no_of_citations;
            HtmlNodeCollection searchResults = doc.DocumentNode.SelectNodes(xpath);
            if (searchResults == null)
            {
                if (checkForCaptcha())
                {
                    Console.WriteLine("Captcha problem ...");
                    return null;
                }
                Console.WriteLine("No results ...");
                return false;
            }
            else
            {
                //Console.WriteLine(url);
                foreach (HtmlNode n in searchResults)
                {

                    // TITLE AND TITLE LINK
                    HtmlNode child = n.SelectSingleNode(".//*[@class=\"gs_rt\"]");
                    title = child.InnerText;
                    titleLink = "";
                    HtmlNode url_node = child.SelectSingleNode(".//a");
                    if (url_node != null)
                    {
                        titleLink = url_node.GetAttributeValue("href", "");
                        if (!titleLink.Equals(""))
                        {
                            //titleLink = "http://scholar.google.com" + titleLink;
                            titleLink = titleLink.Replace("amp;", "");
                        }
                    }
                    // AUTHORS AND PUBLICATION
                    child = n.SelectSingleNode(".//*[@class=\"gs_a\"]");
                    authors = "";
                    publication = "";
                    publisher = "";
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

                    // SUMMARY
                    child = n.SelectSingleNode(".//*[@class=\"gs_rs\"]");
                    summary = "";
                    if (child != null)
                    {
                        summary = child.InnerText;
                    }


                    // CITATION STUFF
                    no_of_citations = 0;
                    cited_by_url = "";
                    child = n.SelectSingleNode(".//*[@class=\"gs_fl\"]");
                    if (child != null) child = child.FirstChild;
                    if (child != null)
                    {
                        string text = child.InnerText;

                        try
                        {
                            text = text.Replace("Cited by", "");
                            text = text.Trim();
                            no_of_citations = Convert.ToInt32(text);
                        }
                        catch (Exception e) { }

                        cited_by_url = no_of_citations != 0 ? child.GetAttributeValue("href", "") : "";
                        if (!cited_by_url.Equals(""))
                        {
                            cited_by_url = "http://scholar.google.com" + cited_by_url;
                            cited_by_url = cited_by_url.Replace("amp;", "");
                        }

                    }

                    publisher.Trim();
                    publication.Trim();
                    if (num == maxResults) return false;
                    SG.Paper paper = new SG.Paper(title, titleLink, authors, summary, year, publication, publisher, no_of_citations, cited_by_url, rank);
                    author.addPaper(paper);
                    num++;
                    rank++;
                }


                //NEXT PAGE URL
                HtmlNode bottom = doc.DocumentNode.SelectSingleNode(".//*[@id=\"gs_n\"]//table//td[@align=\"left\"]//a");
                if (bottom != null)
                {
                    string url = bottom.GetAttributeValue("href", "");
                    if (!url.Equals(""))
                    {
                        url = "http://scholar.google.com" + url;
                        url = url.Replace("amp;", "");
                        next_url = url;
                    }
                    else next_url = null;
                }
                else next_url = null;

            }
            return true;
        }






        //  JOURNAL SEARCH RESULTS
        public SG.Journal getJournals(string journalName, string ISSN, string keywords, ref string next_url)
        {


            // CONNECTIONS

            if (journalName == null) journalName = null;
            else journalName.Trim();
            SG.Journal result = new SG.Journal(journalName);

            // FORMATTIONG STRINGS
            if (ISSN == null) ISSN = "";
            else
            {
                ISSN = ISSN.Trim();
                ISSN = Regex.Replace(ISSN, @"\s+", "+");
            }
            if (keywords == null) keywords = "";
            else
            {
                keywords = keywords.Trim();
                keywords = Regex.Replace(keywords, @"\s+", "+");
            }
            string temp = (ISSN.Equals("") || keywords.Equals("")) ? keywords + ISSN : keywords + "+" + ISSN;


            string name = Regex.Replace(journalName, @"\s+", "+");
            string url = "http://scholar.google.com/scholar?as_q=&as_epq=&as_oq=&as_eq=&as_occt=any&as_sauthors=&as_publication=" + journalName + "&as_ylo=&as_yhi=&btnG=&hl=en&as_sdt=0,5&num=20";
            //string url = "http://scholar.google.co.in/scholar?hl=en&q=anil+kumar&btnG=&as_sdt=1,5&as_sdtp=";
            Console.WriteLine(url);

            //Console.WriteLine("loaded !!!");


            HtmlWeb web = new HtmlWeb();

            try
            {
                doc = web.Load(url);
            }
            catch (Exception e)
            {
                return null;
            }

            //Console.WriteLine(doc.DocumentNode.InnerHtml);
            //string html = client.DownloadString(url);
            //doc.LoadHtml(html);


            string xpath = "//div[@class=\"gs_ri\"]";
            string title, titleLink, authors, publication, publisher, cited_by_url, summary;
            int year, rank = 1, no_of_citations;
            HtmlNodeCollection searchResults = doc.DocumentNode.SelectNodes(xpath);
            if (searchResults == null)
            {
                if (checkForCaptcha())
                {
                    Console.WriteLine("Captcha problem ...");
                    return null;
                }
                Console.WriteLine("No results ...");
                return result;
            }
            else
            {
                foreach (HtmlNode n in searchResults)
                {

                    // TITLE AND TITLE LINK
                    HtmlNode child = n.SelectSingleNode(".//*[@class=\"gs_rt\"]");
                    title = child.InnerText;
                    titleLink = "";
                    HtmlNode url_node = child.SelectSingleNode(".//a");
                    if (url_node != null)
                    {
                        titleLink = url_node.GetAttributeValue("href", "");
                        if (!titleLink.Equals(""))
                        {
                            //titleLink = "http://scholar.google.com" + titleLink;
                            titleLink = titleLink.Replace("amp;", "");
                        }
                    }

                    // AUTHORS AND PUBLICATION
                    child = n.SelectSingleNode(".//*[@class=\"gs_a\"]");
                    authors = "";
                    publication = "";
                    publisher = "";
                    year = -1;
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

                    // SUMMARY
                    child = n.SelectSingleNode(".//*[@class=\"gs_rs\"]");
                    summary = "";
                    if (child != null)
                    {
                        summary = child.InnerText;
                    }


                    // CITATION STUFF
                    no_of_citations = 0;
                    cited_by_url = "";
                    child = n.SelectSingleNode(".//*[@class=\"gs_fl\"]");
                    if (child != null) child = child.FirstChild;
                    if (child != null)
                    {

                        string text = child.InnerText;

                        try
                        {
                            text = text.Replace("Cited by", "");
                            text = text.Trim();
                            no_of_citations = Convert.ToInt32(text);
                        }
                        catch (Exception e) { }

                        cited_by_url = no_of_citations != 0 ? child.GetAttributeValue("href", "") : "";
                        if (!cited_by_url.Equals(""))
                        {
                            cited_by_url = "http://scholar.google.com" + cited_by_url;
                            cited_by_url = cited_by_url.Replace("amp;", "");
                        }

                    }


                    SG.Paper paper = new SG.Paper(title, titleLink, authors, summary, year, publication, publisher, no_of_citations, cited_by_url, rank);
                    result.addPaper(paper);
                    rank++;
                }

                //NEXT PAGE URL
                HtmlNode bottom = doc.DocumentNode.SelectSingleNode(".//*[@id=\"gs_n\"]//table//td[@align=\"left\"]//a");
                if (bottom != null)
                {
                    url = bottom.GetAttributeValue("href", "");
                    if (!url.Equals(""))
                    {
                        url = "http://scholar.google.com" + url;
                        url = url.Replace("amp;", "");
                        next_url = url;
                    }
                    else next_url = null;
                }
                else next_url = null;
            }
            return result;
        }






        //  JOURNAL SEARCH RESULTS NEXT PAGE
        public bool? getJournalsNextPage(string this_url, ref SG.Journal journal, ref string next_url)
        {



            setts = setRecords.ReadSettings();
            int maxResults = setts.GSMaxResults;
            int num = journal.getNumberOfPapers();
            if (num >= maxResults) return false;

            // CONNECTIONS
            if (this_url == null) return false;
            HtmlWeb web = new HtmlWeb();


            try
            {
                doc = web.Load(this_url);
            }
            catch (Exception e)
            {
                return null;
            }


            //Console.WriteLine(doc.DocumentNode.InnerHtml);
            //string html = client.DownloadString(url);
            //doc.LoadHtml(html);


            string xpath = "//div[@class=\"gs_ri\"]";
            string title, titleLink, authors, publication, publisher, cited_by_url, summary;
            int year, rank = 1 + journal.getNumberOfPapers(), no_of_citations;
            HtmlNodeCollection searchResults = doc.DocumentNode.SelectNodes(xpath);
            if (searchResults == null)
            {
                if (checkForCaptcha())
                {
                    Console.WriteLine("Captcha problem ...");
                    return null;
                }
                Console.WriteLine("No results ...");
                return false;
            }
            else
            {
                foreach (HtmlNode n in searchResults)
                {

                    // TITLE AND TITLE LINK
                    HtmlNode child = n.SelectSingleNode(".//*[@class=\"gs_rt\"]");
                    title = child.InnerText;
                    titleLink = "";
                    HtmlNode url_node = child.SelectSingleNode(".//a");
                    if (url_node != null)
                    {
                        titleLink = url_node.GetAttributeValue("href", "");
                        if (!titleLink.Equals(""))
                        {
                            //titleLink = "http://scholar.google.com" + titleLink;
                            titleLink = titleLink.Replace("amp;", "");
                        }
                    }

                    // AUTHORS AND PUBLICATION
                    child = n.SelectSingleNode(".//*[@class=\"gs_a\"]");
                    authors = "";
                    publication = "";
                    publisher = "";
                    year = -1;
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

                    // SUMMARY
                    child = n.SelectSingleNode(".//*[@class=\"gs_rs\"]");
                    summary = "";
                    if (child != null)
                    {
                        summary = child.InnerText;
                    }


                    // CITATION STUFF
                    no_of_citations = 0;
                    cited_by_url = "";
                    child = n.SelectSingleNode(".//*[@class=\"gs_fl\"]");
                    if (child != null) child = child.FirstChild;
                    if (child != null)
                    {

                        string text = child.InnerText;

                        try
                        {
                            text = text.Replace("Cited by", "");
                            text = text.Trim();
                            no_of_citations = Convert.ToInt32(text);
                        }
                        catch (Exception e) { }

                        cited_by_url = no_of_citations != 0 ? child.GetAttributeValue("href", "") : "";
                        if (!cited_by_url.Equals(""))
                        {
                            cited_by_url = "http://scholar.google.com" + cited_by_url;
                            cited_by_url = cited_by_url.Replace("amp;", "");
                        }

                    }

                    if (num == maxResults) return false;
                    SG.Paper paper = new SG.Paper(title, titleLink, authors, summary, year, publication, publisher, no_of_citations, cited_by_url, rank);
                    journal.addPaper(paper);
                    num++;
                    rank++;
                }

                //NEXT PAGE URL
                HtmlNode bottom = doc.DocumentNode.SelectSingleNode(".//*[@id=\"gs_n\"]//table//td[@align=\"left\"]//a");
                if (bottom != null)
                {
                    string url = bottom.GetAttributeValue("href", "");
                    if (!url.Equals(""))
                    {
                        url = "http://scholar.google.com" + url;
                        url = url.Replace("amp;", "");
                        next_url = url;
                    }
                    else next_url = null;
                }
                else next_url = null;
            }
            return true;
        }




        // GET CITATIONS FROM CITATION-PAGE
        public List<SG.Paper> getCitations(string url, ref string next_url)
        {

            // CONNECTIONS
            HtmlWeb web = new HtmlWeb();
            if (url == null) return null;
            url += "&num=20";
                 
            try
            {
                doc = web.Load(url);
            }
            catch (Exception e)
            {
                return null;
            }

            List<SG.Paper> results = new List<SG.Paper>();

            string xpath = "//div[@class=\"gs_ri\"]";
            string title, titleLink, authors, publication, publisher, cited_by_url, summary;
            int year, rank = 1, no_of_citations;
            HtmlNodeCollection searchResults = doc.DocumentNode.SelectNodes(xpath);
            if (searchResults == null)
            {
                if (checkForCaptcha())
                {
                    Console.WriteLine("Captcha problem ...");
                    return null;
                }
                Console.WriteLine("No results ...");
                return results;
            }
            else
            {

                foreach (HtmlNode n in searchResults)
                {

                    // TITLE AND TITLE LINK
                    HtmlNode child = n.SelectSingleNode(".//*[@class=\"gs_rt\"]");
                    title = child.InnerText;
                    titleLink = "";
                    HtmlNode url_node = child.SelectSingleNode(".//a");
                    if (url_node != null)
                    {
                        titleLink = url_node.GetAttributeValue("href", "");
                        if (!titleLink.Equals(""))
                        {
                            //titleLink = "http://scholar.google.com" + titleLink;
                            titleLink = titleLink.Replace("amp;", "");
                        }
                    }

                    // AUTHORS AND PUBLICATION
                    child = n.SelectSingleNode(".//*[@class=\"gs_a\"]");
                    authors = "";
                    publication = "";
                    publisher = "";
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

                    // SUMMARY
                    child = n.SelectSingleNode(".//*[@class=\"gs_rs\"]");
                    summary = "";
                    if (child != null)
                    {
                        summary = child.InnerText;
                    }


                    // CITATION STUFF
                    no_of_citations = 0;
                    cited_by_url = "";
                    child = n.SelectSingleNode(".//*[@class=\"gs_fl\"]");
                    if (child != null) child = child.FirstChild;
                    if (child != null)
                    {
                        string text = child.InnerText;
                        cited_by_url = child.GetAttributeValue("href", "");
                        if (!cited_by_url.Equals(""))
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


                    SG.Paper paper = new SG.Paper(title, titleLink, authors, summary, year, publication, publisher, no_of_citations, cited_by_url, rank);
                    results.Add(paper);
                    rank++;
                }

                //NEXT PAGE URL
                HtmlNode bottom = doc.DocumentNode.SelectSingleNode(".//*[@id=\"gs_n\"]//table//td[@align=\"left\"]//a");
                if (bottom != null)
                {
                    url = bottom.GetAttributeValue("href", "");
                    if (!url.Equals(""))
                    {
                        url = "http://scholar.google.com" + url;
                        url = url.Replace("amp;", "");
                        next_url = url;
                    }
                    else next_url = null;
                }
                else next_url = null;
            }

            return results;
        }





        // GET CITATIONS NEXT PAGE
        public  bool? getCitationsNextPage(string url, ref string next_url, ref List<SG.Paper> papers)
        {


            setts = setRecords.ReadSettings();
            int maxResults = setts.GSMaxResults;
            int num = papers.Count;
            if (num >= maxResults) return false;


            // CONNECTIONS
            if (url == null) return false;
            HtmlWeb web = new HtmlWeb();

            try
            {
                doc = web.Load(url);
            }
            catch (Exception e)
            {
                return null;
            }
            
            List<SG.Paper> results = new List<SG.Paper>();

            string xpath = "//div[@class=\"gs_ri\"]";
            string title, titleLink, authors, publication, publisher, cited_by_url, summary;
            int year, rank = 1, no_of_citations;
            HtmlNodeCollection searchResults = doc.DocumentNode.SelectNodes(xpath);
            if (searchResults == null)
            {
                if (checkForCaptcha())
                {
                    Console.WriteLine("Captcha problem ...");
                    return null;
                }
                Console.WriteLine("No results ...");
                return false;
            }
            else
            {

                foreach (HtmlNode n in searchResults)
                {

                    // TITLE AND TITLE LINK
                    HtmlNode child = n.SelectSingleNode(".//*[@class=\"gs_rt\"]");
                    title = child.InnerText;
                    titleLink = "";
                    HtmlNode url_node = child.SelectSingleNode(".//a");
                    if (url_node != null)
                    {
                        titleLink = url_node.GetAttributeValue("href", "");
                        if (!titleLink.Equals(""))
                        {
                            //titleLink = "http://scholar.google.com" + titleLink;
                            titleLink = titleLink.Replace("amp;", "");
                        }
                    }

                    // AUTHORS AND PUBLICATION
                    child = n.SelectSingleNode(".//*[@class=\"gs_a\"]");
                    authors = "";
                    publication = "";
                    publisher = "";
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

                    // SUMMARY
                    child = n.SelectSingleNode(".//*[@class=\"gs_rs\"]");
                    summary = "";
                    if (child != null)
                    {
                        summary = child.InnerText;
                    }


                    // CITATION STUFF
                    no_of_citations = 0;
                    cited_by_url = "";
                    child = n.SelectSingleNode(".//*[@class=\"gs_fl\"]");
                    if (child != null) child = child.FirstChild;
                    if (child != null)
                    {
                        string text = child.InnerText;
                        cited_by_url = child.GetAttributeValue("href", "");
                        if (!cited_by_url.Equals(""))
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

                    if (num == maxResults) return false;
                    SG.Paper paper = new SG.Paper(title, titleLink, authors, summary, year, publication, publisher, no_of_citations, cited_by_url, rank);
                    results.Add(paper);
                    num++;
                    rank++;
                }

                //NEXT PAGE URL
                HtmlNode bottom = doc.DocumentNode.SelectSingleNode(".//*[@id=\"gs_n\"]//table//td[@align=\"left\"]//a");
                if (bottom != null)
                {
                    url = bottom.GetAttributeValue("href", "");
                    if (!url.Equals(""))
                    {
                        url = "http://scholar.google.com" + url;
                        url = url.Replace("amp;", "");
                        next_url = url;
                    }
                    else next_url = null;
                }
                else next_url = null;
            }

            foreach (SG.Paper p in results)
                papers.Add(p);
            return true;
        }



    }

}

















