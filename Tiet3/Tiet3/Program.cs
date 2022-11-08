using System;
using System.Globalization;

namespace Tiet3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Menu menu = new Menu();
            int choice = -1;
            bool check = false;
            do
            {
                menu.MenuChinh();
                check = int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        {
                            bool test = false;
                            int luachon = -1;
                            So_phuc sp1 = new So_phuc();
                            do
                            {
                                menu.MenuSoPhuc();
                                test = int.TryParse(Console.ReadLine(), out luachon);
                                switch (luachon)
                                {
                                    case 1:
                                        {
                                            sp1.Nhap();
                                        }break;
                                    case 2:
                                        {
                                            sp1.Xuat();
                                        }break;
                                    case 3:
                                        {
                                            char calcu;
                                            Console.WriteLine("nhập số thứ 2 để thực hiện phép tính");
                                            So_phuc sp2 = new So_phuc();
                                            sp2.Nhap();
                                            Console.WriteLine("nhập phép tính bạn muốn làm: ");
                                            calcu = char.Parse(Console.ReadLine());
                                            So_phuc sp3 = new So_phuc();
                                            switch (calcu)
                                            {
                                                case '+':
                                                    {
                                                        sp3 = sp1 + sp2;
                                                    }break;
                                                case '-':
                                                    {
                                                        sp3 = sp1 - sp2;
                                                    }
                                                    break;
                                                default:
                                                    break;
                                            }
                                            sp3.Xuat();
                                        }
                                        break;
                                    case 4:
                                        {
                                            Console.WriteLine("nhập số thứ 2 để thực hiện phép tính");
                                            So_phuc sp2 = new So_phuc();
                                            sp2.Nhap();
                                            if (sp1 == sp2)
                                                Console.WriteLine("2 số bằng nhau");
                                            else
                                                Console.WriteLine("2 số không  bằng nhau");
                                        }
                                        break;
                                    default:
                                        break;
                                }

                                Console.ReadKey();
                                Console.Clear();
                            } while (luachon!=0||test==false);
                        }break;
                    case 2: {
                            bool test = false;
                            int luachon = -1;
                            PhanSo ps1 = new PhanSo();
                            do
                            {
                                menu.Menubai1();
                                test = int.TryParse(Console.ReadLine(), out luachon);
                                switch (luachon)
                                {
                                    case 1:
                                        {
                                            ps1.Nhap();
                                        }break;
                                    case 2:
                                        {
                                            ps1.Xuat();
                                        }break;
                                    case 3:
                                        {
                                            PhanSo ps2 = new PhanSo();
                                            PhanSo ps3 = new PhanSo();
                                            char calcu;
                                            Console.WriteLine("nhập phân số  thứ 2 để tính ");
                                            ps2.Nhap();
                                            Console.Write("nhập phép tính cần tính: ");
                                            calcu = char.Parse(Console.ReadLine());
                                            switch (calcu)
                                            {
                                                case '+':
                                                    ps3 = ps1 + ps2;
                                                    break;
                                                case '-':
                                                    ps3 = ps1 - ps2;
                                                    break;
                                                case '*':
                                                    ps3 = ps1 * ps2;
                                                    break;
                                                case '/':
                                                    ps3 = ps1 / ps2;
                                                    break;
                                                case '^':
                                                    {
                                                        int Mu = int.Parse(Console.ReadLine());
                                                        ps3 = ps1 ^ Mu;
                                                    }break;
                                                default:
                                                    break;
                                            }
                                            Console.Write("sau khi thực hiện phép tính là: ");
                                            ps3.Xuat();
                                            Console.WriteLine();
                                        }break;
                                    case 4:
                                        {
                                            PhanSo ps2 = new PhanSo();
                                            bool compare=false;
                                            string calcu;
                                            Console.WriteLine("nhập phân số  thứ 2 để tính ");
                                            ps2.Nhap();
                                            Console.Write("nhập phép so sánh: ");
                                            calcu = Console.ReadLine();
                                            switch (calcu)
                                            {
                                                case "!=":
                                                    compare = ps1 != ps2;
                                                    break;
                                                case "==":
                                                    compare = ps1 == ps2;
                                                    break;
                                                case ">":
                                                    compare = ps1 > ps2;
                                                    break;
                                                case "<":
                                                    compare = ps1 < ps2;
                                                    break;
                                                case ">=":
                                                    compare = ps1 >= ps2;
                                                    break;
                                                case "<=":
                                                    compare = ps1 <= ps2;
                                                    break;
                                                default:
                                                    break;
                                            }
                                            Console.WriteLine("phép tính vừa thực hiện trả về giá trị là " + compare);
                                            
                                        }
                                        break;
                                    case 5:
                                        {
                                            Console.WriteLine("sau khi ép kiểu là: " + (double)ps1);
                                        }break;
                                    case 6:
                                        {
                                            Console.WriteLine("sau khi ép kiểu là: " + (int)ps1);
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
                    case 3:
                        {
                            bool test = false;
                            int luachon = -1;
                            HonSo hs1 = new HonSo();
                            do
                            {
                                menu.Menubai2();
                                test = int.TryParse(Console.ReadLine(), out luachon);
                                switch (luachon)
                                {
                                    case 1:
                                        {
                                            hs1.nhap();
                                        }
                                        break;
                                    case 2:
                                        {
                                            hs1.xuat();
                                        }
                                        break;
                                    case 3:
                                        {
                                           HonSo hs2 = new HonSo();
                                            HonSo hs3 = new HonSo();
                                            char calcu;
                                            Console.WriteLine("nhập phân số  thứ 2 để tính ");
                                            hs2.nhap();
                                            Console.Write("nhập phép tính cần tính: ");
                                            calcu = char.Parse(Console.ReadLine());
                                            switch (calcu)
                                            {
                                                case '+':
                                                    hs3 = hs1 + hs2;
                                                    break;
                                                case '-':
                                                    hs3 = hs1 - hs2;
                                                    break;
                                                case '*':
                                                    hs3 = hs1 * hs2;
                                                    break;
                                                case '/':
                                                    hs3 = hs1 / hs2;
                                                    break;
                                                default:
                                                    break;
                                            }
                                            Console.Write("sau khi thực hiện phép tính là: ");
                                            hs3.xuat();
                                            Console.WriteLine();
                                        }
                                        break;
                                    case 4:
                                        {
                                            HonSo hs2 = new HonSo();
                                            bool compare = false;
                                            string calcu;
                                            Console.WriteLine("nhập phân số  thứ 2 để tính ");
                                            hs2.nhap();
                                            Console.Write("nhập phép so sánh: ");
                                            calcu = Console.ReadLine();
                                            switch (calcu)
                                            {
                                                case "!=":
                                                    compare = hs1 != hs2;
                                                    break;
                                                case "==":
                                                    compare = hs1 == hs2;
                                                    break;
                                                case ">":
                                                    compare = hs1 > hs2;
                                                    break;
                                                case "<":
                                                    compare = hs1 < hs2;
                                                    break;
                                                case ">=":
                                                    compare = hs1 >= hs2;
                                                    break;
                                                case "<=":
                                                    compare = hs1 <= hs2;
                                                    break;
                                                default:
                                                    break;
                                            }
                                            Console.WriteLine("phép tính vừa thực hiện trả về giá trị là " + compare);

                                        }
                                        break;
                                    case 5:
                                        {
                                            Console.WriteLine("sau khi ép kiểu là: " + (double)hs1);
                                        }
                                        break;
                                    case 6:
                                        {
                                            Console.WriteLine("nhập số thực để đổi: ");
                                            double sothuc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                            HonSo temp = (HonSo)sothuc;
                                            Console.Write("sau khi ép kiểu là: ");
                                            temp.xuat();
                                        }
                                        break;
                                    case 7:
                                        {
                                            PhanSo ps1 = new PhanSo();
                                            ps1 = (PhanSo)hs1;
                                            Console.Write("sau khi ép kiểu là: ");
                                            ps1.Xuat();
                                            Console.WriteLine();
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
                            bool test = false;
                            int luachon = -1;
                            TTD tiendien = new TTD();
                            do
                            {
                                menu.Menubai3();
                                test = int.TryParse(Console.ReadLine(), out luachon);
                                switch (luachon)
                                {
                                    case 1:
                                        tiendien.Nhap();
                                        break;
                                    case 2:
                                        tiendien.Xuat();
                                        break;
                                    default:
                                        break;
                                }
                            } while (luachon!=0||!test);
                        }
                        break;
                    case 5:
                        {
                            bool test = false;
                            int luachon = -1;
                            Point2D point = new Point2D();
                            do
                            {
                                menu.Menubai4();
                                test = int.TryParse(Console.ReadLine(), out luachon);
                                switch (choice)
                                {
                                    case 1:
                                        point.nhap();
                                        break;
                                    case 2:
                                        point.Xuat();
                                        break;
                                    case 3:
                                        {
                                            if (point.CheckTrucHoanh() == true)
                                                Console.WriteLine("đối xứng qua trục hoành");
                                            else
                                                Console.WriteLine("không đối xứng qua trục hoành");
                                            if (point.CheckTrucTung() == true)
                                                Console.WriteLine("đối xứng qua trục Tung");
                                            else
                                                Console.WriteLine("không đối xứng qua trục Tung");
                                        }
                                        break;
                                    case 4:
                                        {
                                            int tx, ty;
                                            Console.WriteLine("nhập tx: ");
                                            tx = int.Parse(Console.ReadLine());
                                            Console.WriteLine("nhập ty: ");
                                            ty = int.Parse(Console.ReadLine());
                                            point.thayDoivitri(tx, ty);
                                            Console.WriteLine("sau khi tăng: ");
                                            point.Xuat();
                                        }
                                        break;
                                    case 5:
                                        {
                                            Console.WriteLine("khoảng cách là ", point.tinhKhoangCach());
                                        }break;
                                    case 6:
                                        {
                                            Point2D Tung, Hoanh, Newpoint = new Point2D();
                                            Console.WriteLine("nhập x y mới: ");
                                            Newpoint.nhap();
                                            Tung = point.doiXungQuaTrucTung(Newpoint);
                                            Hoanh = point.doiXungQuaTrucHoanh(Newpoint);
                                            Console.WriteLine("đối xứng qua trục tung: ");
                                            Tung.Xuat();
                                            Console.WriteLine("đối xứng qua trục hoanh: ");
                                            Hoanh.Xuat();
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            } while (luachon != 0 || !test);
                        }
                        break;
                    case 6:
                        {
                            bool test = false;
                            int luachon = -1;
                            DinhThucCap2 cap2 = new DinhThucCap2();
                            do
                            {
                                menu.Menubai5();
                                test = int.TryParse(Console.ReadLine(), out luachon);
                                switch (luachon)
                                {
                                    case 1:
                                        cap2.Nhap();
                                        break;
                                    case 2:
                                        cap2.Xuat();
                                        break;
                                    default:
                                        break;
                                }
                            } while (luachon != 0 || !test);
                        }
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (choice!=0||check==false);
        }
    }
}
