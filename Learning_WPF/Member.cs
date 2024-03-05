using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_WPF
{
    internal class Member
    {
        //properties
        public string Name { get; set; }
        public string Type { get; set; }

        public DateTime DateJoined { get; set; }

        //ctor
        public Member() { }

        //toString mathod
        public override string ToString()
        {
            return $"{Name} - {Type} - {DateJoined.ToShortDateString()}";
        }
    }
}
