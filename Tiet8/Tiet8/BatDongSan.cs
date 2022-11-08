using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet8
{
    public abstract class BatDongSan
    {
        private string maSo;
        private double chieuRong;
        private double chieuDai;

        public string MaSo { get => maSo; set => maSo = value; }
        public double ChieuDai { get => chieuDai; set => chieuDai = value; }
        public double ChieuRong { get => chieuRong; set => chieuRong = value; }

        public BatDongSan(string maSo, double chieuRong, double chieuDai)
        {
            this.maSo = maSo;
            this.chieuRong = chieuRong;
            this.chieuDai = chieuDai;
        }

        public BatDongSan()
        {
        }
        public double DienTich()
        {
            return chieuDai * ChieuRong;
        }
        public abstract double GiaBan();
        public virtual void Xuat()
        {
            Console.Write("mã số: {0,-10} | chiều dài: {1,-10} | chiều rộng: {2,-10} | Giá bán: {3,-10} |", maSo, chieuDai, chieuRong,GiaBan());
        }
    }
}
