using System;

namespace bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Sinhvien temp = new Sinhvien("lâm đẹp trai", DateTime.Now, "nam", "2001215906", "đại học");
            temp.Xuat();
        }
    }
}
