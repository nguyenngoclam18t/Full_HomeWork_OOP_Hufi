using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet8
{
    class BietThu:BatDongSan,Iphi
    {
        public override double GiaBan()
        {
            return (DienTich() * 400000)+PhiKinhDoanh();
        }
        public BietThu(string maSo, double chieuRong, double chieuDai) : base(maSo, chieuRong, chieuDai)
        {
        }
        public double PhiKinhDoanh()
        {
            return DienTich() * 1000;
        }
    }
}
