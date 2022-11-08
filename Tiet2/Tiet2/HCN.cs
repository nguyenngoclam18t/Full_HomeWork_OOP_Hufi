using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet2
{
    class HCN
    {
        private double width, length;
        public double Width { get => width; set => width = value; }
        public double Length { get => length; set => length = value; }
        public HCN()
        {
            width = 0;
            length = 0;
        }
        public HCN(double width,double length)
        {
            this.width = width;
            this.length = length;
        }
        public HCN(HCN temp)
        {
            this.width = temp.width;
            this.length =temp.length;
        }
        public double chuvi()
        {
            return (width + length) * 2;
        }
        public double dientich()
        {
            return width * length;
        }
        public double DCC()
        {
            double temp = Math.Pow(width, 2) + Math.Pow(length, 2);
            return Math.Sqrt(temp);
        }
        public void nhap()
        {
            bool check;
            do
            {
                Console.WriteLine("mời bạn nhập chiều rộng: ");
                check = double.TryParse(Console.ReadLine(), out width);
                if (!check) 
                    Console.WriteLine("vui lòng nhập lại");
            } while (check==false);
            do
            {
                Console.WriteLine("mời bạn nhập chiều dài: ");
                check = double.TryParse(Console.ReadLine(), out length);
                if (!check)
                    Console.WriteLine("vui lòng nhập lại");
            } while (check == false);

        }
        public void xuat()
        {
            Console.WriteLine($"chiều rộng: {width}\nchiều dài: {length}\nchu vi:{chuvi()}\n diện tích: {dientich()}\nđường chéo chính: {DCC()}" );
        }
        public void ChangeSize(int tx,int ty,int kieu)
        {
            if (kieu == 0)
            {
                width -= tx;
                length -= ty;
            }
            else
            {
                width += tx;
                length += ty;
            }
        }
         public void ChangeSize(HCN a, int kieu)
        {
            if (kieu == 0)
            {
                width -= a.width;
                length -= a.length;
            }
            else
            {
                width += a.width;
                length += a.length;
            }
        }
        ~HCN(){

        }
    }
}
