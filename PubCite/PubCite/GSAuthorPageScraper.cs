using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace PubCite
{
    class GSAuthScraper
    {
        private HtmlWeb web;
        private HtmlDocument doc;
        private HtmlNodeCollection tables;
        private int h_index, i_index;
        private string name,homepageLink,affiliation;
        private List<SG.Paper> papers;
        int index;

        public GSAuthScraper(String inital_URL,int i)
        {
            web = new HtmlWeb();

            try
            {
                doc = web.Load(inital_URL);
            }
            catch (Exception e) { Console.WriteLine("=====Exception occurred(web load) in GSAuthScraperNextPAge()"); }



            tables = doc.DocumentNode.SelectNodes("//table");
            h_index = i_index = -1;
            name = doc.DocumentNode.SelectSingleNode(".//*[@id=\"cit-name-display\"]").InnerText;
            //getCitationStats();
            index = i+1;
            papers = new List<SG.Paper>();


        }

        public void getCitationStats()
        {
            HtmlNodeCollection rows, cols;

            rows = tables[2].SelectNodes(".//tr");
            //cols = rows[1].SelectNodes(".//td");
            //Console.WriteLine("All Citations : " + cols[1].InnerText + "; Since 2008 : " + cols[2].InnerText);
            //cols[1].InnerText for all citations cols[2].InnerText for since 2008

            cols = rows[2].SelectNodes(".//td");
            //Console.WriteLine("All h-index : " + cols[1].InnerText + "; Since 2008 : " + cols[2].InnerText);
            //cols[1].InnerText for all h-Index cols[2].InnerText for since 2008
            try { h_index = Convert.ToInt32(cols[1].InnerText); }
            catch (Exception e) { }

            cols = rows[3].SelectNodes(".//td");
            //Console.WriteLine("All i10-index : " + cols[1].InnerText + "; Since 2008 : " + cols[2].InnerText);
            //cols[1].InnerText for all i10-Index cols[2].InnerText for since 2008
            try { i_index = Convert.ToInt32(cols[1].InnerText); }
            catch (Exception e) { }

            // home page and affiliation
            homepageLink = "";
            HtmlNode homePage = doc.DocumentNode.SelectSingleNode(".//*[@id=\"cit-homepage-read\"]");
            if (homePage != null)
            {
                HtmlNode urlhome = homePage.SelectSingleNode(".//a");
                if (urlhome != null) homepageLink = urlhome.GetAttributeValue("href", "");
            }

            affiliation = "";
            HtmlNode affPage = doc.DocumentNode.SelectSingleNode(".//*[@id=\"cit-affiliation-form\"]");
            if (affPage != null)
            {
                affiliation = affPage.InnerText;
            }
        }

        public bool nextPage(int callFirstTime)   //callFirstTime must be 1 if this is called first time
        {
            bool pageStatus = false;
            String next_URL;
            HtmlNode next;
            if (callFirstTime == 1)
            {

                // Console.WriteLine(doc.DocumentNode.InnerHtml);
                next = doc.DocumentNode.SelectSingleNode("//*[@class=\"g-section cit-dgb\"]//tr/td[2]/a");
                if (next != null)
                {
                    next_URL = next.Attributes["href"].Value;
                    next_URL = "http://scholar.google.com" + next_URL;
                    next_URL = next_URL.Replace("amp;", "");
                    
                    try
                    {
                        doc = web.Load(next_URL);
                    }
                    catch (Exception e) { Console.WriteLine("=====Exception occurred(web load) in GSAuthScraperNextPAge()");}

                    tables = doc.DocumentNode.SelectNodes("//table");
                    pageStatus = true;
                    return pageStatus;
                }

            }
            else
            {
                next = doc.DocumentNode.SelectSingleNode("//*[@class=\"g-section cit-dgb\"]//tr/td[2]/a[2]");
                if (next != null)
                {
                    next_URL = next.Attributes["href"].Value;
                    next_URL = "http://scholar.google.com" + next_URL;
                    next_URL = next_URL.Replace("amp;", "");

                    try
                    {
                        doc = web.Load(next_URL);
                    }
                    catch (Exception e) { Console.WriteLine("=====Exception occurred(web load) in GSAuthScraperNextPAge()"); }



                    tables = doc.DocumentNode.SelectNodes("//table");
                    // Console.WriteLine(tables.ToString());
                    pageStatus = true;
                    return pageStatus;
                }
            }
            return pageStatus;
        }


        bool checkForCaptcha()
        {
            bool tmp = false;
            if (doc.DocumentNode.InnerHtml.Contains("We're sorry...") && doc.DocumentNode.InnerHtml.Contains("... but your computer or network may be sending automated queries. To protect our users, we can't process your request right now.")) tmp = true;
            if (doc.DocumentNode.InnerHtml.Contains("action=\"Captcha\"") && doc.DocumentNode.InnerHtml.Contains("Our systems have detected unusual traffic from your computer network.")) tmp = true;
            return tmp;
        }


        private int getCitationData(/*Probably pass the array of objects and the index it has to write to*/) //Return the index of next free index
        {
            HtmlNodeCollection rows = doc.DocumentNode.SelectNodes(".//tr[@class=\"cit-table item\"]");
            string title,titleLink, authors, publication, publisher, cited_by_url;
            int year, no_of_citations;
            if (rows == null)
            {
                if (checkForCaptcha()) {
                    Console.WriteLine("Captcha Problem...");
                    return 0;
                }
                Console.WriteLine("No results...");
                return -1;
            }
            papers.Clear();

            foreach (HtmlNode row in rows)
            {
                //Console.WriteLine(rows.Count);
                //YEAR OF PUBLICATION
                HtmlNode yearNode = row.SelectSingleNode(".//*[@id=\"col-year\"]");
                year = -1;
                if (yearNode != null && !yearNode.InnerText.Equals(""))
                {
                    String yr = yearNode.InnerText;
                    yr.Trim();
                    try { year = Convert.ToInt32(yr); }
                    catch (Exception e) { }
                    //Console.WriteLine("YEAR OF PUBLICATION : " + cols[4].InnerText);
                }
                //Console.WriteLine(year);

                HtmlNode titleNode = row.SelectSingleNode(".//*[@id=\"col-title\"]");
                //set the paper name to nameNode.InnerText
                //Console.WriteLine("PAPER NAME : " + nameNode.InnerText);
                HtmlNode nameNode = titleNode.SelectSingleNode(".//a");
                title = nameNode.InnerText;

                // TITLE-LINK
                //titleLink = nameNode.Attributes["href"].Value;
                //set the paper link to url_link.Inner_Text. First check if link begins with "http://...". If not add "http://scholar.google.co.in/"
                //titleLink=url_link;
                titleLink = nameNode.GetAttributeValue("href", "");
                if (!titleLink.Equals(""))
                {
                                titleLink = "http://scholar.google.com" + titleLink;
                                titleLink = titleLink.Replace("amp;", "");
                }

                 

                HtmlNodeCollection nodes = titleNode.SelectNodes(".//span");
                //set the author name string to nameNode.InnerText
                //Console.WriteLine("AUTHOR NAME : " + nameNode.InnerText);

                // PUBLICATION
                authors = "";
                publication = "";
                publisher = "";
                if (nodes != null)
                {
                    authors = nodes[0].InnerText;
                    if (nodes.Count > 1) publication = nodes[1].InnerText;
                }



                // CITATION STUFF
                nameNode = row.SelectSingleNode(".//*[@id=\"col-citedby\"]");
                //set the number of citations to nameNode.InnerText
                //Console.WriteLine("NO OF CITATIONS : " + nameNode.InnerText);
                no_of_citations = 0;
                cited_by_url = "";
                if (nameNode != null && nameNode.FirstChild != null)
                {
                    try { no_of_citations = Convert.ToInt32(nameNode.FirstChild.InnerText.Trim()); }
                    catch (Exception e) { }
                    cited_by_url = nameNode.FirstChild.GetAttributeValue("href", "");
                    if (!cited_by_url.Equals(""))
                    {
                        // cited_by_url = "http://scholar.google.com" + cited_by_url;
                        cited_by_url = cited_by_url.Replace("amp;", "");
                    }
                }

                //url_link = nameNode.Attributes["href"].Value;
                //set the citations link to url_link.Inner_Text. First check if link begins with "http://...". If not add "http://scholar.google.co.in/". If "javascript void(0)" is found set citation link to null
                papers.Add(new SG.Paper(title,titleLink, authors, year, publication, publisher, no_of_citations, cited_by_url, index));
                index++;
            }

            return 1;
        }

        public List<string> getCoAuthors() { 
            HtmlNode authorNode = doc.DocumentNode.SelectSingleNode("//*[@id=\"gs_top\"]/div/div[1]/div[1]/div[2]/div[2]/div[4]");
            HtmlNodeCollection nodes = authorNode.SelectNodes("./a");
            if (nodes == null) return null;
            List<string> list = new List<string>();
            foreach (HtmlNode n in nodes) list.Add(n.Attributes["title"].ToString());
            return list;
        }


        public int getHIndex() { return h_index; }
        public int getIIndex() { return i_index; }
        public string getName() { return name; }
        public string getHomePage() { return homepageLink;   }
        public string getAffiliation() { return affiliation;     }
        public List<SG.Paper> getPapersOfCurrentPage()
        {
            int id = getCitationData();
            if(id==0) return null;
            if (id == -1) return new List<SG.Paper>();
            //foreach (SG.Paper pap in papers) { Console.WriteLine(pap.Title); }
            return papers;
        }
    }
}
