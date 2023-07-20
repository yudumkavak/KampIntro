using System;

namespace ProductOdev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ürün bilgilerine atama yapılması
            Urun urun1 = new Urun();
            urun1.MamaAdi = "Sanabelle";
            urun1.MamaOzellikleri = "Kısırlaştırılmış kediler için";
            urun1.MamaFiyati = 800;

            Urun urun2 = new Urun();
            urun2.MamaAdi = "Royal Cannin";
            urun2.MamaOzellikleri = "Yavru Kediler için";
            urun2.MamaFiyati = 875;

            Urun urun3 = new Urun();
            urun3.MamaAdi = "Hills";
            urun3.MamaOzellikleri = "Yetişkin kediler için";
            urun3.MamaFiyati = 900;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            //for döngüsü
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Ürün Adı : " + urunler[i].MamaAdi);
            }

            //ürünler içinde ürün bilgilerinin döndürülmesi
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.MamaAdi + " : " + urun.MamaOzellikleri);
            }

            //while döngüsü
            int j = 0;
            while (j < urunler.Length)
            {
                Console.WriteLine("Mama Adı : " + urunler[j].MamaAdi + " " + " Fiyatı : " + urunler[j].MamaFiyati);
                j++;
            }
        }
    
    }
}
