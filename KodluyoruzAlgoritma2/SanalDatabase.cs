using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodluyoruzAlgoritma2
{
   public class SanalDatabase
    {
        public static ArrayList asal = new ArrayList();
        public static ArrayList asalOlmayan = new ArrayList();
        public void AsalSayiEkle(int sayi)
        {
            asal.Add(sayi);
        }
        public void AsalOlmayanEkle(int sayi)
        {
            asalOlmayan.Add(sayi);
        }
        public void AsalSayiEkranaYazdir()
        {
            asal.Sort();
            asal.Reverse();
            Console.Write("Asal olanlar: ");
            foreach (int item in asal)
            {
                Console.Write(item+",");
            
            }
        }
        public void ElemanSayisi()
        {
            Console.WriteLine();
            Console.WriteLine("Asal olan toplam sayısı: " + asal.Count);
            Console.WriteLine("Asal olmayan eleman sayısı: " + asalOlmayan.Count);
        }
        public void AsalOrtalama()
        {
            double toplam = 0;
            foreach (int item in asal)
            {
                toplam =toplam+Convert.ToDouble(item);
            }
            Console.WriteLine();
            Console.WriteLine("Asal olanların ortalaması :" + toplam/asal.Count);
        }
        public void AsalOlmayanOrtalama()
        {
            double toplam = 0;
            foreach (int item in asalOlmayan)
            {
                toplam = toplam + Convert.ToDouble(item);
            }
            Console.WriteLine("Asal olmayanların ortalaması :" + toplam / asal.Count);
        }
        public void AsalOlmayanEkranaYazdir()
        {
            asalOlmayan.Sort();
            asalOlmayan.Reverse();
            Console.Write("Asal olmayanlar :");
            foreach (int item in asalOlmayan)
            {
                Console.Write(item+",");
              
            }
            
        }

    }
}
