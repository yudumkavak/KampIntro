using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlmaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            Console.WriteLine(kurs1);  
            Console.WriteLine(kurs2);   
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);
                
            // [] array-dizi -birden fazla stringi tek bir değişkende tutar

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlmaya Başlangıç İçin Temel Kurs", "Java","Python","C#"};

            for (int i = 0; i <kurslar.Length; i++)
            {
               Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            //foreach- dizi temelli yapıları tek tek dönmeye yarar

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu-footer");
        }
    }
}
