using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet3
{
    class PhanSo
    {
        private int tu, mau;

        public int Tu { get => tu; set => tu = value; }
        public int Mau { 
            get => mau;
            set
            {
                if (value == 0)
                    mau = 1;
                mau = value;
            }
        }
        private static int UCLN(int a, int b)
        {
            if (b == 0) return a;
            return UCLN(b, a % b);
        }
        public PhanSo()
        {
            tu = 0;
            mau = 1;
        }
        public PhanSo(int tu,int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }
        public PhanSo(int tu)
        {
            this.tu = tu;
            this.mau = 1;
        }
        public PhanSo(PhanSo PS)
        {
            tu = PS.tu;
            mau = PS.mau;
        }
        public void Nhap()
        {
            bool check;
            do
            {
                Console.Write("mời bạn nhập tử: ");
                check = int.TryParse(Console.ReadLine(), out tu);
                if (!check)
                    Console.WriteLine("bạn đã nhập sai vui lòng nhập lại");
            } while (!check);
            do
            {
                Console.Write("mời bạn nhập mẫu: ");
                check = int.TryParse(Console.ReadLine(), out mau);
                if (!check||mau==0)
                    Console.WriteLine("bạn đã nhập sai vui lòng nhập lại");
            } while (!check||mau==0);
        }
        public void Xuat()
        {
            Console.Write(tu + "/" + mau);
        }
        public PhanSo Cong(PhanSo Ps2)
        {
            return new PhanSo(tu * Ps2.mau + mau * Ps2.tu, mau * Ps2.mau);
        }
        public PhanSo Tru(PhanSo Ps2)
        {
            return new PhanSo(tu * Ps2.mau - mau * Ps2.tu, mau * Ps2.mau);
        }
        public PhanSo Nhan(PhanSo Ps2)
        {
            return new PhanSo(tu * Ps2.tu, mau * Ps2.mau);
        }
        public PhanSo Chia(PhanSo Ps2)
        {
            return new PhanSo(tu * Ps2.mau, mau * Ps2.mau);
        }
        public static PhanSo operator+(PhanSo ps1,PhanSo ps2)
        {
            return new PhanSo(ps1.tu * ps2.mau + ps1.mau * ps2.tu, ps1.mau * ps2.mau);
        }
        public static PhanSo operator -(PhanSo ps1, PhanSo ps2)
        {
            return new PhanSo(ps1.tu * ps2.mau - ps1.mau * ps2.tu, ps1.mau * ps2.mau);
        }
        public static PhanSo operator *(PhanSo ps1, PhanSo ps2)
        {
            return new PhanSo(ps1.tu *  ps2.tu, ps1.mau * ps2.mau);
        }
        public static PhanSo operator /(PhanSo ps1, PhanSo ps2)
        {
            return new PhanSo(ps1.tu * ps2.mau, ps1.mau * ps2.mau);
        }
        public void ToiGian()
        {
            int ucln = UCLN(tu,mau);
            tu /= ucln;
            mau /= ucln;
        }
        public static bool operator ==(PhanSo ps1, PhanSo ps2)
        {
            ps1.ToiGian();
            ps2.ToiGian();
            if (ps1.mau != ps2.mau || ps1.tu != ps2.tu)
                return false;
            return true;
        }
        public static bool operator !=(PhanSo ps1, PhanSo ps2)
        {
            int ucln = UCLN(ps1.tu, ps1.mau);
            ps1.tu /= ucln;
            ps1.mau /= ucln;
            ucln = UCLN(ps2.tu, ps2.mau);
            ps2.tu /= ucln;
            ps2.mau /= ucln;
            if (ps1.mau == ps2.mau && ps1.tu == ps2.tu)
                return false;
            return true;
        }
        public static bool operator >(PhanSo ps1, PhanSo ps2)
        {
            double PS1 = (double)(ps1.tu / ps1.mau);
            double PS2 = (double)(ps2.tu / ps2.mau);
            return PS1 > PS2;
        }
        public static bool operator <(PhanSo ps1, PhanSo ps2)
        {
            double PS1 = (double)(ps1.tu / ps1.mau);
            double PS2 = (double)(ps2.tu / ps2.mau);
            return PS1 < PS2;
        }
        public static bool operator >=(PhanSo ps1, PhanSo ps2)
        {
            double PS1 = (double)(ps1.tu / ps1.mau);
            double PS2 = (double)(ps2.tu / ps2.mau);
            return PS1 >= PS2;
        }
        public static bool operator <=(PhanSo ps1, PhanSo ps2)
        {
            double PS1 = (double)(ps1.tu / ps1.mau);
            double PS2 = (double)(ps2.tu / ps2.mau);
            return PS1 <= PS2;
        }
        public static PhanSo operator++(PhanSo ps1)
        {
            return new PhanSo(ps1.tu + ps1.mau, ps1.mau);
        }
        public static PhanSo operator --(PhanSo ps1)
        {
            return new PhanSo(ps1.tu - ps1.mau, ps1.mau);
        }
        public static PhanSo operator ^(PhanSo ps1,int luythua)
        {
            return new PhanSo((int) Math.Pow(ps1.tu,luythua), (int)Math.Pow(ps1.mau,luythua));
        }
        public static implicit operator PhanSo(int Decimal)
        {
            return new PhanSo(Decimal);
        }
        public static explicit operator int (PhanSo ps1)
        {
            return ps1.tu / ps1.mau;
        }
        
        public static implicit operator PhanSo(double Sothuc)
        {
            int dem = 1 ;
            int tu = (int)Sothuc;
            while (tu != Sothuc)
            {
                Sothuc *= 10;
                tu = tu * 10 + ((int)Sothuc % 10);
                dem *= 10;
            }
            int ucln = UCLN(tu, dem);
            return new PhanSo(tu/ucln, dem/ucln);
        }
        public static explicit operator double(PhanSo ps1)
        {
            return (double) ps1.tu / ps1.mau;
        }
        public static implicit operator HonSo(PhanSo ps)
        {
            int tu = ps.Tu / ps.Mau;
            ps.Tu -= ps.Mau * tu;
            return new HonSo(tu, ps);
        }
    }
}
