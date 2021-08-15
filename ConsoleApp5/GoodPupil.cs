using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class GoodPupil : Pupil
    {
        public override void Read()
        {
            base.Read();
            Console.Write("C");
        }
        public override void Write()
        {
            base.Write();
            Console.Write("B");
        }
        public override void Study()
        {
            base.Study();
            Console.Write("A");
        }
    }
}
