using System;

namespace Tiet2
{
    class tiet2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int choice = -1;
            bool check = false;
            Menu temp = new Menu();
            do
            {
                temp.Menubuoi2();
                check = int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {

                    case 1:
                        {
                            bool test = false;
                            int luachon = -1;
                            NGK ngk = new NGK();
                            do
                            {
                                temp.Menubai4();
                                test = int.TryParse(Console.ReadLine(), out luachon);
                                switch (luachon)
                                {
                                    case 1:
                                        {
                                            ngk.Nhap();
                                        }
                                        break;
                                    case 2:
                                        {
                                            ngk.Xuat();
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            } while (luachon != 0);
                        }
                        break;
                    case 2:
                        {
                            bool test = false;
                            int luachon = -1;
                            HCN hcn = new HCN();
                            do
                            {
                                temp.Menubai4();
                                test = int.TryParse(Console.ReadLine(), out luachon);
                                switch (luachon)
                                {
                                    case 1:
                                        {
                                            hcn.nhap();
                                        }break;
                                    case 2:
                                        {
                                            hcn.xuat();
                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.WriteLine("chu vi: {0,-10} diện tích: {1,-10} diện tích đường chéo: {2,-10}", hcn.chuvi(), hcn.dientich(), hcn.DCC());
                                        }
                                        break;
                                    case 4:
                                        {
                                            int tx, ty;
                                            Console.WriteLine(" nhập tx: ");
                                            tx = int.Parse(Console.ReadLine());
                                            Console.WriteLine(" nhập ty: ");
                                            ty = int.Parse(Console.ReadLine());
                                            Console.WriteLine("sau khi tăng");
                                            hcn.ChangeSize(tx, ty, 1);
                                        }
                                        break;
                                    case 5:
                                        {
                                            HCN New = new HCN();
                                            New.nhap();
                                            hcn.ChangeSize(New, 1);
                                            Console.WriteLine("sau khi tăng");
                                            hcn.xuat();
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            } while (luachon!=0);
                        }break;
                    case 3:
                        {
                            bool test = false;
                            int luachon = -1;
                            Time time = new Time();
                            do
                            {
                                temp.Menubai4();
                                test = int.TryParse(Console.ReadLine(), out luachon);
                                switch (luachon)
                                {
                                    case 1:
                                        {
                                            time.Nhap12h();
                                        }
                                        break;
                                    case 2:
                                        {
                                            time.Nhap24h();
                                        }
                                        break;
                                    case 3:
                                        {
                                            time.Xuat12h();
                                        }
                                        break;
                                    case 4:
                                        {
                                            time.Xuat24h();
                                        }
                                        break;
                                    case 5:
                                        {
                                            int second;
                                            Console.WriteLine("nhập số giây: ");
                                            second = int.Parse(Console.ReadLine());
                                            time.TangGio(second,"24");
                                            Console.WriteLine("giờ sau khi tăng là");
                                            time.Xuat24h();
                                        }
                                        break;
                                    case 6:
                                        {
                                            int second;
                                            Console.WriteLine("nhập số giây: ");
                                            second = int.Parse(Console.ReadLine());
                                            time.TangGio(second, "12");
                                            Console.WriteLine("giờ sau khi tăng là");
                                            time.Xuat12h();
                                        }
                                        break;
                                    case 7:
                                        {
                                            int second;
                                            Console.WriteLine("nhập số giây: ");
                                            second = int.Parse(Console.ReadLine());
                                            time.GiamGio(second, "24");
                                            Console.WriteLine("giờ sau khi giảm là");
                                            time.Xuat24h();
                                        }
                                        break;
                                    case 8:
                                        {
                                            int second;
                                            Console.WriteLine("nhập số giây: ");
                                            second = int.Parse(Console.ReadLine());
                                            time.GiamGio(second, "12");
                                            Console.WriteLine("giờ sau khi giảm là");
                                            time.Xuat12h();
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            } while (luachon != 0);
                        }
                        break;
                    case 4:
                        {
                            bool test = false;
                            int luachon = -1;
                            athletes vdv = new athletes();
                            do
                            {
                                temp.Menubai6();
                                test = int.TryParse(Console.ReadLine(), out luachon);
                                switch (luachon)
                                {
                                    case 1:
                                        {
                                            vdv.Nhap();
                                        }
                                        break;
                                    case 2:
                                        {
                                            vdv.Xuat();
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            } while (luachon != 0);
                        }
                        break;
                    default:
                        break;
                }

            } while (choice!=0||check==false);
        }
    }
   
}
