using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet8
{
    public class NVSX:CTYABC
    {
        private int soNgayNghi;
        public static double HSPCNN = 0.1;

        public int SoNgayNghi { get => soNgayNghi; set => soNgayNghi = value; }

        public NVSX(string maNhanVien, string ten, int namSinh, int namVaoLam, string gioiTinh, double heSoLuong,int soNgayNghi)
            :base(maNhanVien,ten,namSinh,namVaoLam,gioiTinh,heSoLuong)
        {
            this.soNgayNghi = soNgayNghi;
        }

        public override char XepLoai()
        {
            if (soNgayNghi <= 1)
                return 'A';
            if (soNgayNghi <= 3)
                return 'B';
            if (soNgayNghi <= 5)
                return 'C';
            return 'D';
        }
        public override double Luong()
        {
            return base.Luong() * (1 + HSPCNN);
        }

    }
}
