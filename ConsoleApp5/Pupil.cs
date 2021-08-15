using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Pupil
    {
        public string name { get; set; }
        public virtual void Read() { Console.Write("Read mark: "); }
        public virtual void Write() { Console.Write("Write mark: "); }
        public virtual void Study() { Console.Write("Study mark: "); }

        

    }
}
