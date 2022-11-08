using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet3
{
    class So_phuc
    {
        private float real, img;

        public float Real { get => real; set => real = value; }
        public float Img { get => img; set => img = value; }
        public So_phuc()
        {
            real = 0;
            img = 0;
        }
        public So_phuc(float real,float img)
        {
            this.real = real;
            this.img = img;
        }
        public So_phuc(So_phuc temp)
        {
            real = temp.real;
            img = temp.img;
        }
        ~So_phuc()
        {

        }
        public void Nhap()
        {
            bool check;
            do
            {
                Console.Write("mời nhập phần thực: ");
                check = float.TryParse(Console.ReadLine(), out real);
            } while (!check);
            do
            {
                Console.Write("mời nhập phần ảo: ");
                check = float.TryParse(Console.ReadLine(), out img);
            } while (!check);
        }
        public void Xuat()
        {
            Console.WriteLine(real + " + " + img + "i");
        }
        //hàm bình thường ko chơi nạp chồng hay operator overloading
        public So_phuc Cong(So_phuc SP2)
        {

            return new So_phuc(real + SP2.real, img + SP2.img);
        }
        public bool Compare(So_phuc SP2)
        {
            if (real != SP2.real)
                return false;
            if (img != SP2.img)
                return false;
            return true;
        }

        //sử dụng operator overloading
        public static So_phuc operator+(So_phuc SP1,So_phuc SP2)
        {
            return new So_phuc(SP1.real + SP2.real, SP2.img + SP1.img);
        }
        public static So_phuc operator-(So_phuc SP1, So_phuc SP2)
        {
            return new So_phuc( SP1.real - SP2.real, SP2.img - SP1.img);
        }
        public static bool operator==(So_phuc SP1,So_phuc SP2)
        {
            return (SP1.real == SP2.real && SP1.img == SP2.img) ? true : false;
        }
        public static bool operator !=(So_phuc SP1, So_phuc SP2)
        {
            return (SP1.real != SP2.real && SP1.img != SP2.img) ? true : false;
        }
        public static So_phuc operator*(So_phuc SP1,So_phuc SP2)
        {
            float Real =(float)(Math.Pow(SP1.real, 2) - Math.Pow(SP2.real, 2));
            float Img = SP1.real * SP2.img + SP2.real * SP1.img;
            return new So_phuc(Real, Img);
        }


    }
}
