using System;
using System.Collections.Generic;
using collections.classInduk;
using collections.classAnak;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawanTetap karyawanTetap = new karyawanTetap();
            karyawanTetap.Nik = "19.11.2737";
            karyawanTetap.Nama = "Immanuel";
            karyawanTetap.GajiBulanan = 10000000;

            karyawanHarian karyawanHarian = new karyawanHarian();
            karyawanHarian.Nik = "19.11.4343";
            karyawanHarian.Nama = "Paulus";
            karyawanHarian.JumlahJamKerja = 15;
            karyawanHarian.UpahPerJam = 55000;

            sales sales = new sales();
            sales.Nik = "19.11.7373";
            sales.Nama = "Claudio";
            sales.JumlahPenjualan = 50;
            sales.Komisi = 50000;

            List<karyawan> listKaryawan = new List<karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach(karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik : {1}, Nama : {2}, Gaji : {3:N0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
            }
        }
    }
}
