using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PubCite.com.microsoft.research.academic;
using SG;

namespace PubCite
{
    class MicrosoftScholarParser
    {
        private APIService client;
        private SettingsRecord sett;
        private Settings set;
        private int masMaxResults;

        public MicrosoftScholarParser()
        {
            client = new APIService();
            sett = new SettingsRecord();
            set = sett.ReadSettings();
            masMaxResults = set.MASMaxResults;
        }

        private string generateName(string fname, string midname, string endname)
        {
            string name;
            if (midname == "")
                name = fname + " " + endname;
            else
                name = fname + " " + midname + " " + endname;
            return name;
        }

        public SG.AuthSuggestion getAuthSuggestions(string authName)
        {
            Request request = new Request();
            request.AppID = "c49b4e59-08dd-4f27-a53b-53cc72f169af";
            Response response;

            SG.AuthSuggestion authSuggest;
            List<string> authNM = new List<string>();
            List<string> authID = new List<string>();
            string name;
            UInt32 id;

            request.ResultObjects = ObjectType.Author;
            request.AuthorQuery = authName;
            request.StartIdx = 1;
            request.EndIdx = 20;
            response = client.Search(request);
            if (response.Author == null)
            {
                authSuggest=new AuthSuggestion(authNM,authID,false);
                return authSuggest;
            }
            uint range = response.Author.TotalItem < 20 ? response.Author.TotalItem : 20;
            for (int i = 0; i < range; i++)
            {
                name = generateName(response.Author.Result[i].FirstName, response.Author.Result[i].MiddleName, response.Author.Result[i].LastName);
                id = response.Author.Result[i].ID;

                authNM.Add(name);
                authID.Add(Convert.ToString(id));

            }

            if (authNM.Count == 0)
                authSuggest = new SG.AuthSuggestion(authNM, authID, false);
            else
                authSuggest = new SG.AuthSuggestion(authNM, authID, true);

            return authSuggest;
        }

        public SG.Author getAuthStatistics(string authid, int noResults=20)
        {
            SG.Author auth;
            string name, affiliation, homePageURl;
            int Hindex;

            Request requestAuth = new Request();
            requestAuth.AppID = "c49b4e59-08dd-4f27-a53b-53cc72f169af";
            Response response1;

            requestAuth.ResultObjects = ObjectType.Author;
            requestAuth.AuthorID = Convert.ToUInt32(authid);
            requestAuth.StartIdx = 1;
            requestAuth.EndIdx = 1;
            response1 = client.Search(requestAuth);

         

            name = generateName(response1.Author.Result[0].FirstName, response1.Author.Result[0].MiddleName, response1.Author.Result[0].LastName);
            Hindex = Convert.ToInt32(response1.Author.Result[0].HIndex);

            try
            {
                affiliation = response1.Author.Result[0].Affiliation.Name;
                homePageURl = response1.Author.Result[0].HomepageURL;
            }
            catch (Exception e)
            {
                affiliation = "";
                homePageURl = "";
            }
            auth = new SG.Author(name,affiliation,homePageURl,-1,-1);


            Request requestPaper = new Request();
            requestPaper.AppID = "c49b4e59-08dd-4f27-a53b-53cc72f169af";

            requestPaper.ResultObjects = ObjectType.Publication;
            requestPaper.AuthorID = Convert.ToUInt32(authid);
            requestPaper.StartIdx = 1;
            requestPaper.EndIdx = 20;

            List<SG.Paper> papers = generatePaper(requestPaper, 20);

            for (int i = 0; i < papers.Count; i++)
            {
                auth.addPaper(papers[i]);
            }

            return auth;
        }

        public bool getAuthStatisticsNext(string authid, ref SG.Author auth)
        {
            Request requestPaper = new Request();
            requestPaper.AppID = "c49b4e59-08dd-4f27-a53b-53cc72f169af";
            int stIndex, EndIndex;

            stIndex = auth.getNumberOfPapers() + 1;
            EndIndex = auth.getNumberOfPapers() + 100;
 
            requestPaper.ResultObjects = ObjectType.Publication;
            requestPaper.AuthorID = Convert.ToUInt32(authid);
            requestPaper.StartIdx = Convert.ToUInt32(stIndex);
            requestPaper.EndIdx = Convert.ToUInt32(EndIndex);

            List<SG.Paper> papers = generatePaper(requestPaper, 100, auth.getNumberOfPapers());

            for (int i = 0; i < papers.Count; i++)
            {
                auth.addPaper(papers[i]);
            }

            if (papers.Count < 100)
                return false;
            else
                return true;
        }


        public SG.Journal getJournals(string journalName, string ISSN, string keywords, int noResults = 20)
        {
            Request requestJournal = new Request();
            requestJournal.AppID = "c49b4e59-08dd-4f27-a53b-53cc72f169af";
            //Response response;

            SG.Journal journ = new SG.Journal(journalName);

            requestJournal.ResultObjects = ObjectType.Publication;
            requestJournal.JournalQuery = journalName;
            requestJournal.FulltextQuery = keywords;
            requestJournal.StartIdx = 1;
            requestJournal.EndIdx = 20;

            List<SG.Paper> papers = generatePaper(requestJournal, 20);

            for (int i = 0; i < papers.Count; i++)
            {
                journ.addPaper(papers[i]);
            }

            return journ;

            
        }

        public bool getJournalsNext(string journalName, string ISSN, string keywords, ref SG.Journal journ)
        {
            Request requestJournal = new Request();
            requestJournal.AppID = "c49b4e59-08dd-4f27-a53b-53cc72f169af";
            //Response response;
            int stIndex, EndIndex;
            stIndex = journ.getNumberOfPapers() + 1;
            EndIndex = journ.getNumberOfPapers() + 100;

            requestJournal.ResultObjects = ObjectType.Publication;
            requestJournal.JournalQuery = journalName;
            requestJournal.FulltextQuery = keywords;
            requestJournal.StartIdx = Convert.ToUInt32(stIndex);
            requestJournal.EndIdx = Convert.ToUInt32(EndIndex);

            List<SG.Paper> papers = generatePaper(requestJournal, 100, journ.getNumberOfPapers());

            for (int i = 0; i < papers.Count; i++)
            {
                journ.addPaper(papers[i]);
            }

            if (papers.Count < 100)
                return false;
            else
                return true;
        }



        public SG.Author getAuthors(string authName, string affiliation, string keywords, int noResults=20)
        {
            SG.Author auth = new SG.Author(authName);

            Request requestPaper = new Request();
            requestPaper.AppID = "c49b4e59-08dd-4f27-a53b-53cc72f169af";
           // Response response2;

            requestPaper.ResultObjects = ObjectType.Publication;
            requestPaper.AuthorQuery = authName;
            requestPaper.FulltextQuery = keywords;
            requestPaper.StartIdx = 1;
            requestPaper.EndIdx = 20;

            List<SG.Paper> papers = generatePaper(requestPaper, 20);

            for (int i = 0; i < papers.Count; i++)
            {
                auth.addPaper(papers[i]);
            }

            return auth;


           
        }

        public bool getAuthorsNext(string authName, string affiliation, string keywords, ref SG.Author auth)
        {
            Request requestPaper = new Request();
            requestPaper.AppID = "c49b4e59-08dd-4f27-a53b-53cc72f169af";

            int stIndex, EndIndex;

            stIndex = auth.getNumberOfPapers() + 1;
            EndIndex = auth.getNumberOfPapers() + 100;

            requestPaper.ResultObjects = ObjectType.Publication;
            requestPaper.AuthorQuery = authName;
            requestPaper.FulltextQuery = keywords;
            requestPaper.StartIdx = Convert.ToUInt32(stIndex);
            requestPaper.EndIdx = Convert.ToUInt32(EndIndex);

            List<SG.Paper> papers = generatePaper(requestPaper, 100, auth.getNumberOfPapers());

            for (int i = 0; i < papers.Count; i++)
            {
                auth.addPaper(papers[i]);
            }

            if (papers.Count < 100)
                return false;
            else
                return true;
        }


        public List<Paper> getCitations(String id, int noResults=20)
        {
            //Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");

            List<Paper> cited = new List<Paper>();
            UInt32 paperID;
            try
            {
                paperID = Convert.ToUInt32(id);
            }
            catch (Exception e)
            {
                return cited;
            }

            Request requestCitedPaper = new Request();
            requestCitedPaper.AppID = "c49b4e59-08dd-4f27-a53b-53cc72f169af";
            Response response;

            requestCitedPaper.ResultObjects = ObjectType.Publication;
            requestCitedPaper.ReferenceType = ReferenceRelationship.Citation;
            requestCitedPaper.PublicationID = paperID;
            requestCitedPaper.StartIdx = 1;
            requestCitedPaper.EndIdx = Convert.ToUInt32(noResults);

            response = client.Search(requestCitedPaper);

            uint range = response.Publication.TotalItem;
            range = range > noResults ? Convert.ToUInt32(noResults) : range;


            for (int i = 0; i < range; i++)
            {
                Paper paper;
                String title, authors, publication, pap_abstract;
                int numOfCitations, year;

                authors = "";
                title = response.Publication.Result[i].Title;
                for (int j = 0; j < response.Publication.Result[i].Author.Length; j++)
                {
                    authors = authors + generateName(response.Publication.Result[i].Author[j].FirstName, response.Publication.Result[i].Author[j].MiddleName, response.Publication.Result[i].Author[j].LastName) + ", ";
                }
                numOfCitations = Convert.ToInt32(response.Publication.Result[i].CitationCount);
                year = Convert.ToInt32(response.Publication.Result[i].Year);

                publication = "";
                if (response.Publication.Result[i].Journal != null)
                    publication = response.Publication.Result[i].Journal.FullName;



                String url = "";
                if (response.Publication.Result[i].FullVersionURL.Length != 0)
                    url = response.Publication.Result[i].FullVersionURL[0];

                String id_ = Convert.ToString(response.Publication.Result[i].ID);

                pap_abstract = response.Publication.Result[i].Abstract;
                if (pap_abstract == null)
                    pap_abstract = "";

                paper = new Paper(title, url, authors,pap_abstract, year, publication, "", numOfCitations, id_, Convert.ToInt32(i + (range / 100) * 100));

                cited.Add(paper);

                /*Console.WriteLine(title);
                Console.WriteLine(authors);
                Console.WriteLine(year);
                Console.WriteLine(numOfCitations);
                Console.ReadLine();*/
            }


            return cited;
        }

        public bool getCitationsNext(String id, ref List<Paper> cited)
        {
            int no = cited.Count;
            int flag = 0;

            UInt32 paperID;
            try
            {
                paperID = Convert.ToUInt32(id);
            }
            catch (Exception e)
            {
                return false;
            }


            int stIndex, endIndex;
            Request requestCitedPaper = new Request();
            requestCitedPaper.AppID = "c49b4e59-08dd-4f27-a53b-53cc72f169af";
            Response response;

            stIndex = cited.Count + 1;
            endIndex = cited.Count + 100;

            requestCitedPaper.ResultObjects = ObjectType.Publication;
            requestCitedPaper.ReferenceType = ReferenceRelationship.Citation;
            requestCitedPaper.PublicationID = paperID;
            requestCitedPaper.StartIdx = Convert.ToUInt32(stIndex);
            requestCitedPaper.EndIdx = Convert.ToUInt32(endIndex);

            response = client.Search(requestCitedPaper);



            for (int i = 0; i < response.Publication.Result.Length; i++)
            {
                no++;
                if (no > masMaxResults)
                {
                    flag = 1;
                    break;
                }

                Paper paper;
                String title, authors, publication, pap_abstract;
                int numOfCitations, year;

                authors = "";
                title = response.Publication.Result[i].Title;
                for (int j = 0; j < response.Publication.Result[i].Author.Length; j++)
                {
                    authors = authors + generateName(response.Publication.Result[i].Author[j].FirstName, response.Publication.Result[i].Author[j].MiddleName, response.Publication.Result[i].Author[j].LastName) + ", ";
                }
                numOfCitations = Convert.ToInt32(response.Publication.Result[i].CitationCount);
                year = Convert.ToInt32(response.Publication.Result[i].Year);

                publication = "";
                if (response.Publication.Result[i].Journal != null)
                    publication = response.Publication.Result[i].Journal.FullName;



                String url = "";
                if (response.Publication.Result[i].FullVersionURL.Length != 0)
                    url = response.Publication.Result[i].FullVersionURL[0];

                String id_ = Convert.ToString(response.Publication.Result[i].ID);

                pap_abstract = response.Publication.Result[i].Abstract;
                if (pap_abstract == null)
                    pap_abstract = "";

                paper = new Paper(title, url, authors, pap_abstract, year, publication, "", numOfCitations, id_, 0);

                cited.Add(paper);
            }

            if (response.Publication.Result.Length < 100 || flag==1)
                return false;
            else
                return true;
        }


        
    //--------------------------------------------------------------------------------------------------------//
        public List<Paper> generatePaper(Request request, int numberofResult, int initialNO=0)
        {
            List<Paper> papers = new List<Paper>();
            Response response;
            try
            {
                response = client.Search(request);
            }
            catch (Exception e)
            {
                throw e;
            }

            if (response.Publication == null)
                return papers;

            for (int i = 0; i <response.Publication.Result.Length; i++)
            {
                initialNO++;
                if (initialNO > masMaxResults)
                    break;

                Paper paper;
                String title, authors, publication, pap_abstract, url, id_;
                int numOfCitations, year;

                authors = "";
                title = response.Publication.Result[i].Title;
                for (int j = 0; j < response.Publication.Result[i].Author.Length; j++)
                {
                    authors = authors + generateName(response.Publication.Result[i].Author[j].FirstName, response.Publication.Result[i].Author[j].MiddleName, response.Publication.Result[i].Author[j].LastName) + ", ";
                }

                numOfCitations = Convert.ToInt32(response.Publication.Result[i].CitationCount);
                year = Convert.ToInt32(response.Publication.Result[i].Year);

                publication = "";
                if (response.Publication.Result[i].Journal != null)
                    publication = response.Publication.Result[i].Journal.FullName;


                url = "";
                if (response.Publication.Result[i].FullVersionURL.Length != 0)
                    url = response.Publication.Result[i].FullVersionURL[0];

                id_ = Convert.ToString(response.Publication.Result[i].ID);

                pap_abstract = response.Publication.Result[i].Abstract;
                if (pap_abstract == null)
                    pap_abstract = "";

                paper = new Paper(title, url, authors, pap_abstract, year, publication, "", numOfCitations, id_, 0);

                papers.Add(paper);
            }
            

            return papers;
        }

      

    }

}
