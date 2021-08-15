using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class ExcelentPupil : Pupil
    {
        public override void Read()
        {
            base.Read();
            Console.Write("A");
        }
        public override void Write()
        {
            base.Write();
            Console.Write("A");
        }
        public override void Study()
        {
            base.Study();
            Console.Write("A");
        }
    }
}
