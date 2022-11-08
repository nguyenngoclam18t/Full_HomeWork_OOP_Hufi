using System;using System.Collections.Generic;
using System.Text;

namespace Buoi1
{
    
    class bai10
    {
        private static void Menu()
        {
           
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1.xuất dãy số\n2.đảo dãy số\n3.tìm x trong dãy số\n4. xuất phần tử có 2 chữ số\n5.xuất các số nguyên tố");
            Console.WriteLine("6.xuất phần tử các chữ số đều là số chẵn\n7.xóa các phần tử lẻ và là bội của 3\n8.tăng lên 1 đơn vị cho số cực tiểu");
            Console.WriteLine("9.sort tăng dần\n10.sort giảm dần\n0.out");
        }
        public static void CreateArray(List<int> Array)
        {
            Random NewRandom = new Random();
            for (int i = 0; i < 10; i++)
            {
                Array.Add(NewRandom.Next(0, 100));
            }
        }
        public static void Print(List<int> Array)
        {
            foreach (var Item in Array)
            {
                Console.Write(Item + " ");
            }
        }
        public static void Cau3(List<int> Array)
        {
            int x;
            bool test;
            Console.Write("nhập x: ");
            test = int.TryParse(Console.ReadLine(), out x);
            if (!test)
            {
                Console.WriteLine("không có {0} trong array", x);
                return;
            }
            if (Array.IndexOf(x) != -1)
                Console.WriteLine("có {0} trong array", x);
            else
                Console.WriteLine("không có {0} trong array", x);
            Console.ReadKey();
        }
        public static bool Sngt(int x)
        {
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
        public static bool CheckEven(int x)
        {
            if (x < 10)
                return x % 2 == 0 ? true : false;
            return (x % 10) % 2 == 0 ? CheckEven(x /= 10) : false;
        }
        public static void Bai10()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choice = -1;
            bool check;
            List < int > Array= new List<int>();
            CreateArray(Array);
            do
            {
                Console.Clear();
                Menu();
                check = int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        {
                            Print(Array);
                            Console.ReadKey();
                        
                        }break;
                    case 2:
                        {
                            Array.Reverse();
                            Print(Array);
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        {
                            Cau3(Array);
                        }
                        break;
                    case 4:
                        {
                            bool flag = true;
                            foreach (var item in Array)
                            {
                                if (item >= 10 &&item<= 99)
                                {
                                    flag = false;
                                    Console.Write(item + " ");
                                }
                            }
                            if (flag)
                                Console.WriteLine("không có số như yêu cầu");
                            Console.ReadKey();
                        }
                        break;
                    case 5:
                        {
                            bool flag = true;
                            foreach (var item in Array)
                            {
                                if (Sngt(item))
                                {
                                    flag = false;
                                    Console.Write(item + " ");
                                }
                            }
                            if (flag)
                                Console.WriteLine("không có số như yêu cầu");
                            Console.ReadKey();
                        }
                        break;
                    case 6:
                        {
                            bool flag = true;
                            foreach (var item in Array)
                            {
                                if (CheckEven(item))
                                {
                                    flag = false;
                                    Console.Write(item + " ");
                                }
                            }
                            if (flag)
                                Console.WriteLine("không có số như yêu cầu");
                            Console.ReadKey();
                        }break;
                    case 7:
                        {
                            bool flag = true;
                            for (int i = 0; i < Array.Count; )
                            {
                                if (Array[i] % 2 != 0 && Array[i] % 3 == 0)
                                {
                                    flag = false;
                                    Array.Remove(Array[i]);
                                }else
                                    i++;


                            }
                            if (flag)
                                Console.WriteLine("không có số như yêu cầu");
                            else
                                Console.WriteLine("xoa thành công");
                            Console.ReadKey();
                        }
                        break;
                    case 8:
                        {
                            bool flag = true;
                            for (int i = 1; i < Array.Count-1; i++)
                            {
                                if (Array[i] <Array[i-1] && Array[i] < Array[i + 1])
                                {
                                    flag = false;
                                    Array[i] += 1;
                                }
                            }
                            if (flag)
                                Console.WriteLine("không có số như yêu cầu");
                            else
                                Console.WriteLine("cộng 1  thành công");
                            Console.ReadKey();
                        }
                        break;
                    case 9:
                        {
                            Array.Sort();
                           Console.WriteLine("sort tăng dần  thành công");
                            Console.ReadKey();
                        }
                        break;
                    case 10:
                        {
                            Array.Sort();
                            Array.Reverse();
                            Console.WriteLine("sort tăng dần  thành công");
                            Console.ReadKey();
                        }
                        break;
                    default:
                        break;
                }
            } while (choice!=0||check==false);
           
            
        }
    }
}
