using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet2
{
    class athletes
    {
        private string maso, hoten, soao;
        private Time begin,end;
        private static Time Thoigianchuan = new Time(1, 30, 0);
        private Time thanhtich;

        public string Maso { get => maso; set => maso = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Soao { get => soao; set => soao = value; }
        public athletes()
        {
            maso=hoten=soao = "";
            begin = new Time();
            end = new Time();
        }
        public athletes(string maso,string hoten,string soao,int begin_hours,int begin_minute,int begin_second, int end_hours, int end_minute, int end_second)
        {
            this.maso = maso;
            this.hoten = hoten;
            this.soao = soao;
            begin = new Time(begin_hours, begin_minute,begin_second);
            end = new Time(end_hours, end_minute, end_second);
        }
        public athletes(athletes temp)
        {
            this.maso = temp.maso;
            this.hoten = temp.hoten;
            this.soao = temp.soao;
            begin = new Time(temp.begin);
            end = new Time(temp.end);
            end = new Time(temp.end);
        }
        
        public void Nhap()
        {
            Console.Write("mời bạn nhập tên: ");
            hoten=Console.ReadLine();
            Console.Write("mời bạn mã số: ");
            maso = Console.ReadLine();
            Console.Write("mời bạn số áo: ");
            soao = Console.ReadLine();
            Console.WriteLine("mời bạn nhập giờ bắt đầu: ");
            begin.Nhap24h();
            Console.WriteLine("mời bạn giờ kết thúc: ");
            end.Nhap24h();
            thanhtich = new Time(end);
            int second = begin.Convert_Second();
            thanhtich.GiamGio(second);
        }
        public bool checkEnd()
        {
            return end.Check24h();
        }
        public bool checkBegin()
        {
            return begin.Check24h();
        }
        public string Fail()
        {
            string answer = "đạt";
            if (thanhtich.Hours > athletes.Thoigianchuan.Hours)
                answer = "không đạt";
            else if (thanhtich.Hours == athletes.Thoigianchuan.Hours)
            {
                if (thanhtich.Minutes > athletes.Thoigianchuan.Minutes)
                {
                    answer = "không đạt";
                }
                else if (thanhtich.Minutes == athletes.Thoigianchuan.Minutes)
                {
                    if (thanhtich.Second > athletes.Thoigianchuan.Second)
                        answer = "không đạt";
                }
            }
            return answer;
        }
        public void Xuat()
        {
            string answer = Fail();
            Console.WriteLine($" Họ tên:{hoten} \t mã số:{maso}\t số áo: {soao}\t");
            Console.Write($" thời gian bắt đầu: "); begin.Xuat24h();
            Console.Write($" thời gian kết thúc: "); end.Xuat24h();
            Console.Write($" thời gian thành tích: "); thanhtich.Xuat24h();
            Console.WriteLine("kết quả: " + answer);

        }
    }
}
