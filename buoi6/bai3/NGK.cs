using System;
using System.Collections.Generic;
using System.Text;

namespace bai3
{
    class NGK:Hanghoa
    {
        private string donvitinh;
        private int soluong;
        private double dongia;
        public static int CK=10;
        public string Donvitinh { get => donvitinh; set => donvitinh = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public double Dongia { get => dongia; set => dongia = value; }
        public NGK() : base()
        {
            soluong = 0;
            dongia = 0;
            donvitinh = "kết";
        }
        public NGK(string ma,string ten,string donvitinh,int soluong,double dongia)
            : base(ma, ten)
        {
            if (donvitinh != "kết" && donvitinh != "chai" && donvitinh != "thùng" && donvitinh != "lon")
                donvitinh = "kết";
            this.donvitinh = donvitinh;
            this.dongia = dongia;
            this.soluong = soluong;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("nhập đơn vị tính: ");
            donvitinh = Console.ReadLine();
            Console.Write("nhập số lượng: ");
            soluong = int.Parse(Console.ReadLine());
            Console.Write("nhập đơn giá: ");
            dongia = double.Parse(Console.ReadLine());
            if (donvitinh != "kết" && donvitinh != "chai" && donvitinh != "thùng" && donvitinh != "lon")
                donvitinh = "kết";
            
        }
        public double TongTien()
        {
            double thanhtien = 0;
            if (donvitinh == "kết" || donvitinh == "thùng")
                thanhtien = soluong * dongia;
            else if(donvitinh=="chai")
                thanhtien = soluong * dongia/20;
            else
                thanhtien = soluong * dongia / 24;
            return thanhtien * CK;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("đơn vị tính: {0,-5} số lượng: {1,-5} đơn giá: {2,-10} Tổng tiền: {3,-10}", donvitinh, soluong, dongia,TongTien());
        }
    }
}
