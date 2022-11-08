using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi1
{
    class Program
    {
        static void menu()
        {
            Console.WriteLine("\t\t1.câu 4");
            Console.WriteLine("\t\t2.câu 5");
            Console.WriteLine("\t\t3.câu 6");
            Console.WriteLine("\t\t4.câu 7");
            Console.WriteLine("\t\t5.câu 8");
            Console.WriteLine("\t\t6.câu 9");
            Console.WriteLine("\t\t7.câu 10");
            Console.WriteLine("\t\t0.thoát");
            Console.Write("\t\tchọn lựa chọn của bạn: ");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int choice = -1;
            bool check = false;
            do
            {
                menu();
                check = int.TryParse(Console.ReadLine(),out choice);
                if (!check)
                    continue;
                switch (choice)
                {
                    case 1:
                        {
                            bai4.Bai4();
                        }break;
                    case 2:
                        {
                            bai5.Bai5();
                        }
                        break;
                    case 3:
                        {
                            bai6.Bai6();
                        }
                        break;
                    case 4:
                        {
                            bai7.Bai7();
                        }
                        break;
                    case 5:
                        {
                            bai8.Bai8();
                        }
                        break;
                    case 6:
                        {
                            bai9.Bai9();
                        }
                        break;
                    case 7:
                        {
                            bai10.Bai10();
                        }
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (choice!=0||check ==false);
        }
    }
}
