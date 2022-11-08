using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Tiet8
{
    class DSBDS
    {
        private List<BatDongSan> DS = new List<BatDongSan>();

        public List<BatDongSan> DS1 { get => DS; set => DS = value; }

        public DSBDS()
        {
        }

        public DSBDS(List<BatDongSan> dS)
        {
            DS = dS;
        }
        public void ReadFile(string name)
        {
            XmlDocument read = new XmlDocument();
            read.Load(name);
            XmlNodeList ListNode = read.SelectNodes("/BDSs/BDS");
            foreach (XmlNode item in ListNode)
            {
                int loai;
                string maso;
                double chieudai, chieurong;
                loai =int.Parse( item["Loai"].InnerText);
                maso = item["Ma"].InnerText;
                chieudai = double.Parse(item["Dai"].InnerText);
                chieurong = double.Parse(item["Rong"].InnerText);
                switch (loai)
                {
                    case 1:
                        {
                            DS.Add(new DatTrong(maso, chieurong, chieudai));
                        }break;
                    case 2:
                        {
                            int solau = int.Parse(item["SoLau"].InnerText);
                            DS.Add(new NhaO(maso, chieurong, chieudai, solau));
                        }break;
                    case 3:
                        {
                            int sosao = int.Parse(item["SoSao"].InnerText);
                            DS.Add(new KhachSan(maso, chieurong, chieudai, sosao));
                        }
                        break;
                    case 4: {
                            DS.Add(new BietThu(maso, chieurong, chieudai));
                        }
                        break;
                    default:
                        break;
                }
            }
            
        }
        public void Xuat()
        {
            foreach (BatDongSan item in DS)
            {
                item.Xuat();
                Console.WriteLine();
            }
        }
        public double TongChiPhi()
        {
            double sum = 0;
            foreach (BatDongSan item in DS)
            {
                sum += item.GiaBan();
            }
            return sum;
        }
        public double TongThue()
        {
            double sum = 0;
            foreach (BatDongSan item in DS)
            {
                if(item is Iphi)
                {
                    Iphi T = (Iphi)item;
                    sum += T.PhiKinhDoanh();
                }
            }
            return sum;
        }
    }
}
