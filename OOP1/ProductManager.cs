using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1


{   // manager class ı operasyonları içerir. ürünle ilgili ekleme çıkarma silme güncelleme işlemleri yapılır.
    internal class ProductManager
    {

        //encapsulation : classın tüm özelliklerini Manager classına eklemek için Add(Product product) olarak yazılan kapsülleme yöntemi
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "Eklendi." );
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Güncellendi.");
                
        }
        public int Topla(int sayi1 , int sayi2)
        { 
            return sayi1 + sayi2;
        
        }
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);      
                
        }
        //void yazınca işi yapar bitirir sonrasında bir işlem yapmaz sadece yazılan tipte sonuç verir yani int gibi.
        //return olarak dönünce değişiklik yapılabilir, tekrar üzerinden işlem yapılabilir.
            

    }
}
