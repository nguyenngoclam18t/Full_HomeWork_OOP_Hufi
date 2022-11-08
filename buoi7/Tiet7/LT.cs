using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet7
{
    class LT:MonHoc
    {
        private double tieuLuan, giuaKi, cuoiKi;

       

        public double TieuLuan { get => tieuLuan; set => tieuLuan = value; }
        public double GiuaKi { get => giuaKi; set => giuaKi = value; }
        public double CuoiKi { get => cuoiKi; set => cuoiKi = value; }

        public LT() : base()
        {
        }

        public LT(string maMon, string tenMon, int soTinChi,double tieuLuan, double giuaKi, double cuoiKi):base(maMon,tenMon,soTinChi)
        {
            this.tieuLuan = tieuLuan;
            this.giuaKi = giuaKi;
            this.cuoiKi = cuoiKi;
        }

        public override double DiemTichLuy()
        {
            return tieuLuan * 0.2 + giuaKi * 0.3 + cuoiKi * 0.5;
        }
        public override double HocPhi()
        {
            return soTinChi*25000;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("tiểu luận: {0,-10} giữa kì: {1,-10} Cuối kì: {2,-10}", tieuLuan, giuaKi, cuoiKi);
        }
    }
}
