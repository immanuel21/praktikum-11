using System;
using System.Collections.Generic;
using System.Text;
using collections.classInduk;

namespace collections.classAnak
{
    class karyawanHarian : karyawan
    {
        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }
        public override double Gaji()
        {
            return UpahPerJam * JumlahJamKerja;
        }
    }
}
