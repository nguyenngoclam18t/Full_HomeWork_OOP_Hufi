using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet8
{
    public class CTYBCD:CTY_T
    {
        private double tongSotien;

        public double TongSotien { get => tongSotien; set => tongSotien = value; }

        public CTYBCD(string maNhanVien, string ten,double tongSotien):base(maNhanVien,ten)
        {
            this.tongSotien = tongSotien;
        }

        public CTYBCD():base()
        {
        }
        public override double Luong()
        {
            return 0.15 * TongSotien;
        }
        public override string Danhgia()
        {
            if (Luong() >= 20000)
                return "chiến sĩ thi đua";
            if (Luong() >= 10000)
                return "lao động tiên tiến";
            return "";
        }
    }
}
