using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet7
{
    class DA:MonHoc
    {
        private double gvhd, gvpb;

        public double Gvhd { get => gvhd; set => gvhd = value; }
        public double Gvpb { get => gvpb; set => gvpb = value; }

        public DA():base()
        {
        }

        public DA(string maMon, string tenMon,  int soTinChi,double gvhd, double gvpb) : base(maMon, tenMon,  soTinChi)
        {
            this.gvhd = gvhd;
            this.gvpb = gvpb;
        }

        public override double DiemTichLuy()
        {
            return (gvhd * 2 + gvpb) / 3;
        }
        public override double HocPhi()
        {
            return 2000000;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("giáo viên hướng dẫn: {0,-5} giáo viên phản biện: {1,-5}", gvhd, gvpb);
        }
    }
}
