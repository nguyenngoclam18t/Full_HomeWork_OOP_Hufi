using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace bai2
{
    class DSTS
    {
        private List<ThiSinh> ds = new List<ThiSinh>();
        internal List<ThiSinh> Ds { get => ds; set => ds = value; }
        public static void Check()
        {
            Console.WriteLine("hello");
        }
        public void nhap()
        {
            string linkfile = "../../../dsts.xml";
            XmlDocument read = new XmlDocument();
            read.Load(linkfile);
            XmlNodeList ListNode = read.SelectNodes("/DanhSach/ThiSinh");
            foreach (XmlNode item in ListNode)
            {
                ThiSinh ts = new ThiSinh();
                ts.Sbd = item["SBD"].InnerText;
                ts.Ho = item["Ho"].InnerText;
                ts.Ten = item["Ten"].InnerText;
                ts.Namsinh = int.Parse(item["NS"].InnerText);
                ts.Loaichungchi = item["LoaiCC"].InnerText;
                ts.Cathi = int.Parse(item["Ca"].InnerText);
                ds.Add(ts);
            }
        }
        public void xuat()
        {
            foreach (ThiSinh item in ds)
            {
                item.Xuat();
            }
        }
        public int TongTien()
        {
            int sum = 0;
            foreach (ThiSinh item in ds)
            {
                sum += item.Lephi;
            }
            return sum;
        }
        public int Soluong()
        {
            return ds.Count;
        }
        public void DS_CCA()
        {
            DSTS temp = new DSTS();
            temp.ds = new List<ThiSinh>(ds.Where(T => T.Loaichungchi == "CCA"));
            temp.xuat();
        }
        public void Sort()
        {
            ds = ds.OrderBy(t => t.Loaichungchi).ThenBy(t => t.Ten).ToList();
        }
        public void FindX(string sbd)
        {
            foreach (ThiSinh item in ds)
            {
                if (item.Sbd == sbd)
                    item.Xuat();
            }
        }
    }
}
