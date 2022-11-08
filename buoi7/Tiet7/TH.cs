using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet7
{
    class TH:MonHoc
    {
        private double kiemtra1, kiemtra2, kiemtra3, kiemtra4;

        public double Kiemtra1 { get => kiemtra1; set => kiemtra1 = value; }
        public double Kiemtra2 { get => kiemtra2; set => kiemtra2 = value; }
        public double Kiemtra3 { get => kiemtra3; set => kiemtra3 = value; }
        public double Kiemtra4 { get => kiemtra4; set => kiemtra4 = value; }

        public TH() : base()
        {
        }

        public TH(string maMon, string tenMon,  int soTinChi,double kiemtra1, double kiemtra2, double kiemtra3, double kiemtra4) : base(maMon, tenMon,  soTinChi)
        {
            this.kiemtra1 = kiemtra1;
            this.kiemtra2 = kiemtra2;
            this.kiemtra3 = kiemtra3;
            this.kiemtra4 = kiemtra4;
        }

        public override double DiemTichLuy()
        {
            return (kiemtra1 + kiemtra2 + kiemtra3 + kiemtra4) / 4;
        }
        public override double HocPhi()
        {
            return soTinChi * 35000 + 100000;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("kiểm tra 1: {0,-5} kiểm tra 2: {1,-5} kiểm tra 3: {2,-5} kiểm tra 4: {3,-5}", kiemtra1, kiemtra2, kiemtra3, kiemtra4);
        }
    }
}
