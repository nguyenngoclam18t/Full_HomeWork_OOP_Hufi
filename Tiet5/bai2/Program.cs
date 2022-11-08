using System;

namespace bai2
{
    class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DSTS temp = new DSTS();
            temp.nhap();
            temp.xuat();
            Console.WriteLine(temp.TongTien()+"\t" + temp.Soluong());
            temp.DS_CCA();
            Console.WriteLine();
           
            temp.Sort();
            Console.WriteLine();
            temp.xuat();
            
        }
    }
}
