using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet8
{
    public class NVKD:CTYABC
    {
        private int dSTT, dSBH;

        public int DSTT { get => dSTT; set => dSTT = value; }
        public int DSBH { get => dSBH; set => dSBH = value; }

        public NVKD(string maNhanVien, string ten, int namSinh, int namVaoLam, string gioiTinh, double heSoLuong,int dSTT, int dSBH)
            :base(maNhanVien,ten,namSinh,namVaoLam,gioiTinh,heSoLuong)
        {
            this.dSTT = dSTT;
            this.dSBH = dSBH;
        }
        public NVKD():base()
        {
        }
        public override char XepLoai()
        {
            if (dSBH <= dSTT / 2)
                return 'D';
            if (dSTT > dSBH)
                return 'C';
            if (dSTT*2 <= dSBH)
                return 'A';
            return 'B';
        }
        public double HoaHong()
        {
            if (dSTT > dSBH)
                return 0;
            return ((dSBH - dSTT) * 500)*0.15;
        }
        public override double Luong()
        {
            return base.Luong()+HoaHong();
        }
    }
}
