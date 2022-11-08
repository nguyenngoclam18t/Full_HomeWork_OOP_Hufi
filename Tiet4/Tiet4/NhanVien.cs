using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet4
{
    class NhanVien
    {
        private string maNhanVien, name, phongban, chucvu;
        private double hesoluong;
        private int songaylamviec, thamniencongtac;
        private static int LuongCoban = 1210;

        public NhanVien()
        {
            maNhanVien = name = phongban = chucvu = "";
            hesoluong = 0;
            songaylamviec = thamniencongtac = 0;
        }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string Name { get => name; set => name = value; }
        public string Phongban { get => phongban; set => phongban = value; }
        public string Chucvu { 
            get => chucvu; 
            set
            {
                if (value == "Lãnh đạo")
                    chucvu = value;
                else
                    chucvu = "Nhân viên";
            }
        }
        public double Hesoluong { get => hesoluong; set => hesoluong = value; }
        public int Songaylamviec { get => songaylamviec; set => songaylamviec = value; }
        public int Thamniencongtac { get => thamniencongtac; set => thamniencongtac = value; }
        public double HeSoThiDua()
        {
            if (chucvu == "Lãnh đạo")
                return 1.0;
            else
            {
                if (songaylamviec > 22)
                    return 1;
                else if (songaylamviec > 20)
                    return 0.8;
                return 0.6;
            }
        }
        public int PhuCap()
        {
            return chucvu == "Lãnh đạo" ? 2000 : 0;
        }
        public double Luong()
        {
            return (hesoluong * LuongCoban * HeSoThiDua() + PhuCap() + 1100);
        }
        public void Xuat()
        {
            Console.Write("mã số:{0,-5} tên:{1,-25} phòng ban: {2,-10} chức vụ: {3,-10}", maNhanVien, name, phongban, chucvu);
            Console.WriteLine(" hệ số lương: {0,-5} số ngày làm việc:{1,-5} thâm niên công tác:{2,-5} lương:{3,-10}", hesoluong,songaylamviec, thamniencongtac, Luong()) ;
        }
    }
}
