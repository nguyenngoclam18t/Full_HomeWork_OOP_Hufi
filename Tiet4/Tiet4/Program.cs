using System;

namespace Tiet4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int choice = -1;
            bool check;
            Menu menu = new Menu();
            do
            {
                menu.MenuTiet4();
                check = int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        {
                            int luachon = -1;
                            bool test = false;
                            DSGV ds = new DSGV();
                            do
                            {
                                menu.MenuBai1();
                                test = int.TryParse(Console.ReadLine(), out luachon);
                                switch (luachon)
                                {
                                    case 1:
                                        {
                                            ds.Nhap("dsgv.xml");
                                            Console.WriteLine("nhập thành công");
                                        }break;
                                    case 2:
                                        {
                                            ds.Xuat();
                                        }break;
                                    case 3:
                                        {
                                            ds.SortName();
                                            Console.WriteLine("danh sách sau khi sort là ");
                                            ds.Xuat();
                                        }
                                        break;
                                    case 4:
                                        {
                                            ds.SortNhom();
                                            Console.WriteLine("danh sách sau khi sort là ");
                                            ds.Xuat();
                                        }
                                        break;
                                    case 5:
                                        {
                                            DSGV Newtemp = new DSGV(ds.Filter());
                                            Console.WriteLine("danh sách sau khi lọc là ");
                                            Newtemp.Xuat();
                                        }
                                        break;
                                    default:
                                        break;
                                }
                                Console.ReadKey();
                                Console.Clear();
                            } while (luachon!=0||test==false);
                        }break;
                    case 2:
                        {
                            int luachon = -1;
                            bool test;
                            DSTS ds = new DSTS();
                            do
                            {
                                menu.MenuBai2();
                                test = int.TryParse(Console.ReadLine(), out luachon);
                                switch (luachon)
                                {
                                    case 1:
                                        {
                                            ds.Nhap("dsts.xml");
                                            Console.WriteLine("nhập thành công");
                                        }break; 
                                    case 2:
                                        {
                                            ds.Xuat();
                                        }break;
                                    case 3:
                                        {
                                            DSTS temp = new DSTS(ds.Filter_Complete());
                                            Console.WriteLine("danh sách thí sinh đậu là");
                                            temp.Xuat();
                                        }break;
                                    case 4:
                                        {
                                            DSTS temp = new DSTS(ds.Filter_highScore());
                                            Console.WriteLine("danh sách thí sinh điểm cao hoặc lớn hơn 1995 là");
                                            temp.Xuat();
                                        }
                                        break;
                                    case 5:
                                        {
                                            ds.TongDiemDescending();
                                            Console.WriteLine("danh sách sau khi sort là");
                                            ds.Xuat();
                                        }
                                        break;
                                    case 6:
                                        {
                                            ds.NameOderBy();
                                            Console.WriteLine("danh sách sau khi sort là");
                                            ds.Xuat();
                                        }
                                        break;
                                    default:
                                        break;
                                }

                                Console.ReadKey();
                                Console.Clear();
                            } while (luachon != 0 || test == false);
                        }
                        break;
                    case 4:
                        {
                            int luachon = -1;
                            bool test;
                            DSNV ds = new DSNV();
                            do
                            {
                                menu.MenuBai4();
                                test = int.TryParse(Console.ReadLine(), out luachon);
                                switch (luachon)
                                {
                                    case 1:
                                        {
                                            ds.Nhap("DSNV.xml");
                                            Console.WriteLine("nhập thành công");
                                        }break;
                                    case 2:
                                        {
                                            ds.Xuat();
                                        }break;
                                    case 3:
                                        {
                                            ds.SortPhongBan();
                                            Console.WriteLine("danh sách nhân viên sắp xếp theo phòng ban");
                                            ds.Xuat();
                                        }break;
                                    case 4:
                                        {
                                            string X;
                                            Console.Write("nhập phòng ban: ");
                                            X = Console.ReadLine();
                                            DSNV temp = new DSNV(ds.LayDStheoTen(X));
                                            Console.WriteLine("danh sách nhân viên theo phòng ban X");
                                            temp.Xuat();
                                        }
                                        break;
                                    case 5:
                                        {
                                            DSNV temp = new DSNV(ds.LayDSLanhDao());
                                            Console.WriteLine("danh sách Lãnh đạo");
                                            temp.Xuat();
                                        }
                                        break;
                                    case 6:
                                        {
                                            Console.WriteLine("tổng lương phải trả là: " + ds.TongLuong());
                                        }
                                        break;
                                    case 7:
                                        {
                                            DSNV temp = new DSNV(ds.LayDStren10ngay());
                                            Console.WriteLine("danh sách sau khi loại bỏ là");
                                            temp.Xuat();
                                        }
                                        break;
                                    case 8:
                                        {
                                            DSNV temp = new DSNV(ds.LayDStren22ngay());
                                            Console.WriteLine("danh sách làm việc trên 22 ngày ");
                                            temp.Xuat();
                                        }
                                        break;
                                    case 9:
                                        {
                                            DSNV temp = new DSNV(ds.LayDSTaiVu());
                                            Console.WriteLine("danh sách phòng ban tài vụ và lương từ 4.34 ");
                                            temp.Xuat();
                                        }
                                        break;
                                    default:
                                        break;
                                }

                                Console.ReadKey();
                                Console.Clear();
                            } while (luachon!=0||test==false);
                        }break;
                    default:
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (choice!=0||check==false);
           
        }
    }
}
