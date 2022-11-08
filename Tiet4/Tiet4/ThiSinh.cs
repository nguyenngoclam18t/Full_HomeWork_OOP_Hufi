using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet4
{
    class ThiSinh
    {
        private string sbd, name;
        private int namsinh;
        private double diemtoan, diemvan, diemngoaingu;

        public string Sbd { get => sbd; set => sbd = value; }
        public string Name { get => name; set => name = value; }
        public double Diemtoan { get => diemtoan; set => diemtoan = value; }
        public double Diemvan { get => diemvan; set => diemvan = value; }
        public double Diemngoaingu { get => diemngoaingu; set => diemngoaingu = value; }
        public int Namsinh { get => namsinh; set => namsinh = value; }
        public double Tongdiem
        {
            get => (diemtoan + diemvan + Diemngoaingu * 2);
        }
        public string Ketqua
        {
            get
            {
                if (Tongdiem >= 25)
                    return "đậu";
                else
                    return "rớt"; 
            }
        }
        public ThiSinh()
        {
            sbd = name = "";
            namsinh = 0;
            diemtoan = diemvan = diemngoaingu = 0;
        }
        public ThiSinh(string sbd,string name,int namsinh,double diemtoan,double diemvan,double diemngoaingu)
        {
            this.sbd = sbd;
            this.name = name;
            this.namsinh = namsinh;
            this.diemtoan = diemtoan;
            this.diemvan = diemvan;
            this.diemngoaingu = diemngoaingu;
        }
        public ThiSinh(ThiSinh temp)
        {
            this.sbd = temp.sbd;
            this.name = temp.name;
            this.namsinh = temp.namsinh;
            this.diemtoan = temp.diemtoan;
            this.diemvan = temp.diemvan;
            this.diemngoaingu = temp.diemngoaingu;
        }
        public void Nhap()
        {
            bool check;
            Console.Write("mời bạn nhập SBD: ");
            sbd = Console.ReadLine();
            Console.WriteLine("mời bạn nhập tên: ");
            name = Console.ReadLine();
            do
            {
                Console.WriteLine("mời bạn nhập năm sinh: ");
                check = int.TryParse(Console.ReadLine(), out namsinh);
                if (!check)
                    Console.WriteLine("bạn đã nhập sai vui lòng nhập lại");
            } while (!check);
            do
            {
                Console.WriteLine("mời bạn nhập điểm văn: ");
                check = double.TryParse(Console.ReadLine(), out diemvan);
                if (!check||diemvan<0||diemvan>10)
                    Console.WriteLine("bạn đã nhập sai vui lòng nhập lại");
            } while (!check || diemvan < 0 || diemvan > 10);
            do
            {
                Console.WriteLine("mời bạn nhập điểm toán: ");
                check = double.TryParse(Console.ReadLine(), out diemtoan);
                if (!check || diemtoan < 0 || diemtoan > 10)
                    Console.WriteLine("bạn đã nhập sai vui lòng nhập lại");
            } while (!check || diemtoan < 0 || diemtoan > 10);
            do
            {
                Console.WriteLine("mời bạn nhập điểm anh văn: ");
                check = double.TryParse(Console.ReadLine(), out diemngoaingu);
                if (!check || diemngoaingu < 0 || diemngoaingu > 10)
                    Console.WriteLine("bạn đã nhập sai vui lòng nhập lại");
            } while (!check || diemngoaingu < 0 || diemngoaingu > 10);

        }    
        public void Xuat()
        {
            Console.WriteLine("SBD:{0,-10} Tên:{1,-20} năm sinh: {2,-5} điểm toán:{3,-5} điểm văn:{4,-5} điểm anh:{5,-5} điểm tổng:{6,-5} kết quả:{7}", sbd,name,namsinh,diemtoan,diemvan,diemngoaingu,Tongdiem,Ketqua);
        }
    }
}
