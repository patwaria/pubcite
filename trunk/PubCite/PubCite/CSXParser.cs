using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using SG;

namespace PubCite
{
    public class CSXParser
    {
        CiteSeerJournal_FinalAuthorSearch newAuthorSearch, newJournalSearch;

        public CSXParser() { }

        public string getBibTex(string url)
        {
            string res = "", temp = "";

            HtmlWeb web;
            HtmlDocument doc;
            HtmlNode n;

            if (url.Contains("viewdoc"))//e.g. http://citeseer.ist.psu.edu/viewdoc/summary?doi=10.1.1.31.3487
            {
                web = new HtmlWeb();
                doc = web.Load(url);

                if (doc != null)
                    Console.WriteLine("Document Loaded!");
                else
                    Console.WriteLine("Load Error!");
                try
                {
                    if ((n = doc.DocumentNode.SelectSingleNode("//*[@id=\"bibtex\"]/p")) != null)
                    {
                        temp = n.InnerText;
                        temp = temp.Replace(",", ",\n").Replace("&nbsp;", " ");
                    }
                }
                catch (Exception e) { }
                res = temp;
                return res;
            }
            else//e.g. http://citeseer.ist.psu.edu/showciting?cid=2131272
                return res;
        }

        public List<Paper> getCitations(string url)//url pointing to web page of a paper
        {
            CSXPubli c = new CSXPubli(url);
            List<Paper> p=new List<Paper>();
            Paper pEle;
            if (c.citeList != null)
            {
                for (int i = 0; i < c.citeList.Count; i++)
                {
                    pEle = new Paper(c.citeList[i].title, c.citeList[i].url, c.citeList[i].authNames, c.citeList[i].abs, c.citeList[i].year, "", "", c.citeList[i].numCit, c.citeList[i].url, 0);
                    p.Add(pEle);
                }
            }
            return p;
        }

        public bool getCitationsNext(string url,ref List<Paper> p)
        {
            HtmlWeb web; web = new HtmlWeb();
            HtmlDocument doc;
            HtmlNode n;

            if (url.Contains("viewdoc"))//e.g. http://citeseer.ist.psu.edu/viewdoc/summary?doi=10.1.1.31.3487
            {
                doc = web.Load(url);
                HtmlNode citUrl = doc.DocumentNode.SelectSingleNode("//*[@id=\"docCites\"]/td[2]/a");
                if (citUrl == null)
                    return false;
                url = "http://citeseer.ist.psu.edu" + citUrl.GetAttributeValue("href", "");
            }

            SettingsRecord sr = new SettingsRecord();
            Settings s = sr.ReadSettings();
            if (p.Count % 10 != 0 || p.Count >= s.CiteSeerMaxResults)
                return false;

            int pagen = p.Count;
            url = url + "&sort=cite&start=" + p.Count;

            doc = web.Load(url);

            if (doc != null)
                Console.WriteLine("Document Loaded!");
            else
            {
                Console.WriteLine("Load Error!");
                return false;
            }

            HtmlNodeCollection rows;
            Paper tempPaperObj;

            rows = doc.DocumentNode.SelectNodes("//*[@id=\"result_list\"]/div");
            if(rows==null)
            {
                Console.WriteLine("Load Error! Next page doesn't exist! Returned.");
                return false;
            }

            for (int i = 0; i < rows.Count; i++)
            {
                int numCit=0, year=0;
                string title="", authNames="", abs, pUrl="";
                if (rows[i].SelectSingleNode("div[3]/a[@title=\"number of citations\"]") != null)
                {
                    try
                    {
                        int comI = rows[i].SelectSingleNode("div[3]/a[@title=\"number of citations\"]").InnerText.Substring(9).IndexOf(' ');
                        if (rows[i].SelectSingleNode("div[3]/a[@title=\"number of citations\"]").InnerText.Substring(9).Remove(comI) != null)
                            numCit = Convert.ToInt32((rows[i].SelectSingleNode("div[3]/a[@title=\"number of citations\"]").InnerText.Substring(9).Remove(comI)));
                    }
                    catch (Exception e) { }
                }
                else
                    numCit = 0;

                try
                {
                    title = rows[i].SelectSingleNode("h3/a").InnerText.Trim();
                    authNames = rows[i].SelectSingleNode("div[1]/span[1]").InnerText.Substring(3).Trim();
                }
                catch (Exception e) { }

                String tempYear;
                if (rows[i].SelectSingleNode("div[1]/span[@class=\"pubyear\"]") != null)
                {
                    try
                    {
                        tempYear = rows[i].SelectSingleNode("div[1]/span[@class=\"pubyear\"]").InnerText;
                        if (tempYear != null)
                            year = Convert.ToInt32(tempYear.Substring(2));
                    }
                    catch (Exception e) { }
                }
                else year = 0;

                if (rows[i].SelectSingleNode("div[2]") != null)
                    abs = rows[i].SelectSingleNode("div[2]").InnerText;
                else
                    abs = "";

                try
                {
                    pUrl = "http://citeseer.ist.psu.edu" + rows[i].SelectSingleNode("h3/a").GetAttributeValue("href", "");
                }
                catch (Exception e) { }

                tempPaperObj = new Paper(title, pUrl, authNames, abs, year, "", "", numCit, pUrl, 0);

                //if (tempPaperObj.NumberOfCitations > 0)
                    p.Add(tempPaperObj);
            }                

            return true;
        }

        public AuthSuggestion getAuthSuggestions(string authName)
        {
            CSXAuthSug s = new CSXAuthSug(authName);

            AuthSuggestion authSugObj = new AuthSuggestion(s.sugList,s.urlList,s.found);            

            return authSugObj;
        }
        public Author getAuthStatistics(string authUrl)
        {
            CSXAuth a = new CSXAuth(authUrl);
            Author authObj = new Author(a.authName, a.affiliation, a.homePageURL, a.hIndex, a.i10Index);
            
            for (int i = 0; i < a.numPub; i++)
            {
                Paper p = new Paper(a.publiList[i].title, a.authName, a.publiList[i].year, a.publiList[i].journal, "", a.publiList[i].numCit,a.publiList[i].url,0);
                authObj.addPaper(p);
            }

            return authObj;
        }


        public Author getAuthors(string authName, string affiliation, string keywords)
        {
            newAuthorSearch = new CiteSeerJournal_FinalAuthorSearch(authName, 0, affiliation, keywords);
            return newAuthorSearch.returnAuthor();
        }

        public bool getAuthorsNext(string authName, string affiliation, string keywords, ref Author auth)
        {
            return newAuthorSearch.returnAuthorNext(ref auth);
        }

        public Journal getJournals(string journalName, string ISSN, string keywords)
        {
            newJournalSearch = new CiteSeerJournal_FinalAuthorSearch(journalName, 1, ISSN, keywords);
            return newJournalSearch.returnJournal();

        }

        public bool getJournalsNext(string journalName, string ISSN, string keywords, ref Journal journ)
        {
            return newJournalSearch.returnJournalNext(ref journ);
        }

    }
}