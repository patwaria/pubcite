using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;

namespace PubCite
{
    public static class cacheObject
    {
        static readonly ObjectCache cache = MemoryCache.Default;
        
        // get value of key. 
        public static Object Get(string key,bool isAuthor)
        {
            key = key.ToLower();
            key.Trim();
            key = isAuthor ? key : key + " ";
            try
            {
                return cache[key] ;
            }
            catch
            {
                return null;
            }
        }

        // add a key-value pair
        public static void Add(string key,Object objectToCache,bool isAuthor)
        {
            key = key.ToLower();
            key.Trim();
            key = isAuthor ? key : key + " ";
            cache.Add(key, objectToCache, DateTime.Now.AddDays(2));
        }
        
        //remove key-value pair
        public static void Clear(string key,bool isAuthor)
        {
            key = key.ToLower();
            key.Trim();
            key = isAuthor ? key : key + " ";
            cache.Remove(key);
        }

        // exists
        public static bool Exists(string key,bool isAuthor)
        {
            key = key.ToLower();
            key.Trim();
            key = isAuthor ? key : key + " ";
            if (isAuthor) return cache.Get(key) != null;
            else return cache.Get(key) != null;
        }

        // get all keys.
        private static List<string> GetAll()
        {
            return cache.Select(keyValuePair => keyValuePair.Key).ToList();
        }

        // get matching keys for first character
        public static List<string> GetMatchingkeys(string key, bool isAuthor) {
            key=key.ToLower();
            key.Trim();
            //key = isAuthor ? key : key + " ";
            List<string> keys = cacheObject.GetAll();
            List<string> results = new List<string>();
            foreach (string s in keys)    if (s.StartsWith(key)) results.Add(s.Trim());
            
            return results;
        }
    }
}
