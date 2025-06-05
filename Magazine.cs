using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samost2
{
    internal class Magazine
    {
        public string Name { get; set; }
        public Frequency Frequency { get; set; }
        public DateTime DateTime { get; set; }
        public int Circulation { get; set; }
        public Magazine() { }
        public Magazine(string name, Frequency frequency, DateTime dateTime, int circulation)
        {
            Name = name;
            Frequency = frequency;
            DateTime = dateTime;
            Circulation = circulation;
        }
        
    }
}
