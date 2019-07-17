using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsPage432 {
    [Serializable]
    class Excuse {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }

        public Excuse() {
            ExcusePath = "";
        }

        public Excuse(string excusePath) {
            OpenFile(excusePath);
        }

        public Excuse(Random random, string folder) {
            string[] fileNames = Directory.GetFiles(folder, "*.excuse");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }

        //private void OpenFile(string path) {
        //    this.ExcusePath = path;
        //    using (StreamReader reader = new StreamReader(path)) {
        //        Description = reader.ReadLine();
        //        Results = reader.ReadLine();
        //        LastUsed = Convert.ToDateTime(reader.ReadLine());
        //    }
        //}

        private void OpenFile(string path) {
            this.ExcusePath = path;
            BinaryFormatter bf = new BinaryFormatter();
            Excuse excuse;
            using (Stream input = File.OpenRead(path)) {
                excuse = (Excuse)bf.Deserialize(input);
            }
            Description = excuse.Description;
            Results = excuse.Results;
            LastUsed = excuse.LastUsed;
        }

        //public void Save(string fileName) {
        //    using (StreamWriter writer = new StreamWriter(fileName)) {
        //        writer.WriteLine(Description);
        //        writer.WriteLine(Results);
        //        writer.WriteLine(LastUsed);
        //    }
        //}

        public void Save(string fileName) {
            using (Stream output = File.Create(fileName)) {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, this);
            }
        }
    }
}
