
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System;


namespace SG
{
    [Serializable()]
    public class Paper:ISerializable
    {
        private string title;
        private string authors;
        private int year;
        private string publication;
        private string publisher;
        private int num_cites;
        private string CiteURL;
        private int gsRank;
        private string titleURL;
        private string summary;
        private List<Paper> citations; 

        //constructor
        public Paper(string title, string authors, int year, string publication, string publisher, int numOfCitations, string CiteURL, int GSRank){
            this.title = title;
            this.authors = authors;
            this.year = year;
            this.publication = publication;
            this.publisher = publisher;
            this.num_cites = numOfCitations;
            this.titleURL = "Not Found";
            this.summary = "Not Found";
            //contains the URL which link to the citations of the paper
            this.CiteURL = CiteURL;

            //It contains the rank at which the paper appeared in the google scholar search
            this.gsRank = GSRank;
            //citations = new List<Paper>();
        }

        public Paper(string title,string titleURL, string authors, int year, string publication, string publisher, int numOfCitations, string CiteURL, int GSRank)
        {
            this.title = title;
            this.titleURL = titleURL;
            this.authors = authors;
            this.year = year;
            this.publication = publication;
            this.publisher = publisher;
            this.num_cites = numOfCitations;
            this.summary = "Not Found";
            //contains the URL which link to the citations of the paper
            this.CiteURL = CiteURL;

            //It contains the rank at which the paper appeared in the google scholar search
            this.gsRank = GSRank;
            //citations = new List<Paper>();
        }

        public Paper(string title, string titleURL, string authors,string summary, int year, string publication, string publisher, int numOfCitations, string CiteURL, int GSRank)
        {
            this.title = title;
            this.titleURL = titleURL;
            this.authors = authors;
            this.year = year;
            this.publication = publication;
            this.publisher = publisher;
            this.num_cites = numOfCitations;
            this.summary = summary;
            //contains the URL which link to the citations of the paper
            this.CiteURL = CiteURL;

            //It contains the rank at which the paper appeared in the google scholar search
            this.gsRank = GSRank;
            //citations = new List<Paper>();
        }

        public Paper(SerializationInfo info, StreamingContext ctxt)
        {
           title = (string)info.GetValue("title",typeof(string));
           authors = (string)info.GetValue("authors",typeof(string));
           year = (int)info.GetValue("year",typeof(int));
           publication = (string)info.GetValue("publication", typeof(string));
           publisher = (string)info.GetValue("publisher", typeof(string));
           num_cites = (int)info.GetValue("Num_Cites", typeof(int));
           gsRank = (int)info.GetValue("gsRank", typeof(int));
           //citations = (List<Paper>)info.GetValue("ListOfCitations", typeof(string));

        }
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("title",title);
            info.AddValue("authors", authors);
            info.AddValue("year", year);
            info.AddValue("publication", publication);
            info.AddValue("publisher", publisher);
            info.AddValue("Num_Cites", num_cites);
            info.AddValue("gsRank", gsRank);
            //info.AddValue("ListOfCitations", citations);
        }
        //property - "Title" of the paper - read only
        public string Title
        {
            get
            {
                return title;
            }
        }
        //property - "Title" of the paper - read only
        public string TitleURL
        {
            get
            {
                return titleURL;
            }
        }

        //property - "Authors" of the paper - read only
        public string Authors
        {
            get 
            {
                return authors;
            }
        }

        public string Summary
        {
            get
            {
                return summary;
            }
        }

        //property - "Year" of publication - read only
        public int Year
        {
            get
            {
                return year;
            }
        }

        //property - "Publication" or Journal in which paper was published - read only
        public string Publication
        {
            get
            {
                return publication;
            }
        }

        //property - "Publisher" of the paper - read only
        public string Publisher
        {
            get
            {
                return publisher;
            }
        }

        //property - "Number of citations" of the paper - read only
        public int NumberOfCitations
        {
            get
            {
                return num_cites;
            }
        }

        //property - URL of the citation link - read only
        public string CitedByURL
        {
            get
            {
                return CiteURL;
            }
        }
        public int GSRank
        {
            get
            {
                return gsRank;
            }
        }

        //property - List of citations in the Paper - read only
        public List<Paper> Citations
        {
            get
            {
                return citations;
            }
        }

        //add a paper p to the list of citations of the Paper - read only
        public void addCitation(Paper p)
        {
            citations.Add(p);
        }
    }
}
