using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet8
{
    public abstract class CTY_T
    {
        protected string maNhanVien, ten;

        public string Ten { get => ten; set => ten = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }

        public CTY_T(string maNhanVien, string ten)
        {
            this.maNhanVien = maNhanVien;
            this.ten = ten;
        }
        public CTY_T()
        {
        }
        public abstract string Danhgia();
        public abstract double Luong();

        public string DanhGiaNhanVien()
        {
            if (Danhgia() == "chiến sĩ thi đua")
                return "năng lực tốt";
            if (Danhgia() == "lao động tiên tiến")
                return "có năng lực";
            return "";
        }
        public void Xuat()
        {
            Console.WriteLine("mã nhân viên: {0,-10} | tên nhân viên: {1,-20} | lương: {2,-10} | loại nhân viên: {3,-20} |đánh giá nhân viên: {4,-15} |", maNhanVien, ten,Math.Round(Luong(),5),Danhgia(), DanhGiaNhanVien());
        }
    }
}
