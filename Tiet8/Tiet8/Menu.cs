using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet8
{
    class Menu
    {
        public void MenuBai()
        {
            Console.WriteLine("\t\tMenu");
            Console.WriteLine("\t\t1. bài 1");
            Console.WriteLine("\t\t2. bài 2");
            Console.WriteLine("\t\t3. bài 3");
            Console.WriteLine("\t\t4. bài 4");
            Console.WriteLine("\t\t0. thoát");
            Console.Write("\t\tnhập lựa chọn của bạn: ");
        }
        public void menuBai1()
        {
            Console.WriteLine("\t\tMenu");
            Console.WriteLine("\t\t1. đọc file XML");
            Console.WriteLine("\t\t2. Xuất DS");
            Console.WriteLine("\t\t3. Tổng phí ");
            Console.WriteLine("\t\t4. Tổng thuế");
            Console.WriteLine("\t\t0. thoát");
            Console.Write("\t\tnhập lựa chọn của bạn: ");
        }
        public void menuBai2()
        {
            Console.WriteLine("\t\tMenu");
            Console.WriteLine("\t\t1. đọc file XML");
            Console.WriteLine("\t\t2. Xuất DS");
            Console.WriteLine("\t\t3. đếm số nhân viên có năng lực tốt ");
            Console.WriteLine("\t\t4. xuất danh sách nhân viên chưa dc xét thi đua ở BCD");
            Console.WriteLine("\t\t5. xuất danh sách nhân viên lao động tiên tiến");
            Console.WriteLine("\t\t0. thoát");
            Console.Write("\t\tnhập lựa chọn của bạn: ");
        }
    }
}
