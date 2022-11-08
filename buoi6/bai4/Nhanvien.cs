using System;
using System.Collections.Generic;
using System.Text;

namespace bai4
{
    class Nhanvien
    {
        protected string ma, ten;
        protected double hesoluong;
        public static int luongcoban = 1150;

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public double Hesoluong { get => hesoluong; set => hesoluong = value; }
        public Nhanvien()
        {
            ma = "NV001";
            ten = "Nguyễn Ngọc Lâm";
            hesoluong = 2.34;
        }
        public Nhanvien(string ma,string ten,double hesoluong)
        {
            this.ma = ma;
            if (ma.StartsWith("NV")==false)
                this.ma = "NV001";
            this.ten = ten;
            this.hesoluong = hesoluong;
        }
        public virtual double Thunhap()
        {
            return (double) hesoluong * luongcoban;
        }
        public virtual void Xuat()
        {
            Console.Write("mã:{0,-10} tên: {1,-10} hệ số lương: {2,-10} thu nhập:{3,-10} ", ma, ten, hesoluong, Thunhap());
        }
    }
}
