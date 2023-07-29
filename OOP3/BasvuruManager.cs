using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap()
        {
            //Basvuran bilgilerini değerlendirme

            //Aşağıdaki gibi yazarsak tüm konut kredilerini konut kredisine göre hesaplar.

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
        }

        //aşağıdaki gibi başvuru yaptan sonra gelen parantez içinde IkrediManager konutKredisi yazarsak konut kr4edisini kendi kategorisine göre hesaplar.
        //Method injection : metot enjekte etmek, hangisini kullanacağını belirlemek.

        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService) 
        {
            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }
    }
}
