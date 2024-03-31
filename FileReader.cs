using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializeLab
{
    internal class FileReader
    {
        public static void SerializeToFile(Event evnt)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            // Serialize the Person object to a stream
            using (FileStream fs = new FileStream("events.txt", FileMode.Create))
            {
                formatter.Serialize(fs, evnt);
            }
        }
        public static Event DeserializeFromFile()
        {
            Event readEvent;
            BinaryFormatter formatter = new BinaryFormatter();
            using(FileStream fs = new FileStream("events.txt", FileMode.OpenOrCreate))
            {
                readEvent = (Event)formatter.Deserialize(fs);
            }
            return readEvent;
        }
        public static void ReadFromFile(string word)
        {
            string fileName = "readfromfile.txt";
            using(StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(word);
            }
            using(StreamReader sr = new StreamReader(fileName))
            {
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                Console.WriteLine("The first character is "+(char)sr.Read());
                sr.ReadToEnd();
                sr.BaseStream.Seek((int)word.Length/2, SeekOrigin.Begin);
                Console.WriteLine("The middle character is " + (char)sr.Read());
                sr.ReadToEnd();
                sr.BaseStream.Seek((int)word.Length -1, SeekOrigin.Begin);
                Console.WriteLine("The last character is " + (char)sr.Read());

            }
        }
    }
}
