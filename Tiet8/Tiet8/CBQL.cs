using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet8
{
    public class CBQL:CTYABC
    {
        private string chucVu;
        private double heSoChucVu;

        public string ChucVu { get => chucVu; set => chucVu = value; }
        public double HeSoChucVu { get => heSoChucVu; set => heSoChucVu = value; }

        public CBQL(string maNhanVien, string ten, int namSinh, int namVaoLam, string gioiTinh, double heSoLuong, string chucVu, double heSoChucVu)
             : base(maNhanVien, ten, namSinh, namVaoLam, gioiTinh, heSoLuong)
        {
            this.chucVu = chucVu;
            this.heSoChucVu = heSoChucVu;
        }

        public CBQL():base()
        {
        }
        public override char XepLoai()
        {
            return 'A';
        }
        public double PCCV()
        {
            return heSoChucVu * 1100;
        }
        public override double Luong()
        {
            return base.Luong()+PCCV();
        }
    }
}
