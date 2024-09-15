using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.Perpustakaan
{
    public class Buku
    {
        public string Judul;
        public string Penulis;
        public int TahunTerbit;

        public Buku(string Title, string Writer, int Date) { 
        Judul = Title;
        Penulis = Writer;
        TahunTerbit= Date;
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"Judul: {Judul}, Penulis: {Penulis}, Tahun Terbit: {TahunTerbit}");
        }
    }
}
