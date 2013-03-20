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


        public MicrosoftScholarParser()
        {
            client = new APIService();
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
            request.EndIdx = 10;
            response = client.Search(request);

            uint range = response.Author.TotalItem < 10 ? response.Author.TotalItem : 10;
            for (int i = 0; i < range; i++)
            {
                name = generateName(response.Author.Result[i].FirstName, response.Author.Result[i].MiddleName, response.Author.Result[i].LastName);
                id = response.Author.Result[i].ID;

                authNM.Add(name);
                authID.Add(Convert.ToString(id));

                Console.WriteLine(name);
                Console.WriteLine(id);
                Console.ReadLine();
            }

            authSuggest = new SG.AuthSuggestion(authNM, authID, true);

            return authSuggest;
        }

        public SG.Author getAuthStatistics(string authid)
        {
            SG.Author auth;
            string name;
            int Hindex;

            Request requestAuth = new Request();
            requestAuth.AppID = "c49b4e59-08dd-4f27-a53b-53cc72f169af";
            Response response1;

            requestAuth.ResultObjects = ObjectType.Author;
            requestAuth.AuthorID = Convert.ToUInt32(authid);
            requestAuth.StartIdx = 1;
            requestAuth.EndIdx = 1;
            response1 = client.Search(requestAuth);

            Console.WriteLine(response1.Author.TotalItem);

            name = generateName(response1.Author.Result[0].FirstName, response1.Author.Result[0].MiddleName, response1.Author.Result[0].LastName);
            Hindex = Convert.ToInt32(response1.Author.Result[0].HIndex);
            auth = new SG.Author(name,Hindex,-1);


            Request requestPaper = new Request();
            requestPaper.AppID = "c49b4e59-08dd-4f27-a53b-53cc72f169af";
            Response response2;

            requestPaper.ResultObjects = ObjectType.Publication;
            requestPaper.AuthorID = Convert.ToUInt32(authid);
            requestPaper.StartIdx = 1;
            requestPaper.EndIdx = 100;
            response2 = client.Search(requestPaper);

            uint range = response2.Publication.TotalItem;
            range = range > 250 ? 250 : range;

            //Console.WriteLine(response2.Publication.TotalItem + " " + response2.Publication.TotalItem);
            for(int k = 0; k < range/100; k++)
            {
                for (int i = 0; i < 100; i++)
                {
                    Paper paper;
                    String title, authors, publication;
                    int numOfCitations, year;

                    authors = "";
                    title = response2.Publication.Result[i].Title;
                    for (int j = 0; j < response2.Publication.Result[i].Author.Length; j++)
                    {
                        authors = authors + generateName(response2.Publication.Result[i].Author[j].FirstName, response2.Publication.Result[i].Author[j].MiddleName, response2.Publication.Result[i].Author[j].LastName) + ", ";
                    }
                    numOfCitations = Convert.ToInt32(response2.Publication.Result[i].CitationCount);
                    year = Convert.ToInt32(response2.Publication.Result[i].Year);
                    //publication = response2.Publication.Result[i].Journal.;

                    paper = new Paper(title, authors, year, "", "", numOfCitations, "", i);

                    auth.addPaper(paper);

                    /*Console.WriteLine(title);
                    Console.WriteLine(authors);
                    Console.WriteLine(year);
                    Console.WriteLine(numOfCitations);
                    Console.ReadLine();*/
                }
                requestPaper.StartIdx = Convert.ToUInt32(101 + k * 100);
                requestPaper.EndIdx = Convert.ToUInt32(200 + k * 100);
                response2 = client.Search(requestPaper);
            }


            for (int i = 0; i < range%100; i++)
            {
                Paper paper;
                String title, authors, publication;
                int numOfCitations, year;

                authors = "";
                title = response2.Publication.Result[i].Title;
                for (int j = 0; j < response2.Publication.Result[i].Author.Length; j++)
                {
                    authors = authors + generateName(response2.Publication.Result[i].Author[j].FirstName, response2.Publication.Result[i].Author[j].MiddleName, response2.Publication.Result[i].Author[j].LastName) + ", ";
                }
                numOfCitations = Convert.ToInt32(response2.Publication.Result[i].CitationCount);
                year = Convert.ToInt32(response2.Publication.Result[i].Year);
                //publication = response2.Publication.Result[i].Journal.;

                paper = new Paper(title, authors, year, "", "", numOfCitations, "", i);

                auth.addPaper(paper);

                /*Console.WriteLine(title);
                Console.WriteLine(authors);
                Console.WriteLine(year);
                Console.WriteLine(numOfCitations);
                Console.ReadLine();*/
            }
            auth.getI10Index();
            return auth;
        }

        public ClassifyJournals getJournals(string journalName)
        {
            Request requestJournal = new Request();
            requestJournal.AppID = "c49b4e59-08dd-4f27-a53b-53cc72f169af";
            Response response;

            ClassifyJournals journ = new ClassifyJournals();

            requestJournal.ResultObjects = ObjectType.Publication;
            requestJournal.JournalQuery = journalName;
            requestJournal.StartIdx = 1;
            requestJournal.EndIdx = 100;
            response = client.Search(requestJournal);

            uint range = response.Publication.TotalItem;
            range = range > 250 ? 250 : range;
            //Console.WriteLine(range+" "+range);

            for (int k = 0; k < range / 100; k++)
            {
                for (int i = 0; i < 100; i++)
                {
                    Paper paper;
                    String title, authors, publication;
                    int numOfCitations, year;

                    authors = "";
                    title = response.Publication.Result[i].Title;
                    for (int j = 0; j < response.Publication.Result[i].Author.Length; j++)
                    {
                        authors = authors + generateName(response.Publication.Result[i].Author[j].FirstName, response.Publication.Result[i].Author[j].MiddleName, response.Publication.Result[i].Author[j].LastName) + ", ";
                    }
                    numOfCitations = Convert.ToInt32(response.Publication.Result[i].CitationCount);
                    year = Convert.ToInt32(response.Publication.Result[i].Year);
                    //publication = response.Publication.Result[i].Journal.ShortName;

                    paper = new Paper(title, authors, year, "", "", numOfCitations, "", i);

                    journ.addPaper(paper);


                   /* Console.WriteLine(title);
                    Console.WriteLine(authors);
                    Console.WriteLine(year);
                    Console.WriteLine(numOfCitations);
                    Console.ReadLine();*/
                }

                requestJournal.StartIdx = Convert.ToUInt32(101 + k * 100);
                requestJournal.EndIdx = Convert.ToUInt32(200 + k * 100);
                response = client.Search(requestJournal);
            }

            for (int i = 0; i < range%100; i++)
            {
                Paper paper;
                String title, authors, publication;
                int numOfCitations, year;

                authors = "";
                title = response.Publication.Result[i].Title;
                for (int j = 0; j < response.Publication.Result[i].Author.Length; j++)
                {
                    authors = authors + generateName(response.Publication.Result[i].Author[j].FirstName, response.Publication.Result[i].Author[j].MiddleName, response.Publication.Result[i].Author[j].LastName) + ", ";
                }
                numOfCitations = Convert.ToInt32(response.Publication.Result[i].CitationCount);
                year = Convert.ToInt32(response.Publication.Result[i].Year);
                //publication = response.Publication.Result[i].Journal.ShortName;

                paper = new Paper(title, authors, year, "", "", numOfCitations, "", i);

                journ.addPaper(paper);


                /* Console.WriteLine(title);
                 Console.WriteLine(authors);
                 Console.WriteLine(year);
                 Console.WriteLine(numOfCitations);
                 Console.ReadLine();*/
            }

            return journ;
        }

        /*static void Main(string[] args)
        {
            MicrosoftScholarParser p = new MicrosoftScholarParser();
            p.getAuthSuggestions("Anderson");
            p.getAuthStatistics("47469200");
            //p.getJournals("Computer Communication Review");  //sigcomm is not showing any results on microsoft scholar
        }*/
    }
}
