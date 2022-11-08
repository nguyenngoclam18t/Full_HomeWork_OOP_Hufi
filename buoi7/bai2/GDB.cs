using System;
using System.Collections.Generic;
using System.Text;

namespace Tiet7
{
    class GDB:ChungcuXYZ
    {
        public override double SNPTT()
        {
            if (KhoiNuocSD() < 20)
                return 0;
            return KhoiNuocSD() - 20;
        }
    }
}
