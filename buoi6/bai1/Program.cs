using System;

namespace baiHD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Lanhdao Lam = new Lanhdao();
            Lam.Nhap();
            Lam.Xuat();
            Nhanvien temp = new Nhanvien();
            temp.Nhap();
            temp.Xuat();
            temp = Lam;
            temp.Xuat();
        }
    }
}
