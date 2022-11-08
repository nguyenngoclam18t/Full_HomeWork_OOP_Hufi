using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Bai1
{
    class DanhSachKH
    {

        private List<KhoaHoc> ds=new List<KhoaHoc>();
        public DanhSachKH()
        {
            ds = new List<KhoaHoc>();
        }
        public DanhSachKH(List<KhoaHoc> New)
        {
            ds = new List<KhoaHoc>(New);
        }
        public List<KhoaHoc> Ds { get => ds; set => ds = value; }
        public void Nhap()
        {
            string linkfile = "../../../DSKH.xml";
            XmlDocument read = new XmlDocument();
            read.Load(linkfile);
            XmlNodeList ListNode = read.SelectNodes("/DanhSach/KhoaHoc");
            foreach (XmlNode item in ListNode)
            {
                KhoaHoc kh = new KhoaHoc();
                kh.Ma = item["Ma"].InnerText;
                kh.NameKh = item["Ten"].InnerText;
                kh.Sotiet = int.Parse(item["SoTiet"].InnerText);
                kh.Giohoc = item["GioHoc"].InnerText;
                kh.Sohocvien = int.Parse(item["SoLuongHV"].InnerText);
                kh.Giaovien = item["TenGV"].InnerText;
                ds.Add(kh);
            }
        }
        public void Xuat()
        {
            foreach (KhoaHoc item in ds)
            {
                item.Xuat();
            }
        }
        public double ThuDuoc()
        {
            double sum = 0;
            foreach (KhoaHoc item in ds)
            {
                sum += item.Hocphi;
                sum -= item.ThuLaoGV();
            }
            return sum;
        }
        public int TongLop()
        {
            return ds.Count;
        }
        public void after15()
        {
            DanhSachKH temp = new DanhSachKH(ds.Where(t => t.Sohocvien >= 15).ToList());
            temp.Xuat();
            
        }
        public int CountGV(string name)
        {
            int count = 0;
            foreach (KhoaHoc item in ds)
            {
                if (item.Giaovien == name)
                    count++;
            }
            return count;
        }
        public void SortHP()
        {
            DanhSachKH temp = new DanhSachKH(ds.OrderByDescending(t => t.Hocphi).ToList());
            temp.Xuat();
        }
        public void SortGioHoc()
        {
            DanhSachKH temp = new DanhSachKH(ds.OrderBy(t => t.Giohoc).ToList());
            temp.Xuat();
        }


    }
}
