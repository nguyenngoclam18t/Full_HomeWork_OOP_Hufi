using System;
using System.Collections.Generic;
using System.Text;

namespace baiHD
{
    class Nhanvien
    {
        protected string ma, ten;
        protected int namvaolam, songaynghi;
        protected double hesoluong;
        public static int LuongCoBan = 1150;

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Namvaolam { get => namvaolam; set => namvaolam = value; }
        public int Songaynghi { get => songaynghi; set => songaynghi = value; }
        public double Hesoluong { get => hesoluong; set => hesoluong = value; }
        public Nhanvien()
        {
            ma = "NV01";
            ten = "Nguyen Ngoc Lam";
            namvaolam = DateTime.Today.Year;
            songaynghi = 0;
            hesoluong = 3.0;
        }
        public Nhanvien(string manhanvien,string ten,int hesoluong)
        {
            ma =manhanvien;
            this.ten = ten;
            namvaolam = DateTime.Today.Year;
            songaynghi = 0;
            this.hesoluong = hesoluong;
        }
        public Nhanvien(string manhanvien, string ten, int hesoluong,int namvaolam,int songaynghi)
        {
            ma = manhanvien;
            this.ten = ten;
            this.namvaolam = namvaolam;
            songaynghi = songaynghi;
            this.hesoluong = hesoluong;
        }
        public double PCTN()
        {
            int sonam = DateTime.Today.Year - namvaolam;
            return sonam < 5 ? 0 : (sonam * LuongCoBan / 100) ;
        }
        public virtual char ThiDua()
        {
            if (songaynghi <= 1)
                return 'A';
            if (songaynghi <= 3)
                return 'B';
            return 'C';
        }
        public virtual void Nhap()
        {
            Console.WriteLine("nhập mã nhân viên: ");
            ma = Console.ReadLine();
            Console.WriteLine("nhập tên nhân viên: ");
            ten = Console.ReadLine();
            Console.WriteLine("nhập năm vào làm: ");
            namvaolam = int.Parse(Console.ReadLine());
            Console.WriteLine("nhập số ngày nghỉ: ");
            songaynghi = int.Parse(Console.ReadLine());
            Console.WriteLine("nhập hệ số lương nhân viên: ");
            hesoluong =double.Parse(Console.ReadLine());

        }
        public virtual void Xuat()
        {
            Console.Write("mã: {0,-10} tên:{1,-20} năm vào làm: {2,-5} số ngày nghỉ: {3,-5} hệ số lương nhân viên: {4,-5} lươngg: {5,-10} ", ma, ten, namvaolam, songaynghi, hesoluong,Luong()) ;

        }
        public virtual double Luong()
        {
            double hesothidua = 0.5;
            if (ThiDua() == 'A')
                hesothidua= 1.0;
            if (ThiDua() == 'B')
                hesothidua= 0.75;
            return (double)(LuongCoBan * hesoluong * hesothidua + PCTN());
        }
    }
}
