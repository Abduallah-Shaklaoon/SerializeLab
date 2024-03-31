using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeLab
{
    [Serializable]
    internal class Event
    {
        public int EventNum {  get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public Event(int eventNum, string location, string type)
        {
            EventNum = eventNum;
            Location = location;
            Type = type;
        }
        public override string ToString()
        {
            return $"{EventNum}\n{Location}\n{Type}";
        }
    }
}
