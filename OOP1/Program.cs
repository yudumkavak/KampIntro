using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)

            //2 türlü product oluşturulur. 1.yöntem
        {
            Product product1 = new Product();
            product1.Id= 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //product oluşturmada 2.yöntem

            Product product2 = new Product { Id=2, CategoryId =5, UnitsInStock=5,ProductName="Kalem", UnitPrice=35};


            //NOT1: instance creation : programcs den product manager ekranına burdaki productları göndermek için;
            //ProductManager productManager = new ProductManager(); yazılır.

            //NOT2:Neden new diye yazarız? çünkü stack-heap olarak referans değeri alabilmesi için heap referansına yeni atama yapılır(newlenir)

            // NOT3:PascalCase: kelimelerin ilk harfleri büyük yazılır classlarda böyledir. camelCase: Küçük harfle başlar 2.kelime ilk harfi büyük yazılır 
            // case sensitive : büyük-küçük harf duyarlılığı

            ProductManager productManager = new ProductManager();
            
            productManager.Add (product1);

            productManager.Topla2(3, 6);  //void ile yazılanı yazdırır değişiklik yapılmaz.

            int toplamaSonucu=productManager.Topla (3, 6); //return kullanılır. sonrasında değşiklik yapılabilir.toplamasonucunu çarpma gibi
            Console.WriteLine (toplamaSonucu*2);

        }
    }
}
