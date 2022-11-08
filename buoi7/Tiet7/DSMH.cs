using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Tiet7
{
    class DSMH
    {
        private List<MonHoc> DS = new List<MonHoc>();

        public DSMH()
        {
        }
        public DSMH(List<MonHoc> dS)
        {
            DS = dS;
        }

        public List<MonHoc> DS1 { get => DS; set => DS = value; }
        public void ReadFile(string linkfile)
        {
            XmlDocument read = new XmlDocument();
            read.Load(linkfile);
            XmlNodeList ListNode = read.SelectNodes("/MonHoc/MH");
            string loai;
            foreach (XmlNode item in ListNode)
            {
                loai = item["Loai"].InnerText;
                string ma = item["Ma"].InnerText;
                string tenmon = item["Ten"].InnerText;
                int tinchi = int.Parse(item["SoTC"].InnerText);
                switch (loai)
                {
                    case "Mon Ly Thuyet":
                        {
                            double TieuLuan = double.Parse(item["DiemTL"].InnerText);
                            double GK = double.Parse(item["DiemGK"].InnerText);
                            double CK = double.Parse(item["DiemCK"].InnerText);
                            DS.Add(new LT(ma, tenmon, tinchi, TieuLuan, GK, CK));
                        }
                        break;
                    case "Mon Thuc Hanh":
                        {
                            double KT1 = double.Parse(item["KT1"].InnerText);
                            double KT2 = double.Parse(item["KT2"].InnerText);
                            double KT3 = double.Parse(item["KT3"].InnerText);
                            double KT4 = double.Parse(item["KT4"].InnerText);
                            DS.Add(new TH(ma, tenmon, tinchi, KT1,KT2,KT3,KT4));
                        }
                        break;
                    case "Mon Do An":
                        {
                            double GVHD = double.Parse(item["DiemGVHD"].InnerText);
                            double GVPD = double.Parse(item["DiemGVPB"].InnerText);
                            DS.Add(new DA(ma, tenmon, tinchi,GVHD,GVPD));
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        public void Xuat()
        {
            foreach (MonHoc item in DS)
            {
                item.Xuat();
            }
        }
    }
}
