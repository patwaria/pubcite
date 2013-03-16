using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace SG
{
    [Serializable()]
    class JournalList : ISerializable
    {
        public List<Journal> journals;
        public JournalList()
        {
            journals = new List<Journal>();
        }
        public JournalList(SerializationInfo info, StreamingContext ctxt)
        {
            journals = (List<Journal>)info.GetValue("ListOfJournals", typeof(List<Journal>));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("ListOfJournals", journals);
        }
        public List<Journal> Journals
        {
            get
            {
                return journals;
            }
        }
        public void Add(Journal j)
        {
            journals.Add(j);
        }
        public void clear()
        {
            journals.Clear();
        }
        public void RemoveAt(int i)
        {
            journals.RemoveAt(i);
        }
    }
}

