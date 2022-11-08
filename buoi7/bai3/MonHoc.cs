using System;
using System.Collections.Generic;
using System.Text;

namespace bai3
{
    public abstract class MonHoc
    {
        protected string maMon, tenMon;
        protected int soTinChi;

        public string MaMon { get => maMon; set => maMon = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public int SoTinChi { get => soTinChi; set => soTinChi = value; }

        public MonHoc()
        {
            maMon = tenMon = "";
            soTinChi = 0;
        }

        public MonHoc(string maMon, string tenMon, int soTinChi)
        {
            this.maMon = maMon;
            this.tenMon = tenMon;
            this.soTinChi = soTinChi;
        }

        abstract public double HocPhi();
        abstract public double DiemTichLuy();
        public virtual void Xuat()
        {
            Console.Write("mã môn: {0,-10} tên môn: {1,-10} số tín chỉ: {2,-10} Học Phí: {3,-10}",maMon,tenMon,soTinChi,HocPhi());
        }
    }
}
