using System;
using System.Collections.Generic;
using System.Text;
using collections.classInduk;

namespace collections.classAnak
{
    class karyawanTetap : karyawan
    {
        public double GajiBulanan { get; set; }

        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}
