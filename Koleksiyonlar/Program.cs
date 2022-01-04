using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];//new dersek yeni bir referans oluşturur o yüzden yukarıdaki isimler silinir eski referansta kaldığı için garbage collector siler.
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);//ilker ekrana yazar
            //Console.WriteLine(isimler[0]);//0 da Engin var ama new string[5] yaptığımız için yeni referans verdi eskisi silindi

            // Genelde array değil List kullanılır.

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            //isimler2 = new List<string>();//new leyince array daki gibi oluyor
            isimler2.Add("İlker");//ilkeri ekledi
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
