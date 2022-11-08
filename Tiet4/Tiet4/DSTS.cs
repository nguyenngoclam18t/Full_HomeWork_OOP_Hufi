using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
namespace Tiet4
{
    class DSTS
    {
        private List<ThiSinh> ds = new List<ThiSinh>();
        public List<ThiSinh> DS{
            get => ds;
            set => ds = value;
        }

        public DSTS()
        {
        }

        public DSTS(List<ThiSinh> ds)
        {
            this.ds = ds;
        }

        public void Nhap(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNodeList listNode = read.SelectNodes("/DanhSach/ThiSinh");
            foreach (XmlNode item in listNode)
            {
                ThiSinh ts = new ThiSinh();
                ts.Sbd = item["SBD"].InnerText;
                ts.Name = item["HoTen"].InnerText;
                ts.Namsinh =  int.Parse(item["NamSinh"].InnerText);
                ts.Diemtoan =double.Parse(item["Toan"].InnerText);
                ts.Diemvan = double.Parse(item["Van"].InnerText);
                ts.Diemngoaingu = double.Parse(item["Anh"].InnerText);
                ds.Add(ts);
            }
        }
        public void Nhap(int sothisinh)
        {
            for (int i = 0; i < sothisinh; i++)
            {
                ThiSinh ts = new ThiSinh();
                ts.Nhap();
                ds.Add(ts);
            }
        }
        public void TongDiemDescending()
        {
            ds = ds.OrderByDescending(t => t.Tongdiem).ToList();
        }
        public void NameOderBy()
        {
            ds = ds.OrderBy(t => t.Name).ThenByDescending(t=>t.Diemtoan).ToList();
        }
        public List<ThiSinh> Filter_Complete()
        {
            return ds.Where(t => t.Ketqua == "đậu").ToList();
        }
        public List<ThiSinh> Filter_highScore()
        {
            return ds.Where(t => t.Namsinh>=1995||t.Diemtoan>=9).ToList();
        }
        public void Xuat()
        {
            foreach (ThiSinh item in ds)
            {
                item.Xuat();
            }
        }
    }
}
