using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet3
{
    class DinhThucCap2
    {
        private int[,] matrix;

        public int[,] Matrix { get => matrix; set => matrix = value; }
        public DinhThucCap2()
        {
            matrix = new int[1,1];
        }
        public DinhThucCap2(int[,] matrix)
        {
            this.matrix = (int[,])matrix.Clone();
        }
        public DinhThucCap2(DinhThucCap2 temp)
        {
            this.matrix = (int[,])temp.matrix.Clone();
        }
        public void Nhap()
        {
            int n, m;
            bool check;
            do
            {
                Console.Write("mời bạn nhập số dòng: ");
                check = int.TryParse(Console.ReadLine(), out n);
                if (!check||n<=0)
                    Console.WriteLine("mời bạn nhập lại");
            } while (!check || n <= 0);
            do
            {
                Console.Write("mời bạn nhập số cột: ");
                check = int.TryParse(Console.ReadLine(), out m);
                if (!check || m <= 0)
                    Console.WriteLine("mời bạn nhập lại");
            } while (!check || m <= 0);
            matrix = new int[n, m];
            Random R= new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = R.Next(100) - 50;
                }
            }
        }
        public void Xuat()
        {
            Console.WriteLine("matrix: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
