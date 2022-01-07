using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //Generic class oluştrduk tüm tiplerde veri gönderilebilsin diye.
    {
        T[] items;
        //constructor - yapıcı metot class newlendiği anda çalışır.
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;//Önceden girilen bir değer varsa silinmesin diye tempArray(geçicidizi) ye attık.
            items = new T[items.Length + 1];//items kapasitesini bir artırdık yenig girilen değeri yazmak için
            for (int i = 0; i < tempArray.Length; i++)//for ile tempArray daki elemanları items'a attık
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;//Yeni gelen değeri items'a ekledik. items.Length - 1 yapma sebebimiz dizi 6 elemanlıysa index 5 dir çünkü index 0 dan başlar 6-1=5 yani 5. index'e eklemek için.
        }

        public int Length//Eleman sayısını verir
        {
            get { return items.Length; }
        }

        public T[] Items//Elemanları verir
        {
            get { return items; }
        }

    }
}
