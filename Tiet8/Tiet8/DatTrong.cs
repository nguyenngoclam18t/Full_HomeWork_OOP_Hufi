using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet8
{
    class DatTrong:BatDongSan
    {
        public override double GiaBan()
        {
            return DienTich() * 10000;
        }
        public DatTrong(string maSo, double chieuRong, double chieuDai):base(maSo,chieuRong,chieuDai)
        {
        }

    }
}
