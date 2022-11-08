using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet3
{
    class HonSo
    {
        private int SoNguyen;
        private PhanSo phanso;

        public int SoNguyen1 { get => SoNguyen; set => SoNguyen = value; }
        public HonSo()
        {
            SoNguyen = 0;
            phanso = new PhanSo();
        }
        public HonSo(int songuyen,int tu,int mau)
        {
            this.SoNguyen = songuyen;
            phanso = new PhanSo(tu, mau);
        }
        public HonSo(int songuyen, PhanSo temp)
        {
            this.SoNguyen = songuyen;
            phanso = new PhanSo(temp);
        }
        public HonSo(HonSo temp)
        {
            SoNguyen = temp.SoNguyen;
            phanso = new PhanSo(temp.phanso);
        }
        public void nhap()
        {
            bool check;
            do
            {
                Console.Write("mời bạn nhập phần số nguyên: ");
                check = int.TryParse(Console.ReadLine(), out SoNguyen);
                if (!check)
                    Console.WriteLine("vui lòng nhập lại");
            } while (!check);
            phanso.Nhap();
        }
        public void xuat()
        {
            Console.Write(SoNguyen + " + ");
            phanso.Xuat();
        }
        public static implicit operator PhanSo(HonSo ps)
        {
            ps.phanso.Tu += ps.SoNguyen * ps.phanso.Mau;
            return new PhanSo(ps.phanso);
        }
        public static HonSo operator +(HonSo HS1,HonSo HS2)
        {
            HonSo HS3 = new HonSo();

            HS3.SoNguyen = HS1.SoNguyen + HS2.SoNguyen;
            HS3.phanso = HS1.phanso + HS2.phanso;
            int So = HS3.phanso.Tu / HS3.phanso.Mau;
            HS3.SoNguyen += So;
            HS3.phanso.Tu -= So * HS3.phanso.Mau;
            return HS3;
        }
        public static HonSo operator -(HonSo HS1, HonSo HS2)
        {
            HonSo HS3 = new HonSo();

            HS3.SoNguyen = HS1.SoNguyen - HS2.SoNguyen;
            HS3.phanso = HS1.phanso - HS2.phanso;
            return HS3;
        }
        public static HonSo operator *(HonSo HS1, HonSo HS2)
        {
            HonSo HS3 = new HonSo();
            HS3.SoNguyen = HS1.SoNguyen * HS2.SoNguyen;
            HS3.phanso = HS1.phanso * HS2.phanso;
            int So = HS3.phanso.Tu / HS3.phanso.Mau;
            HS3.SoNguyen += So;
            HS3.phanso.Tu -= So * HS3.phanso.Mau;
            return HS3;
        }
        public static HonSo operator /(HonSo HS1, HonSo HS2)
        {
            HonSo HS3 = new HonSo();
            HS3.SoNguyen = HS1.SoNguyen / HS2.SoNguyen;
            HS3.phanso = HS1.phanso / HS2.phanso;
            return HS3;
        }
        public static bool operator >(HonSo HS1,HonSo HS2)
        {
            double hs1 = HS1.SoNguyen + (double)(HS1.phanso.Tu / HS1.phanso.Mau);
            double hs2 = HS2.SoNguyen + (double)(HS2.phanso.Tu / HS2.phanso.Mau);
            return hs1 > hs2;
        }
        public static bool operator <(HonSo HS1, HonSo HS2)
        {
            double hs1 = HS1.SoNguyen + (double)(HS1.phanso.Tu / HS1.phanso.Mau);
            double hs2 = HS2.SoNguyen + (double)(HS2.phanso.Tu / HS2.phanso.Mau);
            return hs1 < hs2;
        }
        public static bool operator >=(HonSo HS1, HonSo HS2)
        {
            double hs1 = HS1.SoNguyen + (double)(HS1.phanso.Tu / HS1.phanso.Mau);
            double hs2 = HS2.SoNguyen + (double)(HS2.phanso.Tu / HS2.phanso.Mau);
            return hs1 >= hs2;
        }
        public static bool operator <=(HonSo HS1, HonSo HS2)
        {
            double hs1 = HS1.SoNguyen + (double)(HS1.phanso.Tu / HS1.phanso.Mau);
            double hs2 = HS2.SoNguyen + (double)(HS2.phanso.Tu / HS2.phanso.Mau);
            return hs1 <= hs2;
        }
        public static bool operator ==(HonSo HS1, HonSo HS2)
        {
            double hs1 = HS1.SoNguyen + (double)(HS1.phanso.Tu / HS1.phanso.Mau);
            double hs2 = HS2.SoNguyen + (double)(HS2.phanso.Tu / HS2.phanso.Mau);
            return hs1 == hs2;
        }
        public static bool operator !=(HonSo HS1, HonSo HS2)
        {
            double hs1 = HS1.SoNguyen + (double)(HS1.phanso.Tu / HS1.phanso.Mau);
            double hs2 = HS2.SoNguyen + (double)(HS2.phanso.Tu / HS2.phanso.Mau);
            return hs1 != hs2;
        }
        public static HonSo operator ++(HonSo HS)
        {
            return new HonSo(HS.SoNguyen++, HS.phanso);
        }
        public static HonSo operator --(HonSo HS)
        {
            return new HonSo(HS.SoNguyen--, HS.phanso);
        }
        public static implicit operator double(HonSo HS)
        {
           return HS.SoNguyen + (double)(HS.phanso.Tu / HS.phanso.Mau);
        }
        public static implicit operator HonSo(double Sothuc)
        {
            int So = (int)Sothuc;
            PhanSo PS1 = new PhanSo();
            PS1 = Sothuc;
            PS1.Tu -= So * PS1.Mau;
            return  new HonSo(So,PS1);
        }


    }
}
