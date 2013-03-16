using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SG;

namespace PubCite
{
    public class CSXParser
    {

        public CSXParser() { }

        public AuthSuggestion getAuthSuggestions(string authName)
        {
            System.Console.WriteLine("Called");
            CSXAuthSug s = new CSXAuthSug(authName);

            System.Console.WriteLine(s.found + " " + s.sugList.Count);
            AuthSuggestion authSugObj = new AuthSuggestion(s.sugList,s.urlList,s.found);
            //for (int i = 0; i < s.sugList.Count; i++)
            //    System.Console.WriteLine(s.sugList[i] + "\n");
            return authSugObj;
        }
        public Author getAuthStatistics(string authUrl)
        {
            CSXAuth a = new CSXAuth(authUrl);
            Author authObj = new Author(a.authName,a.hIndex,a.i10Index);

            for (int i = 0; i < a.numPub; i++)
            {
                Paper p = new Paper(a.publiList[i].title, a.authName, a.publiList[i].year, a.publiList[i].journal, "", a.publiList[i].numCit,"",0);
                authObj.addPaper(p);
            }

            return authObj;
        }
        public ClassifyAuthors getAuthors(string authName)
        {
            CiteSeerJournal_FinalAuthorSearch newSearch = new CiteSeerJournal_FinalAuthorSearch(authName, 0);
            return newSearch.returnAuthor();
        }
        public ClassifyJournals getJournals(string journalName)
        {
            CiteSeerJournal_FinalAuthorSearch newSearch = new CiteSeerJournal_FinalAuthorSearch(journalName, 1);
            return newSearch.returnJournal();
        }
    }
}