using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace PubCite
{
    [Serializable()]
    public class Settings : ISerializable
    {
        private int daysCache;
        private int csxMaxResults;
        private int gsMaxResults;
        private int masMaxResults;

        //conatructors
        public Settings(int daysCache, int CSXMaxResults, int GSMaxResults, int MASMaxResults)
        {
            this.daysCache = daysCache;
            csxMaxResults = CSXMaxResults;
            gsMaxResults = GSMaxResults;
            masMaxResults = MASMaxResults;
        }
        public Settings(int DaysCache)
            : this(DaysCache, 100, 100, 100)
        {
        }
        public Settings()
            : this(7, 100, 100, 100)
        {

        }
        public Settings(SerializationInfo info, StreamingContext ctxt)
        {
            daysCache = (int)info.GetValue("daysCache", typeof(int));
            csxMaxResults = (int)info.GetValue("csxMR", typeof(int));
            gsMaxResults = (int)info.GetValue("gsMR", typeof(int));
            masMaxResults = (int)info.GetValue("masMR", typeof(int));

        }
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("daysCache", daysCache);
            info.AddValue("csxMR",csxMaxResults);
            info.AddValue("gsMR",gsMaxResults);
            info.AddValue("masMR",masMaxResults);
        }

        //properties
        public int DaysCache
        {
            get
            {
                return daysCache;
            }
            set
            {
                daysCache = value;
            }
        }
        public int CiteSeerMaxResults
        {
            get
            {
                return csxMaxResults;
            }
            set
            {
                csxMaxResults = value;
            }
        }
        public int GSMaxResults
        {
            get
            {
                return gsMaxResults;
            }
            set
            {
                gsMaxResults = value;
            }
        }
        public int MASMaxResults
        {
            get
            {
                return masMaxResults;
            }
            set
            {
                masMaxResults = value;
            }
        }
    }
}
