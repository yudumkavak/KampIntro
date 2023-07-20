using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> 
    {
       T[] items;

        //constructor: ctor yazıp tab tab yapınca gelen public mylist classı newleyince otomatik çalışır.
        //Eklemek için newlemek gerekir.newleyince sıfır eleman bile olsa constructor yapmamız lazım

        public MyList()
        {
          items = new T[0];
        }
        public void Add(T item) 
        {
            //items.Length : dizinin eleman sayısı

          T[] tempArray = items;       //tempArray: geçici dizi- newleyince eskisi kaybolmasın diye yeni referansa(adrese) eklenir
          items=new T[items.Length+1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];

            }
            items[items.Length-1] = item;
        
        }   
    
    }
    
}
