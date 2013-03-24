using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace SG
{
    [Serializable()]
    public class Author:SearchEntity, ISerializable
    {
        private string affiliation="";
        private string homepageURL="";

        //constructor
        public Author(string name, int h) : base(name, h, -1) {
            this.affiliation = "";
            this.homepageURL = "";        
        }
        public Author(string Name, int h, int i)
            : base(Name, h, i)
        {
            this.affiliation = "";
            this.homepageURL = "";
        }
        public Author(string Name, string affiliation, string homePageURL, int h, int i)
            : base(Name, h, i)
        {
            this.affiliation = affiliation;
            this.homepageURL = homePageURL;
        }
        public Author(string name)
            : base(name, -1, -1)
        {
        }
        public Author(SerializationInfo info, StreamingContext ctxt)
            : base(info, ctxt)
        {
            affiliation = (string)info.GetValue("Affiliation",typeof(string));
            homepageURL = (string)info.GetValue("HomePageURL", typeof(string));
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            base.GetObjectData(info, ctxt);
            info.AddValue("Affiliation", affiliation);
            info.AddValue("HomePageURL", homepageURL);
        }

        public void setData(string affiliation, string homePageURL, int h, int i){
            this.affiliation = affiliation;
            this.homepageURL = homePageURL;
            setHIndex(h);
            setI10Index(i);
        }
        public string HomePageURL
        {
            get
            {
                return homepageURL;
            }
        }
        public string Affiliation
        {
            get
            {
                return affiliation;
            }
        }
    }
}
