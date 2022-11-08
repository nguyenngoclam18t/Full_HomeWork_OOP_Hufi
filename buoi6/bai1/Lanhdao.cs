using System;
using System.Collections.Generic;
using System.Text;

namespace baiHD
{
    class Lanhdao:Nhanvien
    {
        private string chucvu, phongban;
        private double hesold;
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Phongban { get => phongban; set => phongban = value; }
        public double Hesold { get => hesold; set => hesold = value; }
        public Lanhdao() : base()
        {
            chucvu = "truong phong";
            phongban = "IT";
            hesold = 5;
        }
        public Lanhdao(string ma,string name,int hesoluong,string chucvu,double hesolanhdao) 
            : base(ma, name, hesoluong, DateTime.Now.Year, 1)
        {
            this.chucvu = chucvu;
            this.hesold = hesolanhdao;

        }
        public Lanhdao(string ma, string name, int hesoluong, string chucvu, double hesolanhdao,string phongban,int namvaolam,int songaynghi) 
            : base(ma, name, hesoluong, namvaolam, songaynghi)
        {
            this.chucvu = chucvu;
            this.hesold = hesolanhdao;
            this.phongban = phongban;
        }
        public override char ThiDua()
        {
            return 'A';
        }
        public double Phucaplanhdao()
        {
            return (double)hesold * LuongCoBan;
        }
        public override double Luong()
        {
            return base.Luong() * Phucaplanhdao();
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("nhập chức vụ: ");
            chucvu = Console.ReadLine();
            Console.WriteLine("nhập phòng ban: ");
            phongban = Console.ReadLine();
            Console.WriteLine("nhập hệ số lãnh đạo: ");
            Hesold =double.Parse( Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("chức vụ {0,-10} phòng ban: {1,-10} hệ số lãnh đạo: {2,-5}",chucvu,phongban,hesold);
        }

    }
}
