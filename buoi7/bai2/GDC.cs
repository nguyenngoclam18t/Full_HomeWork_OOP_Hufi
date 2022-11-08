using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet7
{
    class GDC: ChungcuXYZ
    {
        private int sNKPVCT;
        public int SNKPVCT { get => sNKPVCT; set => sNKPVCT = value; }
        public override double SNPTT()
        {
            int SonuocTru = sNKPVCT * 10;
            if (KhoiNuocSD() < SonuocTru)
                return 0;
            return KhoiNuocSD() - SonuocTru;
        }
    }
}
