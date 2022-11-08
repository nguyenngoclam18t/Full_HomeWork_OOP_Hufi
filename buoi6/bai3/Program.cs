using System;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            NGK temp = new  NGK();
            temp.Nhap();
            temp.Xuat();
        }
    }
}
