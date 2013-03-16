using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace SG
{
    [Serializable()]
    public class Journal:SearchEntity,ISerializable
    {

        //constructors
        public Journal(string name, int h, int i)
            : base(name, h, i)
        {
        }
        public Journal(string name)
            : base(name, -1, -1)
        {
        }
        public Journal(SerializationInfo info, StreamingContext ctxt) : base(info, ctxt) { }

        public override void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            base.GetObjectData(info,ctxt);
        }
        

        //method to get average number of cites per author
        public float getCitesPerAuthor()
        {
            int n = getTotalNumberofCitations();
            int a = 0;
            float ca = 0;
            List<string> autList = new List<string>();
            foreach (Paper p in papers)
            {
                string[] s = p.Authors.Split(new string[]{", "},StringSplitOptions.RemoveEmptyEntries);
                foreach (string au in s)
                {
                    if (!autList.Contains(au))
                    {
                        autList.Add(au);
                    }
                }
            }
            a = autList.Count;
            ca = (float)n / a;
            return ca;
        }

        //method to get average number of paper per author 
        public float getPaperPerAuthor()
        {
            int n = papers.Count;
            int a = 0;
            float ca = 0;
            List<string> autList = new List<string>();
            foreach (Paper p in papers)
            {
                string[] s = p.Authors.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string au in s)
                {
                    if (!autList.Contains(au))
                    {
                        autList.Add(au);
                    }
                }
            }
            a = autList.Count;
            if (a != 0)
            {
                ca = (float)n / a;
            }
            else
            {
                return 0;
            }
            return ca;
        }
    }
}
