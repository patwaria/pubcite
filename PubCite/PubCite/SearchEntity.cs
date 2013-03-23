using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace SG
{
    [Serializable()]
    public class SearchEntity:ISerializable
    {
        private string name;             //name of the search entity - author or journal
        protected List<Paper> papers;    //list of papers of the search entity
        private int h_ind;               //h index of the search entity
        private int i10_ind;             // i10 index of the search entity
        private int type;

        //constructors
        public  SearchEntity(string name, int h, int i)
        {
            this.name = name;
            h_ind = h;
            i10_ind = i;
            papers = new List<Paper>();
            type = 0;
        }
        public SearchEntity(string name, int h, int i, int type)
        {
            this.name = name;
            h_ind = h;
            i10_ind = i;
            papers = new List<Paper>();
            this.type = type;
        }
        public  SearchEntity(SerializationInfo info, StreamingContext ctxt){
            name = (string)info.GetValue("Name", typeof(string));
            papers = (List<Paper>)info.GetValue("PaperList", typeof(List<Paper>));
            h_ind = (int)info.GetValue("HInd", typeof(int));
            i10_ind = (int)info.GetValue("IInd", typeof(int));
        }
        public virtual void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Name", name);
            info.AddValue("PaperList", papers);
            info.AddValue("HInd", h_ind);
            info.AddValue("IInd", i10_ind);
        }

        //property - "Name" of the search entity
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        //function to add paper to the paper list
        public void addPaper(Paper p)
        {
            papers.Add(p);
        }

        //method to return list of papers on the basis of the year range
        public List<Paper> getPaperByYearRange(int begin, int end)
        {
            List<Paper> newList = new List<Paper>();
            foreach (Paper p in papers)
            {
                if (p.Year >= begin)
                {
                    if(end == -1 || p.Year <=end)
                        newList.Add(p);
                }
            }
            return newList;
        }

        public List<Paper> getPaperByYearRange(int begin)
        {
            return getPaperByYearRange(begin, -1);
        }
        public List<Paper> getPaperUptoYear(int end) {

            List<Paper> newList = new List<Paper>();
            foreach (Paper p in papers)
            {
                    if (p.Year <= end)
                        newList.Add(p);
            }
            return newList;
        }

        //method to get total number of citations of the search entity
        public int getTotalNumberofCitations()
        {
            int n = 0;
            foreach (Paper p in papers)
            {
                n += p.NumberOfCitations;
            }
            return n;
        }

        //method to get the number of papers of the search entity
        public int getNumberOfPapers()
        {
            return papers.Count;
        }

        //method to get h index of the search entity
        public int getHIndex()
        {
            if (h_ind == -1)
            {
                int h = (int)Math.Sqrt((double)getTotalNumberofCitations());
                int x;
                while (h >= 0)
                {
                    x = 0; ;
                    foreach (Paper p in papers)
                    {
                        if (p.NumberOfCitations > h)
                        {
                            x++;
                        }
                    }
                    if (x == h)
                    {
                        break;
                    }
                    else
                    {
                        h--;
                    }
                }

                h_ind = h;
            }
            if (h_ind == -1)
                return 0;
            return h_ind;
        }

        //method to get i10 index of the search index
        public int getI10Index()
        {
            if (i10_ind == -1)
            {
                int i = 0;
                foreach (Paper p in papers)
                {
                    if (p.NumberOfCitations >= 10)
                        i++;
                }
                i10_ind = i;
            }
            return i10_ind;
        }

        //method to get average number of citations per paper
        public float getCitesPerPaper()
        {
            if (getNumberOfPapers() != 0)
            {
                return (float)getTotalNumberofCitations() / getNumberOfPapers();
            }
            else return 0;
        }

        //method to get average number of cites per year
        public float getCitesPerYear()
        {

            int min=0, max=0, i = 0 ;
            while(min==0 && i<papers.Count)
            {
                min = papers[i].Year;
                max = papers[i].Year;
                i++;
            }
            foreach (Paper p in papers)
            {
                if (p.Year < min && p.Year!=0)
                    min = p.Year;
                if (p.Year > max && p.Year!=0)
                    max = p.Year;
            }
            if (min == 0 && max == 0)
            {
                return 0;
            }
            
            int diff = max - min + 1;
            return (float)getTotalNumberofCitations() / diff;
        }

        //property to access list of papers
        public List<Paper> getPapers()
        {
            return papers;
        }

        //functions to sort the paper list according to different parameters
        //value of order is true for sort in ascending order false otherwise
        public void sortPapersByCitations(bool order)
        {
            if (order)
            {
                papers.Sort((x, y) => x.NumberOfCitations.CompareTo(y.NumberOfCitations));
            }
            else
            {
                papers.Sort((y, x) => x.NumberOfCitations.CompareTo(y.NumberOfCitations));
            }
        }
        public void sortPapersByYear(bool order)
        {
            if (order)
            {
                papers.Sort((x, y) => x.Year.CompareTo(y.Year));
            }
            else
            {
                papers.Sort((y, x) => x.Year.CompareTo(y.Year));
            }
        }
        public void sortPapersByGSRank(bool order)
        {
            if (order)
            {
                papers.Sort((x, y) => x.GSRank.CompareTo(y.GSRank));
            }
            else
            {
                papers.Sort((y, x) => x.GSRank.CompareTo(x.GSRank));
            }
        }
        public void sortPapersByTitle(bool order)
        {
            if (order)
            {
                papers.Sort((x, y) => x.Title.CompareTo(y.Title));
            }
            else
            {
                papers.Sort((y, x) => x.Title.CompareTo(x.Title));
            }
        }
        public void sortPapersByPublication(bool order)
        {
            if (order)
            {
                papers.Sort((x, y) => x.Publication.CompareTo(y.Publication));
            }
            else
            {
                papers.Sort((y, x) => x.Publication.CompareTo(x.Publication));
            }
        }
        public void sortPapersByPublisher(bool order)
        {
            if (order)
            {
                papers.Sort((x, y) => x.Publisher.CompareTo(y.Publisher));
            }
            else
            {
                papers.Sort((y, x) => x.Publisher.CompareTo(x.Publisher));
            }
        }
    }
}
