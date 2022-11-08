using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1
{
    class KhoaHoc
    {
        private string ma, nameKh, giaovien, giohoc;
        private int sotiet, sohocvien;
        private static int HocPhi1Tiet = 20;

        public string Ma { get => ma; set => ma = value; }
        public string NameKh { get => nameKh; set => nameKh = value; }
        public string Giaovien { get => giaovien; set => giaovien = value; }
        public string Giohoc { get => giohoc; set => giohoc = value; }
        public int Sotiet { get => sotiet; set => sotiet = value; }
        public int Sohocvien { get => sohocvien; set => sohocvien = value; }
        public double Hocphi
        {
            get => HocPhi1Tiet * HeSoGioHoc() * sotiet;
        }
        public double HeSoGioHoc()
        {
            if (giohoc == "7,CN")
                return 1.2;
            return 1;

        }

        public KhoaHoc()
        {
            ma = "TH023";
            nameKh = "Android Programming";
            sotiet = 48;
            sohocvien = 13;
            giohoc = "2,4,6";
            giaovien = "Nguyễn Ngọc Lâm";
        }
        public KhoaHoc(string ma,string namekh,int sotiet,int sohocvien,string giohoc,string giaovien)
        {
            this.ma = ma;
            this.nameKh = namekh;
            this.sotiet = sotiet;
            this.sohocvien = sohocvien;
            this.giohoc = giohoc;
            this.giaovien = giaovien;
            if (this.giohoc != "2,4,6" && this.giohoc != "3,5,7" && this.giohoc != "7,CN")
                this.giohoc = "3,5,7";
        }
        public KhoaHoc(KhoaHoc New)
        {
            this.ma = New.ma;
            this.nameKh = New.nameKh;
            this.sotiet = New.sotiet;
            this.sohocvien = New.sohocvien;
            this.giohoc = New.giohoc;
            this.giaovien = New.giaovien;
            if (giohoc != "2,4,6" && giohoc != "3,5,7" && giohoc != "7,CN")
                giohoc = "3,5,7";
        }
        public double ThuLaoGV()
        {
            if (sohocvien < 10)
                return 100;
            return  100+((sotiet-10) *2);
        }
        public static KhoaHoc operator +(KhoaHoc New,int n)
        {
            New.sotiet += n;
            return new KhoaHoc(New);
        }
        public void Xuat()
        {
            Console.WriteLine("mã:{0,-5} tên: {1,-20} số tiết: {2,-10} buổi học: {3,-10} học viên:{4,-5} học phí:{5,-5}", ma, nameKh, sotiet, giohoc,sohocvien, Hocphi);
        }
        
    }
}
