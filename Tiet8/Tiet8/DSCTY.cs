using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Tiet8
{
    class DSCTY
    {
        private List<CTY_T> ds = new List<CTY_T>();

        public List<CTY_T> DS { get => ds; set => ds = value; }

        public DSCTY(List<CTY_T> dS)
        {
            this.ds = dS;
        }

        public DSCTY()
        {
        }
        public void ReadFile(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNodeList listNode = read.SelectNodes("/DanhSach/NhanVien");
            foreach (XmlNode item in listNode)
            {
                string Cty = item["CTY"].InnerText;
                
                string name, ma;
                name = item["Ten"].InnerText;
                ma = item["Ma"].InnerText;
                if (Cty == "ABC")
                {
                    string loaiNV = item["LoaiNV"].InnerText;
                    string gioitinh = item["GioiTinh"].InnerText;
                    int namsinh = int.Parse(item["NamSinh"].InnerText);
                    double hesoluong = double.Parse(item["HeSoLuong"].InnerText);
                    int namvaolam = int.Parse(item["NamVaoLam"].InnerText);
                    switch (loaiNV)
                    {
                        case "NVSX":
                            {
                                int nghi= int.Parse(item["Nghi"].InnerText);
                                ds.Add(new NVSX(ma, name, namsinh, namvaolam, gioitinh, hesoluong, nghi));
                            }
                            break;
                        case "NVKD": {
                                int dstt = int.Parse(item["DSTT"].InnerText);
                                int dsbh = int.Parse(item["DSBH"].InnerText);
                                ds.Add(new NVKD(ma, name, namsinh, namvaolam, gioitinh, hesoluong,dstt,dsbh));
                            }
                            break;
                        case "CBQL":
                            {
                                string chucvu = item["ChucVu"].InnerText;
                                double heso = double.Parse(item["Heso"].InnerText);
                                ds.Add(new CBQL(ma, name, namsinh, namvaolam, gioitinh, hesoluong,chucvu,heso ));
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    double tongtien = double.Parse(item["TongTien"].InnerText);
                    ds.Add(new CTYBCD(ma, name, tongtien));
                }
                     
                
            }
        }
        public void Xuat()
        {
            foreach (CTY_T item in ds)
            {
                item.Xuat();
            }
        }
        public int CountDanhGia()
        {
            int count = 0;

            foreach (CTY_T item in ds)
            {
                if (item.DanhGiaNhanVien() == "năng lực tốt")
                    count++;
            }
            return count;
        }

        public void XuatChuaXet()
        {

            foreach (CTY_T item in ds)
            {
                if (item is CTYBCD)
                {
                    if (item.DanhGiaNhanVien() == "")
                        item.Xuat();
                }
                    
            }
        }
        public void XuatLDTT()
        {

            foreach (CTY_T item in ds)
            {
                if (item is CTYABC)
                {
                    if (item.Danhgia() == "lao động tiên tiến")
                        item.Xuat();
                }

            }
        }
    }
}
