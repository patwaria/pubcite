using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;

namespace PubCite
{
    public static class cacheObject
    {
        static readonly ObjectCache cache = MemoryCache.Default;
        static List<string> LastAuthor = new List<string>();
        static List<string> LastJournal = new List<string>();
        static string LastAuthorkey = "abcd";
        static string LastJournalkey = "abcd";

        // get value of key. 
        public static Object Get(string key, bool isAuthor)
        {
            key = key.ToLower();
            key=key.Trim();
            key = isAuthor ? key : key + " ";
            try
            {
                return cache[key];
            }
            catch
            {
                return null;
            }
        }

        // add a key-value pair
        public static void Add(string key, Object objectToCache, bool isAuthor)
        {
            if (objectToCache == null) { Console.WriteLine("object is null"); return; }
            key = key.ToLower();
            key=key.Trim();
            key = isAuthor ? key : key + " ";
            cache.Add(key, objectToCache, DateTime.Now.AddHours(2));
            Console.WriteLine("Object added to cache");
            Console.WriteLine(objectToCache.ToString());
        }

        //remove key-value pair
        public static void Clear(string key, bool isAuthor)
        {
            key = key.ToLower();
            key=key.Trim();
            key = isAuthor ? key : key + " ";
            cache.Remove(key);
        }

        //clear the cache table
        public static void Clearcache(bool isAuthor)
        {
            List<string> keys = GetAll();
            foreach (string s in keys) Clear(s,isAuthor);
        }

        // exists
        public static bool Exists(string key, bool isAuthor)
        {
            key = key.ToLower();
            key=key.Trim();
            key = isAuthor ? key : key + " ";
            return cache.Get(key) != null;
        }

        // get all keys.
        private static List<string> GetAll()
        {
            return cache.Select(keyValuePair => keyValuePair.Key).ToList();
        }

        // get matching keys
        public static List<string> GetMatchingkeys(string key, bool isAuthor)
        {
            key = key.ToLower();
            key=key.Trim();

            List<string> keys = new List<string>();
            if ((isAuthor) && (key.StartsWith(LastAuthorkey))) keys = LastAuthor;
            else if (!isAuthor && key.StartsWith(LastJournalkey)) keys = LastJournal;
            else
            {
                keys = GetAll();
                if (isAuthor) LastAuthorkey = key;
                else LastJournalkey = key;
            }

            List<string> results = new List<string>();
            foreach (string s in keys) if (s.Contains(key))
                {
                    if (isAuthor)
                    {
                        string temp = s;
                        if (s.Trim().Equals(temp)) results.Add(s.Trim());
                    }
                    else
                    {
                        string temp = s;
                        if (!s.Trim().Equals(temp)) results.Add(temp);
                    }
                }
            if (isAuthor) { LastAuthor = results; LastAuthorkey = key; }
            else { LastJournal = results; LastJournalkey = key; }
            return results;
        }
    }
}
