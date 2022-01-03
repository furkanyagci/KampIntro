using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 kaçtır? cvp : 10 değer tip old. için

            int[] sayilar1 = new int[] { 10, 20, 30 };//int[] sayilar1 stack de tutulur = den sonrası heap de tutulur yani eşittirin solu stack de sağı hesap de tutulur.
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;// Burada sayilar2 nin referansı sayilar1'e atandı. sayilar1'in rakamlarının referansı garbage collector tarafından silinecek çünkü o sayıların referansını tutan yok.
            sayilar2[0] = 999;
            //sayilar1[0] değeri nedir? cvp 999 Referans tip old. için

            //sayısal veri tipleri : int, decimal, float, double, bool = Değer Tip'dir.

            //array(int, string vb. tüm dizi tipleri için geçerli), class, interface = Referans Tip

        }
    }
}
