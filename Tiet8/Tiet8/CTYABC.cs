using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet8
{
    public abstract class CTYABC:CTY_T
    {
        protected int namSinh, namVaoLam;
        protected string gioiTinh;
        protected double heSoLuong;
        public static int Luongcoban = 11210;
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public int NamVaoLam { get => namVaoLam; set => namVaoLam = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }

        public CTYABC(string maNhanVien, string ten,int namSinh, int namVaoLam, string gioiTinh, double heSoLuong)
            :base(maNhanVien,ten)
        {
            this.namSinh = namSinh;
            this.namVaoLam = namVaoLam;
            this.gioiTinh = gioiTinh;
            this.heSoLuong = heSoLuong;
        }
        public CTYABC()
        {
        }
        public abstract char XepLoai();
        public override double Luong()
        {
            return heSoLuong * Luongcoban;
        }
        public double Phucapthamnien()
        {
            int namlamviec = DateTime.Now.Year - namVaoLam;
            return (namlamviec >= 5) ? namlamviec * Luongcoban / 100 : 0;
        }
        public double ThuNhap()
        {
            if (XepLoai() == 'A')
                return Luong() + Phucapthamnien();
            if(XepLoai()=='B')
                return 0.75*Luong() + Phucapthamnien();
            if(XepLoai()=='C')
                return 0.5 * Luong() + Phucapthamnien();
            return  Phucapthamnien();
        }
        public override string Danhgia()
        {
            if (XepLoai() == 'A')
                return "chiến sĩ thi đua";
            if (XepLoai() == 'B')
                return "lao động tiên tiến";
            return "";
        }
    }
}
