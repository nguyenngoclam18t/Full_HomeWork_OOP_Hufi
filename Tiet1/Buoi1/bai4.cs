using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi1
{
    class bai4
    {
        static void Input_ab(out int a, out int b)
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
        }
        static void Caculator(int a, int b)
        {
            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("PT vo so nghiem");
                else
                    Console.WriteLine("PT vo nghiem");
            }
            else
            {
                float answer = (float)-b / a;
                Console.WriteLine($"co nghiem la: {answer}");
            }
        }
         public static void Bai4()
        {
            int a, b;
            Input_ab(out a, out b);
            Caculator(a, b);
        }

    }
}
