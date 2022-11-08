using System;
using System.Collections.Generic;
using System.Text;

namespace bai3
{
    class Hanghoa
    {
        protected string ma, ten;
        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public Hanghoa()
        {
            ma = ten = "";
        }
        public Hanghoa(string ma,string name)
        {
            if (ma.Length == 5)
            {
                if (ma[0] != 'H' || ma[1] != 'H')
                    ma = "HH01";
            }
            else
            {
                ma = "HH01";
            }
            this.ma = ma;
            this.ten = name;
        }
        public virtual void Nhap()
        {
            Console.Write("nhập mã: ");
            ma = Console.ReadLine();
            Console.Write("nhập tên: ");
            ten = Console.ReadLine();
        }
        public virtual void Xuat()
        {
            Console.Write("mã: {0,-10} tên: {1,-10}", ma, ten);
        }
    }
}
