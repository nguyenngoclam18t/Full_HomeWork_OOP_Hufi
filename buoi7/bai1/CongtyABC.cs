using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    public abstract class CongtyABC
    {
        protected string ma, ten, gioiTinh;
        protected int namSinh, namVaoLam;
        protected double heSoLuong;
        public static int luongCoBan = 1150;
        public CongtyABC() 
        {
        }
        public CongtyABC(string ma, string ten, string gioiTinh, int namSinh, int namVaoLam, double heSoLuong)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.namSinh = namSinh;
            this.namVaoLam = namVaoLam;
            this.heSoLuong = heSoLuong;
        }

        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public int NamVaoLam { get => namVaoLam; set => namVaoLam = value; }
        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        abstract public char xepLoai();
        public double phuCapThamNien()
        {
            int soNam = DateTime.Now.Year - namVaoLam;
            return (soNam >= 5) ?1.0* soNam * luongCoBan / 100 : 0;
        }
        public virtual double Luong()
        {
            return heSoLuong * luongCoBan;
        }
        public virtual void Nhap()
        {
            Console.Write("nhập mã: ");
            ma = Console.ReadLine();
            Console.Write("nhập tên: ");
            ten = Console.ReadLine();
            Console.Write("nhập năm sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.Write("nhập năm vào làm: ");
            namVaoLam = int.Parse(Console.ReadLine());
            Console.Write("nhập hệ số lương: ");
            heSoLuong = double.Parse(Console.ReadLine());
        }

        public double thuNhap()
        {
            double heso = 0;
            if (xepLoai() == 'A')
                heso = 1;
            if (xepLoai() == 'B')
                heso = 0.75;
            if (xepLoai() == 'C')
                heso = 0.5;
            return Luong() * heso + phuCapThamNien();
        }

    }
}
