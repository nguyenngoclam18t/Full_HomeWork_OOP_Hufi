using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet2
{
    class NGK
    {
        private string tenhang, donvitinh;
        private int soluong;
        private float dongia;
        private static float VAT = 0.10f;
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public string Donvitinh {
            get => donvitinh;
            set {
                if (value != "kết" && value != "chai" && value != "thùng" && value != "lon")
                    donvitinh = "kết";
                else
                    donvitinh = value;
            } 
        }
        public int Soluong { get => soluong; set => soluong = value; }
        public float Dongia { get => dongia; set => dongia = value; }
        public NGK()
        {
            tenhang = "";
            soluong = 0;
            dongia = 0;
            Donvitinh = "kết";
        }
        public NGK(string tenhang,string donvitinh,int soluong,float dongia)
        {
            this.tenhang = tenhang;
            this.donvitinh = donvitinh;
            this.soluong = soluong;
            this.dongia = dongia;
            if (donvitinh != "kết" && donvitinh != "chai" && donvitinh != "thùng" && donvitinh != "lon")
                this.donvitinh = "kết";
            else
                this.donvitinh = donvitinh;
        }
        public NGK(NGK temp)
        {
            this.tenhang = temp.tenhang;
            this.donvitinh = temp.donvitinh;
            this.soluong = temp.soluong;
            this.dongia = temp.dongia;
            this.donvitinh = temp.donvitinh;
        }
        public void Nhap()
        {
            bool check;
            Console.Write("mời bạn nhập tên: ");
            tenhang = Console.ReadLine();
            Console.Write("mời bạn nhập đơn vị tính: ");
            donvitinh = Console.ReadLine();

            
            do
            {
                Console.Write("mời bạn nhập số lượng: ");
                check = int.TryParse(Console.ReadLine(), out soluong);
                if (!check)
                    Console.WriteLine("vui lòng nhập lại");
            } while (!check);
            do
            {
                Console.Write("mời bạn nhập đơn giá: ");
                check = float.TryParse(Console.ReadLine(), out dongia);
                if (!check)
                    Console.WriteLine("vui lòng nhập lại");
            } while (!check);

            if (donvitinh != "kết" && donvitinh != "chai" && donvitinh != "thùng" && donvitinh != "lon")
                this.donvitinh = "kết";
        }
        public void Xuat()
        {
            Console.WriteLine($"tên hàng: {tenhang}\tđơn vị tính: {donvitinh}\tsố lượng: {soluong}\tđơn giá: {dongia}\tthành tiền: {ThanhTien()}\n ");
        }
        public double ThanhTien()
        {
            if (donvitinh == "kết" || donvitinh == "thùng")
            {
                return (soluong * dongia) + (soluong * dongia  * VAT);
            }else if (donvitinh == "chai")
            {
                return (soluong * (dongia/20)) + (soluong * (dongia / 20) * VAT);
            }
            else if(donvitinh=="lon")
            {
                return (soluong * (dongia / 24)) + (soluong * (dongia / 24) * VAT);
            }
            return 0;
        }
    }
}
