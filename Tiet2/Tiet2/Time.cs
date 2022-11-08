using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet2
{
    class Time
    {
        private int second, minutes, hours;

        public int Second { 
            get => second;
            set
            {
                if (value <= 59 && value >= 0)
                {
                    second = value;
                }
            }
        }
        public int Minutes {
            get => minutes;
            set
            {
                if (value <= 59 && value >= 0)
                {
                    minutes = value;
                }
            }
        }
        public int Hours {
            get => hours; 
            set{
                if (value <= 23 && value >= 0)
                {
                    hours = value;
                }
            } 
        }
        public Time()
        {
            hours = minutes = second = 0;
        }
        public Time(int hours,int minutes,int second)
        {
            if (hours <= 23 && hours >= 0)
            {
                this.hours = hours;
            }
            else this.hours = 0;
            if (minutes <= 59 && minutes >= 0)
            {
                this.minutes = minutes;
            }
            else minutes = 0;
            if (second <= 59 && second >= 0)
            {
                this.second = second;
            }
            else this.second = 0;
           
        }
        public Time(Time temp)
        {
            this.hours = temp.hours;
            this.minutes = temp.minutes;
            this.second = temp.second;
        }
        public void Nhap24h()
        {
            bool check;
            do
            {
                Console.Write("mời nhập giờ: ");
                check = int.TryParse(Console.ReadLine(), out hours);
                if (hours >= 24 || hours < 0 || !check)
                    Console.WriteLine("vui lòng nhập lại");
            } while (hours>=24||hours<0||!check);
            do
            {
                Console.Write("mời nhập phút: ");
                check = int.TryParse(Console.ReadLine(), out minutes);
                if (minutes >= 60 || minutes < 0 || !check)
                    Console.WriteLine("vui lòng nhập lại");
            } while (minutes >= 60 || minutes < 0 || !check);
            do
            {
                Console.Write("mời nhập giây: ");
                check = int.TryParse(Console.ReadLine(), out second);
                if (second >= 60 || second < 0 || !check)
                    Console.WriteLine("vui lòng nhập lại");
            } while (second >= 60 || second < 0 || !check);

        }
        public void Nhap12h()
        {
            bool check;
            do
            {
                Console.Write("mời nhập giờ: ");
                check = int.TryParse(Console.ReadLine(), out hours);
                if (hours >= 12 || hours < 0 || !check)
                    Console.WriteLine("vui lòng nhập lại");
            } while (hours >= 12 || hours < 0 || !check);
            do
            {
                Console.Write("mời nhập phút: ");
                check = int.TryParse(Console.ReadLine(), out minutes);
                if (minutes >= 60 || minutes < 0 || !check)
                    Console.WriteLine("vui lòng nhập lại");
            } while (minutes >= 60 || minutes < 0 || !check);
            do
            {
                Console.Write("mời nhập giây: ");
                check = int.TryParse(Console.ReadLine(), out second);
                if (second >= 60 || second < 0 || !check)
                    Console.WriteLine("vui lòng nhập lại");
            } while (second >= 60 || second < 0 || !check);

        }
        public void Xuat24h()
        {
            Console.WriteLine($"time 24H: {hours}:{minutes}:{second}\n");
        }
        public void Xuat12h()
        {
            string dn = hours >= 12 ? "PM" : "AM";
            hours = hours > 12 ? hours - 12 : hours;
            Console.WriteLine($"time 24H: {hours}:{minutes}:{second}  {dn}");
        }
        public bool Check24h()
        {
            if (hours >= 24 || hours < 0 || second >= 60 || second < 0 || minutes >= 60 || minutes < 0)
                return false;
            return true;
        }
        public bool Check12h()
        {
            if (hours >= 12 || hours < 0 || second >= 60 || second < 0 || minutes >= 60 || minutes < 0)
                return false;
            return true;
        }
        public void TangGio(int second)
        {
            int hours = second / 3600;
            int minute = (second % 3600) / 60;
            second -= (hours * 3600) - (minute * 60);
            //
            this.hours += hours;
            this.minutes += minute;
            this.second += second;
            //
            if (this.second >= 60)
            {
                this.second -= 60;
                this.minutes += 1;
            }
            if (this.minutes >= 60)
            {
                this.minutes -= 60;
                this.hours += 1;
            }
            this.hours = this.hours >= 24 ? this.hours - 24 : this.hours;

            Xuat24h();
        }
        public void TangGio(int second,string kieugio)
        {
            int hours = second / 3600;
            int minute = (second % 3600) / 60;
            second -= (hours * 3600) - (minute * 60);
            //
            this.hours += hours;
            this.minutes += minute;
            this.second += second;
            //
            if (this.second >= 60)
            {
                this.second -= 60;
                this.minutes += 1;
            }
            if (this.minutes >= 60)
            {
                this.minutes -= 60;
                this.hours += 1;
            }
            this.hours = this.hours >= 24 ? this.hours - 24 : this.hours;
            if (kieugio == "24")
            {
                Xuat24h();
            }
            else
            {
                Xuat12h();
            }
        }
        public void GiamGio(int second)
        {
            int hours = second / 3600;
            int minute = (second % 3600) / 60;
            second -= (hours * 3600) + (minute * 60);
            //
            this.hours -= hours;
            this.minutes -= minute;
            this.second -= second;
            //
            if (this.second <0 )
            {
                this.minutes -= 1;
                this.second += 60;
               
            }
            if (this.minutes < 0)
            {
                this.hours -= 1;
                this.minutes += 60;
                
            }
            this.hours = this.hours <0  ? this.hours + 24 : this.hours;

            Xuat24h();
        }
        public int Convert_Second()
        {
            return hours * 3600 + minutes * 60 + second;
        }
        public void GiamGio(int second,string kieugio)
        {
            int hours = second / 3600;
            int minute = (second % 3600) / 60;
            second -= (hours * 3600) - (minute * 60);
            //
            this.hours -= hours;
            this.minutes -= minute;
            this.second -= second;
            //
            if (this.second < 0)
            {
                this.minutes -= 1;
                this.second += 60;

            }
            if (this.minutes < 0)
            {
                this.hours -= 1;
                this.minutes += 60;

            }
            this.hours = this.hours < 0 ? this.hours + 24 : this.hours;
            if (kieugio == "24")
            {
                Xuat24h();
            }
            else
            {
                Xuat12h();
            }
        }
    }
}
