using System;
using System.Collections.Generic;
using System.Text;
using collections.classInduk;

namespace collections.classAnak
{
    class sales : karyawan
    {
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }
        public override double Gaji()
        {
            return JumlahPenjualan * Komisi;
        }
    }
}
