using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet7
{
    class Menu
    {
        public void menu()
        {
            Console.WriteLine("1. Nhan Vien");
            Console.WriteLine("2. Ho Gia Dinh");
            Console.WriteLine("3. Mon Hoc");
            Console.WriteLine("0. out");
            Console.Write("moi ban nhap: ");
        }

        public void menuNV()
        {
            Console.WriteLine("1. Nhan Vien San Xuat");
            Console.WriteLine("2. Nhan Vien Kinh Doanh");
            Console.WriteLine("3. Can Bo Quan Ly");
            Console.WriteLine("4. Tong So Tien Cong Ty Phai Tra");
            Console.WriteLine("0. out");
            Console.Write("moi ban nhap: ");
        }

        public void menuHGD()
        {
            Console.WriteLine("1. Ho Gia Dinh Loai A");
            Console.WriteLine("2. Ho Gia Dinh Loai B");
            Console.WriteLine("3. Ho Gia Dinh Loai C");
            Console.WriteLine("0. out");
            Console.Write("moi ban nhap: ");
        }
    }
}

