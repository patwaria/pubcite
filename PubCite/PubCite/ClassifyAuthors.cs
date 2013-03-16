using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SG
{
    public class ClassifyAuthors
    {
        public List<Paper> papers;

        public ClassifyAuthors()
        {
            papers = new List<Paper>();
        }
        public void addPaper(Paper p)
        {
            papers.Add(p);
        }
        public List<Paper> Papers
        {
            get
            {
                return papers;
            }
        }
    }
}
