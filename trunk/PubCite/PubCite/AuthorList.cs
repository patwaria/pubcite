using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace SG
{
    [Serializable()]
    class AuthorList:ISerializable
    {
        public List<Author> authors;
        public AuthorList()
        {
            authors = new List<Author>();
        }
        public AuthorList(SerializationInfo info, StreamingContext ctxt)
        {
            authors = (List<Author>)info.GetValue("ListOfAuthors",typeof(List<Author>));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("ListOfAuthors",authors);
        }
        public List<Author> Authors
        {
            get
            {
                return authors;
            }
        }
        public void Add(Author a)
        {
            authors.Add(a);
        }
        public void clear()
        {
            authors.Clear();
        }
        public void RemoveAt(int i)
        {
            authors.RemoveAt(i);
        }
    }
}
