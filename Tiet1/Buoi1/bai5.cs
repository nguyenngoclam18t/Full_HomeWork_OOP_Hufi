using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi1
{
    class bai5
    {
        static void Input_ab(out int a, out int b, out int c)
        {
            bool check;
            do
            {
                Console.Write("vui lòng nhap a: ");
                check = int.TryParse(Console.ReadLine(), out a);
            } while (check == false);
            do
            {
                Console.Write("vui lòng nhap b: ");
                check = int.TryParse(Console.ReadLine(), out b);
            } while (check == false);
            do
            {
                Console.Write("vui lòng nhap c: ");
                check = int.TryParse(Console.ReadLine(), out c);
            } while (check == false);
        }
        static void Caculator(int a, int b, int c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("PT vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine("PT vo nghiem");
                    }
                }
                else
                {
                    float answer = (float)-c / a;
                    Console.WriteLine($"co nghiem la: {answer}");
                }
            }
            else
            {
                int delta = b * b - 4 * a * c;
                float x1, x2;
                if (delta > 0)
                {
                    x1 = (float)(-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (float)(-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"co 2 nghiem : {x1} va {x2}");
                }
                else if (delta == 0)
                {
                    x1 = (-b / (2 * a));
                    Console.WriteLine($"Phong trinh co nghiem kep: x1 = x2 = {x1}");
                }
                else
                {
                    Console.WriteLine("PT vo nghiem");
                }
            }

        }
        public static void Bai5()
        {
            int a, b, c;
            Input_ab(out a, out b, out c);
            Caculator(a, b, c);
        }
    }
}
