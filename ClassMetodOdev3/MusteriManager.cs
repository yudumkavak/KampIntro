using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodOdev3
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgileri Eklendi  : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
            Console.WriteLine("---------------------");
        }
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgileri Listelendi : " + " " + musteri.MusteriId + " " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + musteri.MusteriTc);
            Console.WriteLine("----------------------------");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgileri Silindi : " + musteri.MusteriId);

            Console.WriteLine("----------------------------");
        }

        public void MusteriGuncelle(Musteri musteri) 
        {
            Console.WriteLine("Müşteri Soyadı Güncellendi : " + musteri.MusteriSoyadi + " "+ "Özbay");


        }







    }
}
