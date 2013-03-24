using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SG
{
    public class Favorite
    {
        private AuthorList ListofAuthor;
        private JournalList ListofJournal;

        public Favorite()
        {
            ListofAuthor = new AuthorList();
            ListofJournal = new JournalList();
        }

        //
        public void populateFavorites()
        {

            if (Directory.Exists(@"Favorites"))
            {
                if (File.Exists(@"Favorites\Author"))
                {// populate the list
                    FileStream fs = new FileStream(@"Favorites\Author", FileMode.Open,FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    object inf =  bf.Deserialize(fs);
                    ListofAuthor = (AuthorList)inf;
                    fs.Close();

                }

                if (File.Exists(@"Favorites\Journal"))
                {
                    //Populate the list
                    FileStream fs = new FileStream(@"Favorites\Journal", FileMode.Open,FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    object inf = bf.Deserialize(fs);
                    ListofJournal = (JournalList)inf;
                    fs.Close();
                }

            }
            else
            {
                Directory.CreateDirectory(@"Favorites");
            }
        }
        public List<Author> AuthorList
        {
            get
            {
                return ListofAuthor.Authors;
            }
        }

        public List<Journal> JournalList
        {
            get
            {
                return ListofJournal.Journals;
            }
        }
        
        public void clear()
        {
            ListofAuthor.clear();
            ListofJournal.clear();
            //WRITE TO FILE
            File.Delete(@"Favorites\Author");
            File.Delete(@"Favorites\Journal");
        }

        public void removeAuthor(int i)
        {    
            
            ListofAuthor.RemoveAt(i);
            Stream stream = File.Open(@"Favorites\Author", FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, ListofAuthor);
            stream.Close();
        }

        public void removeJournal(int i)
        {  
            ListofJournal.RemoveAt(i);
            Stream stream = File.Open(@"Favorites\Journal", FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, ListofJournal);
            stream.Close();
        }

        public void AddAuthor(Author a)
        {    // ADD id TO THE AUTHOR
            Console.WriteLine("URL:" + a.HomePageURL);
            ListofAuthor.Add(a);
            // add to file
            Stream stream = File.Open(@"Favorites\Author", FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, ListofAuthor);
            stream.Close();
        }

        public void AddJournal(Journal a)
        {  // add ID TO THE jOURNAL

            ListofJournal.Add(a);
            // add to file
            Stream stream = File.Open(@"Favorites\Journal", FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, ListofJournal);
            stream.Close();
        }

    }
}
