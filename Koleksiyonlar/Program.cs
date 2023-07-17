using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {      //stack                          //heap
            //string[] isimler = new string[] { "Engin", "Murat", "Halil", "Kerem" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; 
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
            //new denildiğinde bellekte yeni bir adres oluşur bundan dolayı 0.elemanı yeniden yazdırmadı.
            //array [] bir diziyi tutar. sonrasında eklenen için yeni tanımlamak gerekir.


            //List yazdıktan sonra yanda çıkan ampulden using System.Collections.Generic seçilir.
            //bunun sebebi listede sınıfları kullanabilmektir.

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Halil", "Kerem" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
