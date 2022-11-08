using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    public class  NVXS:CongtyABC
    {
        private int soNgayNghi;
        public static double heSoPhuCap = 0.1;

        public NVXS(string ma, string ten, string gioiTinh, int namSinh, int namVaoLam, double heSoLuong, int soNgayNghi):base(ma, ten, gioiTinh, namSinh, namSinh, heSoLuong)
        {
            this.soNgayNghi = soNgayNghi;
        }

        public int SoNgayNghi { get => soNgayNghi; set => soNgayNghi = value; }
        public override char xepLoai()
        {
            if (soNgayNghi <= 1)
                return 'A';
            if (soNgayNghi <= 3)
                return 'B';
            if (soNgayNghi <= 5)
                return 'C';
            return 'D';
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("nhập số ngày nghỉ: ");
            soNgayNghi = int.Parse(Console.ReadLine());
        }
        public override double Luong()
        {
            return base.Luong()*(1+heSoPhuCap);
        }

    }
}
