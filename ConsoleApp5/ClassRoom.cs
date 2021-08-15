using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class ClassRoom
    {



        public ClassRoom(Pupil student_1,Pupil student_2 , Pupil student_3)
        {

            student_1.Write();
            Console.Write("\t\t\t");
            student_2.Write();
            Console.Write("\t\t\t");
            student_3.Write();

            Console.WriteLine();

            student_1.Read();
            Console.Write("\t\t\t");
            student_2.Read();
            Console.Write("\t\t\t");
            student_3.Read();

            Console.WriteLine();

            student_1.Study();
            Console.Write("\t\t\t");
            student_2.Study();
            Console.Write("\t\t\t");
            student_3.Study();


        }

    }
}
