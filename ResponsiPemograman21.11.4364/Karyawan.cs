using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman21._11._4364
{
    class Karyawan
    {   // properties
        public string NAMA { get; set; }
        public string NIK { get; set; }
        public int GajiBulanan { get; set; }
        public int Gaji { get; set; }
        //constructor
        public Karyawan()
        {

        }
        // overload constructor 
        public Karyawan(string nama, string nik, int gajibulanan, int gaji)
        {
            NAMA = nama;
            NIK = nik;
            GajiBulanan = gajibulanan ;
        }
        
        
    }
}
