using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.TokoLaptop
{
    public class Laptop
    {
        public string Merk;
        public string Prosesor;
        public int Ram;
        public int Penyimpanan;
        public Laptop(string Brand, string Proc, int Memori, int Data)
        {
            Merk = Brand;
            Prosesor = Proc;
            Ram = Memori;
            Penyimpanan = Data;
        }

        public void TampilkanSpesifikasi()
        {
            Console.WriteLine($"Merk: {Merk}, Prosesor: {Prosesor}, RAM: {Ram} GB, Penyimpanan: {Penyimpanan} GB");
        }
    }
}
