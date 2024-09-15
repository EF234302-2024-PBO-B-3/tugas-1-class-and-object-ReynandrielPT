using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.Kendaraan
{
    public class Mobil
    {
        public string Merk;
        public string Model;
        public int TahunProduksi;

        public Mobil(string Brand, string Mod, int Date)
        {
            Merk = Brand;
            Model = Mod;
            TahunProduksi = Date;
        }

        public void TampilkanSpesifikasi()
        {
            Console.WriteLine($"Merk: {Merk}, Model: {Model}, Tahun Produksi: {TahunProduksi}");
        }
    }
}
