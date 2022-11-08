using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet8
{
    class NhaO:BatDongSan
    {
        private int soLau;

        public int SoLau { get => soLau; set => soLau = value; }

        public NhaO(string maSo, double chieuRong, double chieuDai,int soLau)
            :base(maSo,chieuRong,chieuDai)
        {
            this.soLau = soLau;
        }
        public override double GiaBan()
        {
            return DienTich() * 10000 + soLau * 100000;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write("số lầu:{0,-10} |", soLau);
        }
    }
}
