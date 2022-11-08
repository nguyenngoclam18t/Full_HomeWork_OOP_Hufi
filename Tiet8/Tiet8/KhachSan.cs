using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet8
{
    class KhachSan:BatDongSan,Iphi
    {
        private int soSao;

        public int SoSao { get => soSao; set => soSao = value; }

        public KhachSan(string maSo, double chieuRong, double chieuDai, int soSao)
            : base(maSo, chieuRong, chieuDai)
        {
            this.soSao = soSao;
        }
        public override double GiaBan()
        {
            return (100000 + soSao * 50000)+PhiKinhDoanh();
        }
        public double PhiKinhDoanh()
        {
            return  ChieuRong * 5000;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write("số sao: {0,-10} |", soSao);
        }
    }

}
