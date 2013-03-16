using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SG
{
    public class Session
    {
        private List<SearchEntity> history;
        private int pos;

        //constructor
        public Session()
        {
            history = new List<SearchEntity>();
            pos = -1;
        }

        //Back function - returns the last searched search entity 
        public SearchEntity Back()
        {
            if (pos > 0)
            {
                pos--;
                Console.WriteLine("{0}", pos);
                return history[pos];
                
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        //Forward function - returns the search entity seached after current entity
        public SearchEntity Forward()
        {
            if (!isAtLast())
            {
                pos++;
                return history.ElementAtOrDefault(pos);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        //everytime a new search is made, new entity has to be added to the history list using this function.
        public void addEntity(Author a){
            for (int i = pos + 1; i < history.Count; i++)
            {
                history.RemoveAt(pos);
            }
            history.Add(a);
            pos++;
        }

        public void addEntity(Journal j)
        {
            for (int i = pos+1; i < history.Count; i++)
            {
                history.RemoveAt(pos);
            }
            history.Add(j);
            pos++;
        }

        //this function checks if a history list is empty - required for disabling back button
        public bool isEmpty()
        {
            return history.Count == 0;
        }

        //thus function checks if the current position is at the latest search - required to disabling forward button
        public bool isAtLast()
        {
            return pos == history.Count - 1;
        }
    }
}
