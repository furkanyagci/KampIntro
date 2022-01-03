using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        //naming convention - isimlendirme kuralı
        //syntax - söz dizimi - yazım şekli
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi "+ urun.Adi);
        }
        //Encapsulation metot yazıp ayrı ayrı parametre vereceğine class oluşturup onunla çalışmaktır.
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)//stokAdedi'ni sonradan ekledik ve bu metot'u kullandığımız tüm sayfalar patladı yeni eklenen parametre değerini istiyorlar o yüzden bu şekilde kullanmak doğru değil
        {

        }
    }
}
