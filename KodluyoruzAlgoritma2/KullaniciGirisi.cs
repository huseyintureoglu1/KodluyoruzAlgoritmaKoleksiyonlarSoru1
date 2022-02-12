using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodluyoruzAlgoritma2
{
   public  class KullaniciGirisi
    {
        int sayac = 0;
        SanalDatabase database = new SanalDatabase();
        public void KullaniciGirisiYap()
        {
            try
            {
              
                while (sayac<20)
                {
                    Console.WriteLine("Lütfen sayi giriniz:");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi > 0)
                    {
                        int sonuc=asalMı(sayi);
                        if (sonuc==0)
                        {
                            database.AsalSayiEkle(sayi);
                           // Console.WriteLine("asal");

                        }
                        else
                        {
                            database.AsalOlmayanEkle(sayi);
                         //   Console.WriteLine("asal değil");
                        }
                        sayac++;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen pozitif sayi giriniz.");
                    }
                }
               
            }
            catch (Exception)
            {

                Console.WriteLine("Lütfen formata uygun sayi giriniz");
                KullaniciGirisiYap();
            }
          
            Console.ReadLine();
        }
        public int asalMı(int sayi)
        {
            int sonuc = 0;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi%i==0)
                {
                    
                    sonuc = 1;
                    break;
                }
               
            }

            return sonuc;

        }
    }
}
