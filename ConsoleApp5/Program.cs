using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            Pupil firstStudent = new Pupil()
            {
                name = "Лера"
            };
            Pupil secondStudent = new Pupil()
            {
                name = "Валера"
            };
            Pupil thirdStudent = new Pupil()
            {
                name = "Саша"
            };
            Pupil student_1 = new ExcelentPupil();
            Pupil student_2 = new BadPupil();
            Pupil student_3 = new GoodPupil();

            Console.WriteLine($"Do you want to view the grade of the entire class or an individual student: 1.All class 2.individual student");
        OneMore:
            if (!byte.TryParse(Console.ReadLine(), out byte counter_1))
            {
                Console.WriteLine("You enter string value . Try again");
                goto OneMore;
            }
            if (counter_1 <= 0 || counter_1 > 2)
            {
                Console.WriteLine("You enter string value . Try again");
                goto OneMore;
            }
            switch (counter_1)
            {
                case 1:
                    {
                        Console.Write($"{firstStudent.name} \t\t\t\t");
                        Console.Write($"{secondStudent.name} \t\t\t\t");
                        Console.Write($"{thirdStudent.name} ");
                        Console.WriteLine();
                        ClassRoom classRoom = new ClassRoom(student_1, student_2, student_3);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"Which student's grades do you want to see: 1.{ firstStudent.name} 2.{ secondStudent.name} 3.{ thirdStudent.name}");
                        OneMoretime:
                        if (!byte.TryParse(Console.ReadLine(), out byte counter))
                        {
                            Console.WriteLine("You enter string value . Try again");
                            goto OneMoretime;
                        }
                        if (counter <= 0 || counter > 3)
                        {
                            Console.WriteLine("You enter string value . Try again");
                            goto OneMoretime;
                        }

                        switch (counter)
                        {
                            case 1:
                                {
                                    Console.WriteLine(firstStudent.name);
                                    student_1.Read();
                                    Console.WriteLine();
                                    student_1.Write();
                                    Console.WriteLine();
                                    student_1.Study();
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine(secondStudent.name);
                                    student_2.Read();
                                    Console.WriteLine();
                                    student_2.Write();
                                    Console.WriteLine();
                                    student_2.Study();
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine(thirdStudent.name);
                                    student_3.Read();
                                    Console.WriteLine();
                                    student_3.Write();
                                    Console.WriteLine();
                                    student_3.Study();
                                    break;
                                }
                        }
                        break;
                    }
            }




            }
    }
}
