using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class BadPupil : Pupil
    {
        public override void Read()
        {
            base.Read();
            Console.Write("F");
        }
        public override void Write()
        {
            base.Write();
            Console.Write("F");
        }
        public override void Study()
        {
            base.Study();
            Console.Write("F");
        }
    }
}
