using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi1
{
    class bai8
    {
        public static void Bai8()
        {

            int number;
            bool check;
            do
            {
                Console.Write("nhap n: ");
                check = int.TryParse(Console.ReadLine(), out number);
                if (!check)
                    Console.WriteLine($"xin moi nhap lai");
            } while (check == false);
            int i = (int)Math.Sqrt(number);
            if (i * i == number)
                Console.WriteLine("day la so chinh phuong");
            else
                Console.WriteLine("day ko phai so chinh phuong");
        }
    }
}
