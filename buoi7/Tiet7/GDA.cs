using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet7
{
    class GDA:ChungcuXYZ
    {
        private int soNhanKhau;
        public int SoNhanKhau { get => soNhanKhau; set => soNhanKhau = value; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("số nhân khẩu: ");
            soNhanKhau = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("số nhân khẩu: " + soNhanKhau);
        }
        public override double SNPTT()
        {
            return KhoiNuocSD() - 5 * soNhanKhau;
        }
    }
}
