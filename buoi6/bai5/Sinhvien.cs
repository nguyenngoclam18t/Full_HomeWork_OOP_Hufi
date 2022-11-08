using System;
using System.Collections.Generic;
using System.Text;

namespace bai5
{
    class Sinhvien:Human
    {
        private string maso, hedaotao;
        private int tongsotinchi;

        public string Maso { get => maso; set => maso = value; }
        public string Hedaotao { get => hedaotao; set => hedaotao = value; }
        public int Tongsotinchi {
            get
            {
                if (hedaotao != "đại học")
                    return tongsotinchi= 150;
                else if (hedaotao != "cao đẳng")
                    return tongsotinchi= 100;
                else
                    return tongsotinchi=130;
            }
            
        }
        public Sinhvien(string name,DateTime ngaysinh,string gioitinh,string maso,string hedaotao)
            :base(name, ngaysinh, gioitinh)
        {
            this.maso = maso;
            this.hedaotao = hedaotao;
            if (hedaotao != "cao đẳng" && hedaotao != "đại học" && hedaotao != "cao đẳng nghề")
                this.hedaotao = "đại học";
        }
        public double HPTinchi()
        {
            if (hedaotao != "cao đẳng")
                return 150000;
            else if (hedaotao == "đại học")
                return 200000;
            return 120000;
        }
        public double TinhTien()
        {
            return tongsotinchi * HPTinchi();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("mã số: {0,-20} hệ đào tạo: {1,-20} tổng số tín chỉ: {2,-20} tổng tiền: {3,-10}", maso, hedaotao, Tongsotinchi,TinhTien());
        }

    }
}
