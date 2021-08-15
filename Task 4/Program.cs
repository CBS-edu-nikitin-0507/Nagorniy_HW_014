using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {

            const int key_pro = 1111;
            const int key_exp = 2222;
            byte AccessKey = 0;
            int count = 3;
            int key = 1111;
            int tryAgain = 0;
        OneMore:
            Console.WriteLine("Enter the access key");
            if (count >= 0)
            {
                if (!int.TryParse(Console.ReadLine(), out key))
                {
                    Console.WriteLine($"Not correct key. 1:Try again,  Any Buttom: choose free version. {count} attempts left");
                    if (int.TryParse(Console.ReadLine(), out tryAgain))
                    {
                        if (tryAgain == 1)
                        {
                            count--;
                            goto OneMore;

                        }
                    }
                }
                else
                {
                    if (key != key_pro && key != key_exp)
                    {
                        Console.WriteLine($"Not correct key. 1:Try again,  Any Buttom: choose free version. {count} attempts left");
                        if (int.TryParse(Console.ReadLine(), out tryAgain))
                            if (tryAgain == 1)
                            {
                                count--;
                                goto OneMore;

                            }
                    }
                    else
                    {
                        if (key == key_pro)
                        {
                            AccessKey = 1;
                        }
                        else
                        {
                            AccessKey = 2;
                        }
                    }
                }
                
            }
            if (count == -1)
            {
                Console.WriteLine("You have run out of attempts. The regular version will be used");
            }

            switch (AccessKey)
                {
                    case 1:
                        {
                        Console.WriteLine("Pro version:");
                        ProDocumentWorker pro = new ProDocumentWorker();
                            pro.OpenDocument();
                            pro.EditDocument();
                            pro.SaveDocumnet();
                            break;
                        }
                    case 2:
                        {
                        Console.WriteLine("Exp version:");
                            ExpertDocumentWorker exp = new ExpertDocumentWorker();
                            exp.OpenDocument();
                            exp.EditDocument();
                            exp.SaveDocumnet();
                            break;
                    }
                default:
                        Console.WriteLine("Default version:");
                        DocumentWorker @default = new DocumentWorker();
                        @default.OpenDocument();
                        @default.EditDocument();
                        @default.SaveDocumnet();
                        
                        break;
                }




            
        }
    }
}
