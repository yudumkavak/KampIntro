﻿using System;

namespace Metotlar
{
    internal class Program
    {    //Dont repeat yourself - DRY-Clean Code 
        //Best Practice(doğru uygulama teknikleri)
        //type-safe tip güvenli 

        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";


            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------");

            }
            Console.WriteLine("--------Metotlar-----");
            //instance -örnek

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            Program program = new Program();
            program.Ekle(urun1);

        }
        public void Ekle(Urun urun)
        {

            Console.WriteLine("Tebrikler Sepete eklendi : " + urun.Adi);
        }
    }


}



