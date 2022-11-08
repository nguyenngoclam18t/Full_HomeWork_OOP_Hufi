using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet4
{
    class Menu
    {
        public void MenuTiet4()
        {
            Console.WriteLine("\t\tMenu");
            Console.WriteLine("\t\t1.bài 1");
            Console.WriteLine("\t\t2.bài 2");
            Console.WriteLine("\t\t3.bài 3");
            Console.WriteLine("\t\t4.bài 4");
            Console.WriteLine("\t\t0.out");
            Console.Write("\t\tnhập lựa chọn của bạn: ");
        }
        public void MenuBai1()
        {
            Console.WriteLine("\t\tMenu");
            Console.WriteLine("\t\t1.nhập file xml");
            Console.WriteLine("\t\t2.xuất danh sách");
            Console.WriteLine("\t\t3.sort tăng dần theo tên");
            Console.WriteLine("\t\t4.sort giảm dần theo số nhóm");
            Console.WriteLine("\t\t5.danh sách giáo viên có nhóm lớn hơn 1");
            Console.WriteLine("\t\t0.out");
            Console.Write("\t\tnhập lựa chọn của bạn: ");
        }
        public void MenuBai4()
        {
            Console.WriteLine("\t\tMenu");
            Console.WriteLine("\t\t1.nhập file xml");
            Console.WriteLine("\t\t2.xuất danh sách");
            Console.WriteLine("\t\t3.xuất theo từng nhóm hệ số thi đua");
            Console.WriteLine("\t\t4.lấy danh sách nhân viên theo phòng ban x");
            Console.WriteLine("\t\t5.lấy danh sách nhân viên có chức vụ lãnh đạo");
            Console.WriteLine("\t\t6.tổng lương phải trả");
            Console.WriteLine("\t\t7.loại bỏ nhân viên có số ngày làm nhỏ hơn 10 trong danh sách");
            Console.WriteLine("\t\t8.lấy danh sách nhân viên ko phải lãnh đọa mà có số ngày làm việc lớn hơn 22");
            Console.WriteLine("\t\t9.lấy danh sách nhân viên có hệ số lương từ 4.34 và ở phòng tài vụ");
            Console.WriteLine("\t\t0.out");
            Console.Write("\t\tnhập lựa chọn của bạn: ");
        }
        public void MenuBai2()
        {
            Console.WriteLine("\t\tMenu");
            Console.WriteLine("\t\t1.nhập file xml");
            Console.WriteLine("\t\t2.xuất danh sách");
            Console.WriteLine("\t\t3.lấy danh sách đậu");
            Console.WriteLine("\t\t4.danh sách thí sinh có năm sinh >1955 hoặc có điểm toán trên 9");
            Console.WriteLine("\t\t5.sort tổng điểm giảm dần");
            Console.WriteLine("\t\t6.sort theo tên");
            Console.WriteLine("\t\t0.out");
            Console.Write("\t\tnhập lựa chọn của bạn: ");
        }
    }
}
