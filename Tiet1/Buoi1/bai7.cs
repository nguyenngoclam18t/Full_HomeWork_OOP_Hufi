using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi1
{
    class bai7
    {
        static bool check(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return n > 1;
        }
        static void Module(int n)
        {
            int i = 2;
            while (i <= n)
            {
                if (check(i) && n % i == 0)
                {
                    n /= i;
                    Console.Write(i + " ");
                }
                else
                {
                    i++;
                }
            }
        }
        static void Count(string check)
        {
            int count = 0;
            for (int i = 0; i < check.Length; i++)
            {
                if (char.IsDigit(check[i]))
                {
                    count++;
                }
            }
            Console.WriteLine($"co {count} so");
        }
        public static void Bai7()
        {
            string a;
            int number;
            bool check;
            do
            {
                Console.Write("nhap n: ");
                a = Console.ReadLine();
                check = int.TryParse(a, out number);
                if (!check)
                    Console.WriteLine($"xin moi nhap lai");
            } while (check == false);
            Count(a);
            Module(number);

        }
    }
}
