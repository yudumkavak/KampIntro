using System;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //type safety - tip güvenliği
            // Do not repeat yourself- kendini tekrar etme

            string kategoriEtiketi = "Kategori";    //kategoriEtiketi - değer tutucudur (alias)

            int ogrenciSayisi = 32000;
            double faizOrani= 1.45;
            bool sistemeGirisYapmisMi = true;       //bool - şart bloklarında true veya false olarak kullanılır.
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun) 
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");   
            }
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");    
            }

            Console.WriteLine(kategoriEtiketi);
           

        }
    }
}
