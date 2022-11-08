using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi1
{
    class bai6
    {
        static void Input(out int a, out int b, out int c)
        {
            bool check;
            do
            {
                Console.Write("vui lòng nhap ngay: ");
                check = int.TryParse(Console.ReadLine(), out a);
                if (check && (a < 1 || a > 31))
                {
                    check = false;
                }
            } while (check == false);
            do
            {
                Console.Write("vui lòng nhap thang: ");
                check = int.TryParse(Console.ReadLine(), out b);
                if (check && (b < 1 || b > 12))
                {
                    check = false;
                }
            } while (check == false);
            do
            {
                Console.Write("vui lòng nhap nam: ");
                check = int.TryParse(Console.ReadLine(), out c);
                if (check && (c < 1900))
                {
                    check = false;
                }
            } while (check == false);
        }

        public static void Bai6()
        {

            int Day, Month, Year;
            Input(out Day, out Month, out Year);
            DateTime Date = new DateTime(Year, Month, Day);
            Console.WriteLine(Date.DayOfWeek);
        }
    }
}
