using ClassAndObject.Kendaraan;
using ClassAndObject.OperasiMatematika;
using ClassAndObject.Perpustakaan;
using ClassAndObject.TokoLaptop;


using ClassAndObject.TokoSepeda;

namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Buku
            Buku buku = new Buku("Nama Buku", "Penulis Buku", 2021);
            buku.TampilkanInfo();


            // Kendaraan

            Mobil mobil = new Mobil("Ferrari", "Testarossa", 1984);
            mobil.TampilkanSpesifikasi();

            // Laptop

            Laptop laptop = new Laptop("Acer", "Ryzen 7 9000K", 128, 10000);
            laptop.TampilkanSpesifikasi();


            // Sepeda

            Sepeda sepeda = new Sepeda("BMX", "TDR 3000", 5);
            sepeda.TampilkanInformasi();

            // Kalkulator

            Kalkulator kalkulator = new Kalkulator();
            Console.WriteLine(kalkulator.Tambah(5, 5));
            Console.WriteLine(kalkulator.Kurang(6, 6));
            Console.WriteLine(kalkulator.Kali(7, 7));
            Console.WriteLine( kalkulator.Bagi(8, 8));

        }
    }
}
