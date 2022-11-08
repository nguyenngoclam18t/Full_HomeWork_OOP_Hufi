using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Tiet4
{
    class DSGV
    {
        private List<Giaovien> ds=new List<Giaovien>();

        public DSGV()
        {
        }
        public DSGV(List<Giaovien> ds)
        {
            this.ds = ds;
        }

        public List<Giaovien> DS
        {
            get => ds;
            set => ds = value;
        }
        public void Nhap(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNodeList ListFile = read.SelectNodes("/DanhSach/GV");
            foreach (XmlNode item in ListFile)
            {
                Giaovien gv = new Giaovien();
                gv.Name = item["Hoten"].InnerText;
                gv.Sonhom =int.Parse(item["SoNhom"].InnerText);
                ds.Add(gv);
            }
            
        }
        public void SortNhom()
        {
            ds = ds.OrderByDescending(S => S.Sonhom).ToList();
        }
        public void SortName()
        {
            ds = ds.OrderBy(S => S.Name).ToList();
        }
        public List<Giaovien> Filter()
        {
            return ds.Where(S => S.Sonhom>1).ToList();
        }
        public void Xuat()
        {
            foreach (Giaovien item in ds)
            {
                item.Xuat();
            }
        }
    }
}
