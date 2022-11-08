using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    class ThiSinh
    {
        private string sbd, ho, ten, loaichungchi;
        private int namsinh, cathi;

        public int Namsinh { get => namsinh; set => namsinh = value; }
        public int Cathi { get => cathi; set => cathi = value; }
        public string Sbd { get => sbd; set => sbd = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Loaichungchi { get => loaichungchi; set => loaichungchi = value; }
        public int Lephi
        {
            get
            {
                if (loaichungchi == "CCA")
                    return 200;
                return 300;
            }
        }
        public ThiSinh()
        {
            sbd = "BD01";
            ho = "Nguyễn Ngọc ";
            ten = "Lâm";
            loaichungchi = "CCA";
            namsinh = 2003;
            cathi = 1;
        }
        public ThiSinh(string sbd,string ho,string name,string loaichungchi,int namsinh,int cathi)
        {
            this.sbd = sbd;
            this.ho = ho;
            this.ten = name;
            this.loaichungchi = loaichungchi;
            this.namsinh = namsinh;
            this.cathi = cathi;
            if (loaichungchi != "CCA" && loaichungchi != "CCB_Access" && loaichungchi != "CCB_Autocab" && loaichungchi != "CCB_Excel")
                this.loaichungchi = "CCA";
        }
        public ThiSinh(ThiSinh temp)
        {
            this.sbd = temp.sbd;
            this.ho = temp.ho;
            this.ten =temp.ten;
            this.loaichungchi = temp.loaichungchi;
            this.namsinh = temp.namsinh;
            this.cathi = temp.cathi;
            if (loaichungchi != "CCA" && loaichungchi != "CCB_Access" && loaichungchi != "CCB_Autocab" && loaichungchi != "CCB_Excel")
                this.loaichungchi = "CCA";
        }
        public void Xuat()
        {
            Console.WriteLine("SBD: {0,-10} họ: {1,-15} tên: {2,-10} năm sinh: {3,-5} loại chứng chỉ: {4,-15} ca thi: {5,-5} lệ phí thi: {6,-5}", sbd, ho, ten, namsinh, loaichungchi, cathi, Lephi);
        }
    }
}
