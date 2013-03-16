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
        private string name;
        private List<SG.Paper> papers;

        public GSAuthScraper(String inital_URL)
        {
            web = new HtmlWeb();
            doc = web.Load(inital_URL);
            tables = doc.DocumentNode.SelectNodes("//table");
            h_index = i_index = -1;
            name = doc.DocumentNode.SelectSingleNode(".//*[@id=\"cit-name-display\"]").InnerText;
            getCitationStats();
            papers = new List<SG.Paper>();
        }

        private void getCitationStats()
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
        }

        private bool nextPage(int callFirstTime)   //callFirstTime must be 1 if this is called first time
        {
            bool pageStatus = false;
            String next_URL;
            HtmlNode next;
            if (callFirstTime == 1)
            {
                next = doc.DocumentNode.SelectSingleNode("//*[@id=\"citationsForm\"]/div[1]/div/table/tbody/tr/td[2]/a");
                if (next != null)
                {
                    next_URL = next.Attributes["href"].Value;
                    doc = web.Load(next_URL);

                    tables = doc.DocumentNode.SelectNodes("//table");
                    pageStatus = true;
                    return pageStatus;
                }

            }
            else
            {
                next = doc.DocumentNode.SelectSingleNode("//*[@id=\"citationsForm\"]/div[1]/div/table/tbody/tr/td[2]/a[2]");

                if (next != null)
                {
                    next_URL = next.Attributes["href"].Value;
                    doc = web.Load(next_URL);

                    tables = doc.DocumentNode.SelectNodes("//table");
                    Console.WriteLine(tables.ToString());
                    pageStatus = true;
                    return pageStatus;
                }
            }
            return pageStatus;
        }

        private int getCitationData(/*Probably pass the array of objects and the index it has to write to*/) //Return the index of next free index
        {
            HtmlNodeCollection rows, cols;
            HtmlNode nameNode;
            int index = 1; //Initialize index with free index

            rows = tables[4].SelectNodes(".//tr");   // The table 4 contains the main data in our html

            string title, titleLink, authors, publication, publisher, cited_by_url;
            int year, no_of_citations;

            for (int i = 1; i < rows.Count; ++i)
            {

                cols = rows[i].SelectNodes(".//td");

                //set the year of publication to cols[4].InnerText
                year = -1;
                try { year = Convert.ToInt32(cols[4].InnerText); }
                catch (Exception e) { }
                //Console.WriteLine("YEAR OF PUBLICATION : " + cols[4].InnerText);

                nameNode = cols[1].SelectSingleNode("a");
                //set the paper name to nameNode.InnerText
                //Console.WriteLine("PAPER NAME : " + nameNode.InnerText);
                title = nameNode.InnerText;

                //titleLink = nameNode.Attributes["href"].Value;
                //set the paper link to url_link.Inner_Text. First check if link begins with "http://...". If not add "http://scholar.google.co.in/"
                //titleLink=url_link;
                titleLink = nameNode.GetAttributeValue("href", "Not Found");
                if (!titleLink.Equals("Not Found"))
                {
                    titleLink = "http://scholar.google.com" + titleLink;
                    titleLink = titleLink.Replace("amp;", "");
                }

                HtmlNodeCollection nodes = cols[1].SelectNodes("span");
                //set the author name string to nameNode.InnerText
                //Console.WriteLine("AUTHOR NAME : " + nameNode.InnerText);

                authors = nodes[0].InnerText;

                publication = "Not Found";
                if (nodes.Count > 1) publication = nodes[1].InnerText;

                publisher = "Not Found";

                nameNode = cols[2].SelectSingleNode("a");
                //set the number of citations to nameNode.InnerText
                //Console.WriteLine("NO OF CITATIONS : " + nameNode.InnerText);
                no_of_citations = 0;
                try { no_of_citations = Convert.ToInt32(nameNode.InnerText); }
                catch (Exception e) { }
                cited_by_url = nameNode.GetAttributeValue("href", "Not Found");
                if (!cited_by_url.Equals("Not Found"))
                {
                    // cited_by_url = "http://scholar.google.com" + cited_by_url;
                    cited_by_url = cited_by_url.Replace("amp;", "");
                }


                //url_link = nameNode.Attributes["href"].Value;
                //set the citations link to url_link.Inner_Text. First check if link begins with "http://...". If not add "http://scholar.google.co.in/". If "javascript void(0)" is found set citation link to null
                papers.Add(new SG.Paper(title, authors, year, publication, publisher, no_of_citations, cited_by_url, index));
                index++;
            }

            return index;
        }


        public int getHIndex() { return h_index; }
        public int getIIndex() { return i_index; }
        public string getName() { return name; }
        public List<SG.Paper> getPapersOfCurrentPage()
        {
            getCitationData();
            //foreach (SG.Paper pap in papers) { Console.WriteLine(pap.Title); }
            return papers;
        }
    }
}
