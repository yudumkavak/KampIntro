using System;

namespace ClassMetodOdev3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 5875;
            musteri1.MusteriAdi = "Yudum";
            musteri1.MusteriSoyadi = "Kavak";
            musteri1.MusteriTc = 12345678;
            musteri1.MusteriAdresi = "Ankara";

            Musteri musteri2=new Musteri();
            musteri2.MusteriId = 7558;
            musteri2.MusteriAdi = "Ebubekir";
            musteri2.MusteriSoyadi = "Özbay";
            musteri2.MusteriTc = 910111213;
            musteri2.MusteriAdresi = "Sivas";


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriGuncelle(musteri1);


        }
        
        

    }
}
