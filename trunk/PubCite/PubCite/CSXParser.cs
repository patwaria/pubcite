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

                if ((n = doc.DocumentNode.SelectSingleNode("//*[@id=\"bibtex\"]/p")) != null)
                {
                    temp = n.InnerText;
                    temp = temp.Replace(",", ",\n").Replace("&nbsp;", " ");
                }
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
            for (int i = 0; i < c.citeList.Count; i++)
            {
                pEle = new Paper(c.citeList[i].title,c.citeList[i].url, c.citeList[i].authNames, c.citeList[i].abs,c.citeList[i].year, "", "", c.citeList[i].numCit, c.citeList[i].url, 0);
                p.Add(pEle);
            }
            return p;
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