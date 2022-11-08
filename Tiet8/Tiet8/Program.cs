using System;

namespace Tiet8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int choice = -1;
            Menu temp = new Menu();
            do
            {
                temp.MenuBai();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            DSBDS DS = new DSBDS();
                            int luachon = -1;
                            do
                            {
                                temp.menuBai1();
                                luachon = int.Parse(Console.ReadLine());
                                switch (luachon)
                                {
                                    case 1:
                                        {
                                            DS.ReadFile("DSBDS.xml");
                                            Console.WriteLine("\t\tnhập thành công");
                                        }break;
                                    case 2:
                                        {
                                            DS.Xuat();
                                        }break;
                                    case 3:
                                        {
                                            Console.WriteLine("\t\ttổng chi phí là: " + DS.TongChiPhi());
                                        }break;
                                    case 4:
                                        {
                                            Console.WriteLine("\t\ttổng thuế là: " + DS.TongThue());
                                        }
                                        break;
                                    default:
                                        break;
                                }
                                Console.ReadKey();
                                Console.Clear();
                            } while (luachon!=0);
                        }
                        break;
                    case 2:
                        {
                            DSCTY DSNV = new DSCTY();
                            int luachon = -1;
                            do
                            {
                                temp.menuBai2();
                                luachon = int.Parse(Console.ReadLine());
                                switch (luachon)
                                {
                                    case 1:
                                        {
                                            DSNV.ReadFile("DSNV.xml");
                                            Console.WriteLine("đọc thành công");
                                        }
                                        break;
                                    case 2:
                                        {
                                            Console.WriteLine("xuất danh sách");
                                            DSNV.Xuat();
                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.WriteLine("có {0} nhân viên năng lực tốt", DSNV.CountDanhGia());
                                        }
                                        break;
                                    case 4:
                                        {
                                            Console.WriteLine("nhân viên BCD chưa được xét");
                                            DSNV.XuatChuaXet();
                                        }
                                        break;
                                    case 5:
                                        {
                                            Console.WriteLine("nhân viên lao động tiên tiến  công ty ABC ");
                                            DSNV.XuatLDTT();
                                        }
                                        break;
                                    default:
                                        break;
                                }
                                Console.ReadKey();
                                Console.Clear();
                            } while (luachon != 0);

                        
                }
                break;

                   
                    default:
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (choice!=0);
        }
    }
}
