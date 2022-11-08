using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Tiet4
{
    class DSNV
    {
        private List<NhanVien> ds = new List<NhanVien>();

        public DSNV(List<NhanVien> ds)
        {
            this.ds = ds;
        }

        public DSNV()
        {
        }

        public List<NhanVien> Ds { get => ds; set => ds = value; }
        public void Nhap(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNodeList ListNode = read.SelectNodes("/DanhSach/NhanVien");
            foreach (XmlNode item in ListNode)
            {
                NhanVien Nv = new NhanVien();
                Nv.MaNhanVien = item["MaSo"].InnerText;
                Nv.Name = item["Name"].InnerText;
                Nv.Phongban = item["PhongBan"].InnerText;
                Nv.Chucvu = item["ChucVu"].InnerText;
                Nv.Hesoluong = double.Parse(item["HeSoLuong"].InnerText);
                Nv.Songaylamviec = int.Parse(item["SoNgayLamViec"].InnerText);
                Nv.Thamniencongtac = int.Parse(item["ThamNienCongTac"].InnerText);
                ds.Add(Nv);
            }
        }
        public void Xuat()
        {
            foreach (NhanVien item in ds)
            {
                item.Xuat();
            }
        }
        public void SortPhongBan()
        {
            ds = ds.OrderBy(t => t.Phongban).ToList();
        }
        public List<NhanVien> LayDStheoTen(string name)
        {
            return ds.Where(t => t.Phongban == name).ToList();
        }
        public List<NhanVien> LayDSLanhDao()
        {
            return ds.Where(t => t.Chucvu == "Lãnh đạo").ToList();
        }
        public double TongLuong()
        {
            Double sum = 0;
            foreach (NhanVien item in ds)
            {
                sum += item.Luong();
            }
            return sum;
        }
        public List<NhanVien> LayDStren10ngay()
        {
            return ds.Where(t => t.Songaylamviec >10).ToList();
        }
        public List<NhanVien> LayDStren22ngay()
        {
            return ds.Where(t => t.Songaylamviec > 22&&t.Chucvu!="Lãnh đạo").ToList();
        }
        public List<NhanVien> LayDSTaiVu()
        {
            return ds.Where(t => t.Hesoluong > 3.34 && t.Phongban == "Tài Vụ").ToList();
        }

    }
}
