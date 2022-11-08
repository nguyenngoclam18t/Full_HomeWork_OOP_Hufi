using System;
using System.Collections.Generic;
using System.Text;

namespace bai5
{
    class Human
    {
        protected string name;
        protected DateTime ngaysinh;
        protected string gioitinh;

        public string Name { get => name; set => name = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { 
            get => gioitinh;
            set 
            {
                if (value != "nam" && value != "nu")
                    gioitinh = "nu";
                else
                    gioitinh = value;
            } 
        }
        public Human()
        {
            name = "";
            gioitinh = "nam";
        }
        public Human(string name,DateTime ngaysinh,string gioitinh)
        {
            this.name = name;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
        }
        public virtual void Xuat()
        {
            Console.Write("tên: {0,-15} ngày sinh {1,-10} giới tính: {2,-5}", name, ngaysinh.ToString("yyyy/MM/dd"), gioitinh);
        }
    }
}
