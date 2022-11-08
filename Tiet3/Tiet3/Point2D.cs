using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Tiet3
{
    class Point2D
    {
        private double x, y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public Point2D()
        {
            x = y = 0;
        }
        public Point2D(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        public Point2D(Point2D temp)
        {
            x = temp.x;
            y = temp.y;
        }
        ~Point2D()
        {
            Console.WriteLine("đây là phương thức hủy");
        }
        public void nhap()
        {
            Console.Write("nhập tọa độ x: ");
            x= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("nhập tọa độ y: ");
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        public void Xuat()
        {
            Console.WriteLine("X: " + x + "Y: " + y);
        }
        public bool CheckTrucTung()
        {
            return x == 0 ? true : false;
        }
        public bool CheckTrucHoanh()
        {
            return y == 0 ? true : false;
        }
        public void thayDoivitri(int tx,int ty)
        {
            x += tx;
            y += ty;
        }
        public void thayDoivitri(Point2D temp)
        {
            x += temp.x;
            y += temp.y;
        }
        public double tinhKhoangCach()
        {
            return Math.Sqrt(Math.Pow(x - 0, 2)+ Math.Pow(y - 0, 2));
        }
        public double tinhKhoangCach(Point2D temp)
        {
            return Math.Sqrt(Math.Pow(x - temp.x, 2) + Math.Pow(y - temp.y, 2));
        }
        public Point2D doiXungQuaTrucTung(Point2D temp)
        {
            return new Point2D(x-(x*2), y);
        }
        public Point2D doiXungQuaTrucHoanh(Point2D temp)
        {
            return new Point2D(x,y-(y*2));
        }
    }
}
