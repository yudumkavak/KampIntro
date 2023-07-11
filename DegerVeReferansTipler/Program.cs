using System;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 =30

            int[]sayilar1=new int[] {10,20,30};
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]?? cevap 999


            string[] kalem1 = new string[] { "beyaz", "Siyah" };
            string[] kalem2 = new string[] { "kırmızı", "mavi" };
            kalem1 = kalem2;
            kalem2[0] = "sarı";
            Console.WriteLine(kalem1);
            //kalem[0]?? cevap sarı

            //stack-heap= değer tipler stackte gerçekleşir, referans tipler heapte gerçekleşir.
        }

        // int , decimal ,float , double, bool =DEĞER TİP
        // Array , class , interface= REFERANS TİP
    }
}
