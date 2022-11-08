using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet3
{
    class TTD
    {
        private string name, maso;
        private double masocu, masomoi;
        private static int DinhMuc = 50;
        private static int DGTDM = 3000;

        public string Name { get => name; set => name = value; }
        public string Maso { get => maso; set => maso = value; }
        public double Masocu { get => masocu; set => masocu = value; }
        public double Masomoi { get => masomoi; set => masomoi = value; }
        public double Sdsd { get => masomoi - masocu; }
  
        public TTD()
        {
            name = maso = "";
            masomoi = masocu = 0;
        }
        public TTD(string name,string maso,int sodiencu,int sodienmoi)
        {
            this.name = name;
            this.maso = maso;
            this.masomoi = sodienmoi;
            this.masocu = sodiencu;
        }
        public TTD(TTD temp)
        {
            name = temp.name;
            maso = temp.maso;
            masomoi = temp.masomoi;
            masocu = temp.masocu;
        }
        public void Nhap()
        {
            bool check;
            Console.WriteLine("mời bạn nhập tên: ");
            name = Console.ReadLine();
            Console.WriteLine("mời bạn nhập mã số công tơ điện: ");
            maso = Console.ReadLine();
            do
            {
                Console.WriteLine("mời bạn nhập số điện cũ: ");
                check = double.TryParse(Console.ReadLine(), out masocu);
                if (!check)
                    Console.WriteLine("vui lòng nhập lại");
            } while (!check);
            do
            {
                Console.WriteLine("mời bạn nhập số điện mới: ");
                check = double.TryParse(Console.ReadLine(), out masomoi);
                if (!check||masocu>=masomoi)
                    Console.WriteLine("vui lòng nhập lại");
            } while (!check|| masocu >= masomoi);
        }
        public double TinhTienDien()
        {
            if (Sdsd < TTD.DinhMuc)
                return (double) Sdsd * TTD.DGTDM;
            return (double)(Sdsd * TTD.DGTDM)*1.5;
        }
        public void Xuat()
        {
            Console.WriteLine($"name:{name} \nmã số công tơ điện: {maso}\n số điện cũ: {masocu}\n số điện mới:{masomoi}\n tổng tiền: {TinhTienDien()}");
        }
    }
}
