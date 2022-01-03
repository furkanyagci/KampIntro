using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("-------------Metotlar--------------");

            //instance örnek
            //Buna encapsulation denir. Encapsulation metot yazıp ayrı ayrı parametre vereceğine class oluşturup onunla çalışmaktır.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil armut",12,10);//bunlar farklı sayfalarda bulunuyor gibi düşünüyoruz. Eğer bu şekilde yaparsak Ekle2 metoduna yeni parametre ekleyince yani metot imzası değişince burası patlar. o yüzden class kullanmak daha doğru.
            sepetManager.Ekle2("Elma","Yeşil elma",12,9);
            sepetManager.Ekle2("Karpuz","Diyarbakır karpuzu",12,8);

        }
    }
}

//Dont repeat yourself - kısaltması DRY 
//Clean Code - Temiz kod
//Best Practice - En iyi uygulama teknikleri
