using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace XmlToTable
{
    class Program
    {
        private static void Main(string[] args)
        {
            XmlSerializer mySerializer = new XmlSerializer(typeof (SoulTree));

            var directoriesEN = Directory.GetDirectories("../../Souls/EN/");

            foreach (var directory in directoriesEN)
            {
                var filePaths = Directory.GetFiles(directory);

                foreach (var file in filePaths)
                {
                    FileStream myFileStream = new FileStream(file, FileMode.Open);
                    SoulTree champion = (SoulTree) mySerializer.Deserialize(myFileStream);
                    Encoding e = new UTF8Encoding();
                    using (StreamWriter writer = new StreamWriter("EN.csv", true, e))
                    {
                        foreach (Ability t in champion.Abilities.Ability)
                        {
                            writer.WriteLine(t.Name);
                        }
                    }
                }
            }


            var directoriesFR = Directory.GetDirectories("../../Souls/FR/");
            foreach (var directory in directoriesFR)
            {
                var filePaths = Directory.GetFiles(directory);

                foreach (var file in filePaths)
                {
                    FileStream myFileStream = new FileStream(file, FileMode.Open);
                    SoulTree champion = (SoulTree)mySerializer.Deserialize(myFileStream);
                    Encoding e = new UTF8Encoding();
                    using (StreamWriter writer = new StreamWriter("FR.csv", true, e))
                    {
                        foreach (Ability t in champion.Abilities.Ability)
                        {
                            writer.WriteLine(t.Name);
                        }
                    }
                }
            }
            
            var directoriesDE = Directory.GetDirectories("../../Souls/DE/");
            foreach (var directory in directoriesDE)
            {
                var filePaths = Directory.GetFiles(directory);

                foreach (var file in filePaths)
                {
                    FileStream myFileStream = new FileStream(file, FileMode.Open);
                    SoulTree champion = (SoulTree)mySerializer.Deserialize(myFileStream);
                    Encoding e = new UTF8Encoding();
                    using (StreamWriter writer = new StreamWriter("DE.csv", true, e))
                    {
                        foreach (Ability t in champion.Abilities.Ability)
                        {
                            writer.WriteLine(t.Name);
                        }
                    }
                }
            }
        }
    }
}
