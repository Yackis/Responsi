using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lat
{
    internal class Karyawan
    {
        public string NIK { get; set; }
        public string Nama { get; set; }
        public float GajiBulanan { get; set; }
        public Karyawan(string nik, string nama, float gaji)
        {
            this.NIK = nik;
            this.Nama = nama;
            if (gaji < 0)
            {
                gaji = 0;
            }
            this.GajiBulanan = gaji;
        }

        public void NaikkanGaji(float persentase)
        {
            this.GajiBulanan = persentase / 100 * this.GajiBulanan + this.GajiBulanan;
        }

    }
}

