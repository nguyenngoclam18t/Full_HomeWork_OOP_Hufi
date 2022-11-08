using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet4
{
    class Giaovien
    {
        private string name;
        private int sonhom;

        public string Name { get => name; set => name = value; }
        public int Sonhom { get => sonhom; set => sonhom = value; }
        public void Xuat()
        {
            Console.WriteLine( "{0,-20}: {1,3}",name,sonhom);
        }
    }
}
