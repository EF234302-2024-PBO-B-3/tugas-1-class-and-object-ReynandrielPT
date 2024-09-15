using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.TokoSepeda
{
    public class Sepeda
    {
        public string Merk;
        public string Tipe;
        public double Berat;
       
        public Sepeda(string Brand, string Type, double Weight)
        {
            Merk = Brand;
            Tipe = Type;
            Berat = Weight;
       
        }

        public void TampilkanInformasi()
        {
            Console.WriteLine($"Merek: {Merk}, Tipe: {Tipe}, Berat: {Berat.ToString(CultureInfo.CreateSpecificCulture("en-GB"))} kg");
        }
    }
}
