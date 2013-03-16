﻿//Parse CiteSeerX Author Page
//Add exception handlers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using SG;

//to use the class CSXAuth, copy the code and call the constructor with the authURL as an argument.
//CSXAuth p = new CSXAuth(authURL);

//Then, all the data is stored in p's data members. Access them as p.<member name>.

namespace PubCite
{

    //ClassifyJournal and ClassifyAuthor functions start

    public class CiteSeerJournal_FinalAuthorSearch
    {
        private string initialURL;
        private string nextURL;
        private HtmlWeb CitePage;
        private HtmlDocument CiteDoc;
        private int noResult;
        private int PageNo;
        private string searchElement;
        private int searchType;
        private ClassifyAuthors auth1;
        private ClassifyJournals journ1;

        public CiteSeerJournal_FinalAuthorSearch(string searchEle, int searchTy)  //searchType 0 for authorSearch, 1 for journalSearch
        {

            searchElement = searchEle;
            searchType = searchTy;

            auth1 = new ClassifyAuthors();
            journ1 = new ClassifyJournals();

            char[] searchElementTemp = searchElement.ToCharArray();
            for (int i = 0; i < searchElement.Length; i++)
            {
                if (searchElementTemp[i] == ' ')
                    searchElementTemp[i] = '+';
            }

            searchElement = new string(searchElementTemp);
            if (searchType == 0)
                initialURL = "http://citeseerx.ist.psu.edu/search?q=author%3A%28" + searchElement + "%29&submit=Search&ic=1&sort=cite&t=doc";
            else if (searchType == 1)
                initialURL = "http://citeseerx.ist.psu.edu/search?q=venue%3A" + searchElement + "&sort=cite&ic=1&t=doc";
            else
                initialURL = "";

            CitePage = new HtmlWeb();
            CiteDoc = CitePage.Load(initialURL);
            PageNo = 1;

            Console.WriteLine("Document opened");

            getNoResult();
        }

        private void getNoResult()
        {
            HtmlNode noResultNode = CiteDoc.DocumentNode.SelectSingleNode("//*[@id=\"result_info\"]/strong[2]");
            noResult = Convert.ToInt32(noResultNode.InnerText);
            if (noResult > 100)
                noResult = 100;
        }

        private int LoadNextPage()
        {
            if (PageNo > noResult / 10)
                return 0;
            if (searchType == 0)
            {
                nextURL = "http://citeseerx.ist.psu.edu/search?q=author%3A%28" + searchElement + "%29&ic=1&t=doc&sort=cite&start=" + PageNo + "0";
                PageNo++;

                CiteDoc = CitePage.Load(nextURL);
                return 1;
            }
            if (searchType == 1)
            {
                nextURL = "http://citeseerx.ist.psu.edu/search?q=venue%3A" + searchElement + "&ic=1&t=doc&sort=cite&start=" + PageNo + "0";
            }
            return 0;
        }

        private void extractDataAllPage()
        {
            HtmlNode mainTable = CiteDoc.DocumentNode.SelectSingleNode("//*[@id=\"result_list\"]");
            HtmlNode entryNoNode, paperNode, authorNode, journalNode, yearNode, citationNode;
            string paperName, authorName, journalName, publishYear, noCitations, citationLink;
            int citno;
            do
            {
                for (int i = 1; i <= 10; i++)
                {
                    entryNoNode = mainTable.SelectSingleNode("div[" + i + "]");
                    if (entryNoNode == null)
                        break;

                    paperNode = entryNoNode.SelectSingleNode("h3/span");
                    paperName = paperNode.InnerText;
                    paperName = paperName.Substring(37);
                    //Now remove unwanted preceding character and spaces from paperName

                    authorNode = entryNoNode.SelectSingleNode("div[1]/span[1]");
                    authorName = authorNode.InnerText;
                    authorName = authorName.Substring(22);
                    //Now remove unwanted preceding character and spaces from authorName

                    if (entryNoNode.SelectSingleNode("div[1]/span[3]") == null)
                    {
                        journalName = "";
                        yearNode = entryNoNode.SelectSingleNode("div[1]/span[2]");
                        publishYear = yearNode.InnerText;
                        publishYear = publishYear.Substring(2);
                    }
                    else
                    {
                        journalNode = entryNoNode.SelectSingleNode("div[1]/span[2]");
                        journalName = journalNode.InnerText;
                        journalName = journalName.Substring(2);

                        yearNode = entryNoNode.SelectSingleNode("div[1]/span[3]");
                        publishYear = yearNode.InnerText;
                        publishYear = publishYear.Substring(2);
                    }
                    //Process publishYear and journalNode to get important data

                    citationNode = entryNoNode.SelectSingleNode("div[3]/a");
                    noCitations = citationNode.InnerText;                            //remove unnecessary details from the number of citations
                    noCitations = noCitations.Substring(9);
                    citationLink = citationNode.Attributes["href"].Value;


                    citno = 0;
                    for (int j = 0; noCitations[j] != ' '; j++)
                    {
                        citno = citno * 10 + Convert.ToInt32(noCitations[j]) - 48;
                    }

                    //Now the processed strings are to be entered on the type of author
                    Paper paper1 = new Paper(paperName, authorName, Convert.ToInt32(publishYear), journalName, "", citno, citationLink, (PageNo - 1) * 10 + i);
                    if (searchType == 0)
                        auth1.addPaper(paper1);
                    else
                        journ1.addPaper(paper1);
                    //Return the reference of the next empty 
                }
            } while (LoadNextPage() == 1);
        }


        public ClassifyAuthors returnAuthor()                                  //for getting the ClassifyAuthors call this function
        {
            extractDataAllPage();
            return auth1;
        }

        public ClassifyJournals returnJournal()                                      // //for getting the ClassifyJournals call this function
        {
            extractDataAllPage();
            return journ1;
        }
    }

    //ClassifyJournal and ClassifyAuthor functions end

    public class CSXAuthSug
    {
        public List<string> sugList, urlList;
        public bool found;

        HtmlWeb web;
        HtmlDocument doc;

        public CSXAuthSug(String authQ)
        {
            String searchElement = authQ;
            char[] searchElementTemp = searchElement.ToCharArray();
            for (int i = 0; i < searchElement.Length; i++)
            {
                if (searchElementTemp[i] == ' ')
                    searchElementTemp[i] = '+';
            }
            searchElement = new string(searchElementTemp);

            String searchURL="http://citeseer.ist.psu.edu/search?q=" +searchElement+ "&submit=Search&uauth=1&sort=ndocs&t=auth";

            web = new HtmlWeb();
            doc = web.Load(searchURL);

            if (doc != null)
                Console.WriteLine("Document Loaded!");
            else
                Console.WriteLine("Load Error!");

            extractData();
        }

        public void extractData()
        {
            HtmlNodeCollection rows = doc.DocumentNode.SelectNodes("//*[@id=\"result_list\"]/div");//*[@id="result_list"]/div[1]

            sugList = new List<string>(); urlList = new List<string>();

            if (rows == null)
            {
                found = false;
                return;
            }

            found = true;

            Console.WriteLine(rows.Count);

            for (int i = 1; i < rows.Count; i++)
            {
                Console.WriteLine("*** *** ***");

                /**/sugList.Add(rows[i].SelectSingleNode("h3").InnerText);
                Console.WriteLine(rows[i].SelectSingleNode("h3").InnerText);

                /**/urlList.Add("http://citeseer.ist.psu.edu" + rows[i].SelectSingleNode("h3/a").GetAttributeValue("href", ""));                
                Console.WriteLine("http://citeseer.ist.psu.edu" + rows[i].SelectSingleNode("h3/a").GetAttributeValue("href", ""));

            }

        }
    }

    public class publiData
    {
        public int numCit;
        public String title;
        public String url;
        public String journal;
        public int year;
    }

    public class CSXAuth
    {
        public String authName, homePageURL;
        public String affiliation;//e.g. university or organisation
        public int numPub;//no. of publications
        public int hIndex, i10Index;
        public publiData[] publiList;//array containing info about all the publications

        HtmlWeb web;
        HtmlDocument doc;
        
        public CSXAuth(String authURL)
        {
            web = new HtmlWeb();
            doc = web.Load(authURL);

            if(doc!=null)
                Console.WriteLine("Document Loaded!");
            else
                Console.WriteLine("Load Error!");

            extractData();
        }

        String[] Split(String s)//Gets a string containing publication information and divides it into title, journal and year strings
        {
            String[] list=new String[3];
            int st=0,i,j;

            for (i = 0,j = 0; i < s.Length; i++)
            {
                if (s[i] == '\n')
                {
                    while (Char.IsWhiteSpace(s[i])) { i++; if (i >= s.Length)break; }                   
                    list[j++] = s.Substring(st, i - st).Trim();
                    st = i + 1;                    
                }
            }

            return list;
        }

        public void extractData()//Extracts all the data from author page and stores them in the respective variables
        {
            HtmlNode name = doc.DocumentNode.SelectSingleNode("//*[@id=\"viewHeader\"]/h2");
            Console.Write("\nName: ");
            String namet = name.InnerText;            
            authName = namet.Remove(namet.Length - 5);
            Console.WriteLine(authName);

            HtmlNode hpurl = doc.DocumentNode.SelectSingleNode("//*[@id=\"authInfo\"]/tr[1]/td[2]/a");
            Console.Write("Home Page URL: ");
            homePageURL = hpurl.InnerText;
            Console.WriteLine(homePageURL);

            HtmlNode affl = doc.DocumentNode.SelectSingleNode("//*[@id=\"authInfo\"]/tr[2]/td[2]");
            Console.Write("Affiliation: ");
            affiliation = affl.InnerText;
            Console.WriteLine(affiliation);

            HtmlNode npub = doc.DocumentNode.SelectSingleNode("//*[@id=\"authInfo\"]/tr[3]/td[2]");
            Console.Write("No. of publications: ");
            numPub = Convert.ToInt32(npub.InnerText);
            Console.WriteLine(numPub);

            HtmlNode hindex = doc.DocumentNode.SelectSingleNode("//*[@id=\"authInfo\"]/tr[4]/td[2]");
            Console.Write("H-index: ");
            hIndex = Convert.ToInt32(npub.InnerText);
            Console.WriteLine(hIndex);

            HtmlNodeCollection rows = doc.DocumentNode.SelectNodes("//*[@id=\"viewContent-inner\"]/table/tr");
            String[] list;
            int i10 = 0 ;

            List<publiData> tempPubliList = new List<publiData>();
            publiData tempPubliObj=new publiData();

            for (int i = 1; i < rows.Count; i++)
            {
                Console.WriteLine("*** *** ***");
                Console.WriteLine(rows[i].XPath);

                if (rows[i].SelectSingleNode("td[1]").InnerText.ToString().Trim().Length > 0)
                    tempPubliObj.numCit = Convert.ToInt32(rows[i].SelectSingleNode("td[1]").InnerText);
                else
                    tempPubliObj.numCit = 0;
                Console.WriteLine("No. of citations: "+tempPubliObj.numCit);

                if (rows[i].SelectSingleNode("td[1]").InnerText.ToString().Trim().Length > 0)
                    if (Convert.ToInt32(rows[i].SelectSingleNode("td[1]").InnerText) >= 10) i10++;
                
                list = Split(rows[i].SelectSingleNode("td[2]").InnerText);
                tempPubliObj.title = list[0];
                tempPubliObj.journal = list[1];
                tempPubliObj.year = Convert.ToInt32(list[2]);                
                tempPubliObj.url = "http://citeseer.ist.psu.edu"+rows[i].SelectSingleNode("td[2]/a").GetAttributeValue("href","");
                Console.WriteLine(tempPubliObj.title + "|" + tempPubliObj.journal+ "|" + tempPubliObj.year + "|" + tempPubliObj.url);
                tempPubliList.Add(tempPubliObj);
            }
            publiList = tempPubliList.ToArray();

            i10Index = i10;
            Console.WriteLine(i10Index);
        }

        
        /*public static void Main(string[] args)
        {
            String authURL = "http://citeseer.ist.psu.edu/viewauth/summary?aid=7229&list=full";
            CSXAuth p = new CSXAuth(authURL);
            //Console.ReadLine();

            CSXAuthSug q = new CSXAuthSug("James Anderson");
            //Console.ReadLine();
        }*/

    }

}
