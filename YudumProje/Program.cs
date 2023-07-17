using System;
using System.Net.Http.Headers;

namespace YudumProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Canta canta1 = new Canta();
            canta1.Markasi = "Beymen";
            canta1.Rengi = "Pembe";
            canta1.Fiyati = 150;

            Canta canta2 = new Canta();
            canta2.Markasi = "Mango";
            canta2.Rengi = "Mavi";
            canta2.Fiyati = 1000;

            Canta canta3 = new Canta();
            canta3.Markasi = "Zara";
            canta3.Rengi = "Siyah";
            canta3.Fiyati = 900;

            Canta[] cantalar = new Canta[] { canta1, canta2, canta3 };
            Console.WriteLine("-----------foreach---------------");
            foreach (Canta cantax in cantalar)
            {
                Console.WriteLine(cantax.Markasi);
                Console.WriteLine(cantax.Rengi);
                Console.WriteLine(cantax.Fiyati);

            }

            Console.WriteLine("--------------for------------------");
            for (int i = 0; i < cantalar.Length; i++)
            {
                Console.WriteLine(cantalar[i].Markasi + " : " + cantalar[i].Fiyati);
            }
            Console.WriteLine("--------------while------------------");
            int canta = 0;
            while (cantalar.Length >= canta)
            {
                Console.WriteLine(cantalar[canta].Markasi + " : " + cantalar[canta].Fiyati + " : " + cantalar[canta].Fiyati);


            }// hata aldım. tekrar bak
        }

    }

}
