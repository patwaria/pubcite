using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PubCite
{
    public class SettingsRecord
    {
        private Settings set;
        public SettingsRecord()
        {
            set = new Settings();   
        }
        public Settings ReadSettings()
        {
            if (File.Exists(@"Settings"))
            {// populate the list
                FileStream fs = new FileStream(@"Settings", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                object inf = bf.Deserialize(fs);
                set = (Settings)inf;
                fs.Close();
            }
            return set;
        }
        public void SaveSettings(Settings s)
        {
            Stream stream = File.Open(@"Settings", FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, set);
            stream.Close();
        } 
    }
}
