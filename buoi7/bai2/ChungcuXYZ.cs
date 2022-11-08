using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet7
{
    public abstract class ChungcuXYZ
    {
        protected string ten, diaChi;
        protected double chiSoNuocCu, chiSoNuocMoi;

        public string Ten { get => ten; set => ten = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public double ChiSoNuocCu { get => chiSoNuocCu; set => chiSoNuocCu = value; }
        public double ChiSoNuocMoi { get => chiSoNuocMoi; set => chiSoNuocMoi = value; }
        public double KhoiNuocSD()
        {
            return chiSoNuocMoi - chiSoNuocCu;
        }
        abstract public double SNPTT();

        public virtual void Nhap()
        {
            Console.Write("nhập tên: ");
            ten = Console.ReadLine();
            Console.Write("nhập địa chỉ: ");
            diaChi = Console.ReadLine();
            Console.Write("nhập chỉ số nước cũ: ");
            chiSoNuocCu = double.Parse(Console.ReadLine());
            Console.Write("nhập chỉ số nước mới: ");
            chiSoNuocMoi = double.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine("tên: {0,-10}|| địa chỉ: {1,-10}|| chỉ số nước cũ: {2,-5}||chỉ số nước mới: {3,-5}||", ten, diaChi, chiSoNuocCu, chiSoNuocMoi);
        }
        public double TienNuoc()
        {
            return SNPTT() * 8000;
        }
    }
}
