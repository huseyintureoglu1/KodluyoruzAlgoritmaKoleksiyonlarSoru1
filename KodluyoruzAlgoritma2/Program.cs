using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodluyoruzAlgoritma2
{
    class Program
    {
        static void Main(string[] args)
        {
            KullaniciGirisi kullanici = new KullaniciGirisi();
            SanalDatabase data = new SanalDatabase();
            kullanici.KullaniciGirisiYap();
            Console.WriteLine();
            data.AsalOlmayanEkranaYazdir();
            Console.WriteLine();
            data.AsalSayiEkranaYazdir();
            Console.WriteLine();
            data.ElemanSayisi();
            data.AsalOrtalama();
            data.AsalOlmayanOrtalama();
            Console.ReadLine();

        }
    }
}
