using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SG
{
    public class ClassifyJournals
    {
        public List<Paper> papers;

        //constructor
        public ClassifyJournals()
        {
            papers = new List<Paper>();
        }

        //this method adds paper to the list of papers
        public void addPaper(Paper p)
        {
            papers.Add(p);
        }
    }
}
