using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DanhSachKH temp = new DanhSachKH();
            temp.Nhap();
            temp.Xuat();
            Console.WriteLine();
            
            Console.WriteLine(temp.ThuDuoc());
            temp.after15();
            Console.WriteLine(temp.CountGV("Nguyễn Ngọc Lâm"));
            temp.SortHP();
            Console.WriteLine();
            temp.SortGioHoc();
        }
    }
}
