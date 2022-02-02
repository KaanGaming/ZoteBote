using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZoteBote
{
    public class ZoteboteConfig
    {
        public bool SaveOnEveryChange { get => _saveeverytime; set => _saveeverytime = value; }
        private bool _saveeverytime = true;

        private Dictionary<string, string> data;

        public ZoteboteConfig(bool SaveEverytime = true)
        {
            _saveeverytime = SaveEverytime;
            data = new();
            Load();
        }

        public void Set(string name, string value)
        {
            data[name] = value;
            if (SaveOnEveryChange)
                Save();
        }

        public string Get(string name)
        {
            if (!data.ContainsKey(name))
                return null;
            return data[name];
        }

        public string[] GetAll()
        {
            return data.Keys.ToArray();
        }

        public void Save()
        {
            if (!File.Exists("zoteboteconfig.dat"))
                File.Create("zoteboteconfig.dat");

            using (FileStream fs = File.Open("zoteboteconfig.dat", FileMode.Truncate))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    bw.Write(data.Count);
                    foreach (var d in data)
                    {
                        bw.Write(d.Key);
                        bw.Write(d.Value);
                    }
                }
            }
        }

        public void Load()
        {
            using (FileStream fs = File.Open(Environment.CurrentDirectory + "/zoteboteconfig.dat", FileMode.OpenOrCreate))
            {
                if (fs.Length < 1)
                    return;
                using (BinaryReader br = new BinaryReader(fs))
                {
                    int length = br.ReadInt32();
                    for (int i = 0; i < length; i++)
                    {
                        string key = br.ReadString();
                        string value = br.ReadString();
                        data.Add(key, value);
                    }
                }
            }
        }
    }
}
