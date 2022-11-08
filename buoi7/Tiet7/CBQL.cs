using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet7
{
    public class CBQL:CongtyABC
    {
        private string chucVu;
        private double heSoChucVu;

        public CBQL():base()
        {
            
        }

        public CBQL(string ma, string ten, string gioiTinh, int namSinh, int namVaoLam, double heSoLuong, string chucVu, double heSoChucVu)
            :base(ma,ten,gioiTinh,namSinh,namSinh,heSoLuong)
        {
            this.chucVu = chucVu;
            this.heSoChucVu = heSoChucVu;
        }

        public double HeSoChucVu { get => heSoChucVu; set => heSoChucVu = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public override char xepLoai()
        {
            return 'A';
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("nhập chức vụ: ");
            chucVu = Console.ReadLine();
            Console.Write("nhập hệ số chức vụ: ");
            heSoChucVu = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("chức vụ: {0,-10}|| hệ số chức vụ: {1,-10}", chucVu, heSoChucVu);
        }
        public override double Luong()
        {
            return base.Luong()+(heSoChucVu*1100);
        }
    }
}
