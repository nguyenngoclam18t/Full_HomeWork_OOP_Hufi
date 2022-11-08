using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    public class NVKD:CongtyABC
    {
        private int dstt, dsbh;

        public NVKD() : base()
        {
        }

        public NVKD(string ma, string ten, string gioiTinh, int namSinh, int namVaoLam, double heSoLuong, int dstt, int dsbh) 
            : base(ma, ten, gioiTinh, namSinh, namSinh, heSoLuong)
        {
            this.dstt = dstt;
            this.dsbh = dsbh;
        }

        public int Dstt { get => dstt; set => dstt = value; }
        public int Dsbh { get => dsbh; set => dsbh = value; }
        public override char xepLoai()
        {
            if (dsbh >= 2 * dstt)
                return 'A';
            if (dsbh > dstt)
                return 'B';
            if (dsbh < dstt / 2)
                return 'D';
            return 'C';
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("nhập doanh số tối thiểu: ");
            dstt = int.Parse(Console.ReadLine());
            Console.Write("nhập doanh số bán hàng: ");
            dsbh = int.Parse(Console.ReadLine());
        }
        public override double Luong()
        {
            if(dsbh>dstt)
                return base.Luong()+((dsbh-dstt)*0.15);
            return base.Luong();
        }
    }
}
