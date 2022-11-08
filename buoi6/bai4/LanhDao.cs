using System;
using System.Collections.Generic;
using System.Text;

namespace bai4
{
    class LanhDao:Nhanvien
    {
        private string chucvu;
        private int thamnienquanli;

        public string Chucvi { get => chucvu; set => chucvu = value; }
        public int Thamnienquanli { get => thamnienquanli; set => thamnienquanli = value; }
        public LanhDao():base("Nv009","Diệu Hiền",4.67)
        {
            chucvu = "Giám đốc";
            thamnienquanli = 10;
        }
        public LanhDao(string ma,string ten,double hesoluong,string chucvi,int thamnienquanli) : base(ma, ten, hesoluong)
        {
            this.chucvu = chucvi;
            this.thamnienquanli = thamnienquanli;
        }
        public override double Thunhap()
        {
            double heso = 1;
            if (chucvu == "Giám đốc")
                heso = 7;
            if (chucvu == "Trưởng phòng")
                heso = 6;
            if (chucvu == "Phó phòng")
                heso = 4.5;
            return base.Thunhap()+1500*heso;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("chức vụ: {0,-10}", chucvu);
        }
    }
}
