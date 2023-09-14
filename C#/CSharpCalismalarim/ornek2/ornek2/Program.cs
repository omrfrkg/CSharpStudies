using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi1 = new Kisi();
            kisi1.ad = "Ömer";
            kisi1.soyad = "Gündoğdu";
            kisi1.yas = 32;
            Kisi kisi2 = new Kisi();
            kisi2.ad = "Özgür";
            kisi2.soyad = "Demir";
            kisi2.yas = 32;
            List<Kisi> kisiListesi = new List<Kisi>();

            kisiListesi.Add(kisi1);
            kisiListesi.Add(kisi2);
            kisiListesi.Add(new Kisi {
            ad = "Naci",
            soyad = "Karakullukçu",
            yas = 22
            });
            
            foreach (var kisi in kisiListesi)
            {
                Console.WriteLine("Ad : {0} Soyad : {1} Yaş : {2}",kisi.ad,kisi.soyad,kisi.yas);
            }
            Console.ReadLine();
        }
    }
}
