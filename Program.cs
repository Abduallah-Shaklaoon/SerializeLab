using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Event test = new Event(1, "Calgary", "Tech Competition");
            FileReader.SerializeToFile(test);
            Event read = FileReader.DeserializeFromFile();
            Console.WriteLine(read.ToString());
            FileReader.ReadFromFile("Hackathon");
            Console.Read();
            

        }
    }
}
