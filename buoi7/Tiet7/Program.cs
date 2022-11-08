using System;

namespace Tiet7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int choice = -1;
            Menu menu = new Menu();
            do
            {
                menu.menu();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            NVXS nvxs = new NVXS();
                            NVKD nvkd = new NVKD();
                            CBQL ql = new CBQL();
                            int luachon = -1;
                            do
                            {
                                menu.menuNV();
                                luachon = int.Parse(Console.ReadLine());
                                switch (luachon)
                                {
                                    case 1:
                                        {
                                            nvxs.Nhap();
                                            nvxs.Xuat();
                                        }break;
                                    case 2:
                                        {
                                            nvkd.Nhap();
                                            nvkd.Xuat();
                                        }break;
                                    case 3:
                                        {
                                            ql.Nhap();
                                            ql.Xuat();
                                        }break;
                                    case 4: 
                                        {
                                            double sum = nvxs.thuNhap() + nvkd.thuNhap() + ql.thuNhap();
                                            Console.WriteLine("tổng thu nhập của toàn bộ nhân viên là: " + sum);

                                        }break;
                                    default:
                                        break;
                                }
                            } while (luachon!=0);



                           
                        }break;
                    case 2:
                        {
                            GDA a = new GDA();
                            GDB b = new GDB();
                            GDC c = new GDC();
                            int luachon = -1;
                            do
                            {
                                menu.menuHGD();
                                luachon = int.Parse(Console.ReadLine());
                                switch (luachon)
                                {
                                    case 1:
                                        {
                                            a.Nhap();
                                            a.Xuat();
                                        }
                                        break;
                                    case 2:
                                        {
                                            b.Nhap();
                                            b.Xuat();
                                        }
                                        break;
                                    case 3:
                                        {
                                            c.Nhap();
                                            c.Xuat();
                                        }
                                        break;
                                    
                                    default:
                                        break;
                                }
                            } while (luachon != 0);
                        }
                        break;
                    case 3:
                        {
                            DSMH temp = new DSMH();
                            temp.ReadFile("DsMH.xml");
                            temp.Xuat();
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
