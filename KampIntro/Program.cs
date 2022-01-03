using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //do not repat yourself - kendini tekrarlama demektir
            //kategoriEtiketi bir değer tutucudur. alias'dır(takma isim)

            string kategoriEtiketi = "Kategori";// python kategoriEtiketi = "Kategori"; bu şekilde yazabiliriz ama c# java gibi dillerde type safety(tip güvenliği) olayı vardır aşırı derecede ön planda olduğu için değişken tipini belirtiyoruz.

            //do not repat yourself - kendini tekrarlama demektir
            Console.WriteLine(kategoriEtiketi);//Bu şekilde yamak yerine değişkene atıp buraya değişkeni yazarsak bir değişim söz konusu olduğunda sadece değişkeni değiştiririz bu değişken kaç sayfada ekrana yazdırılıyorsa hepsi değişmiş olur. Console.WriteLine("Kategoriler"); bu şekilde yazarsak tüm sayfadaki  Console.WriteLine("Kategoriler"); bulup değiştirmemiz gerekirdi. Değişken kullanarak yazmamızın önemi bu

            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmisMi==true)//Bu if bloğu bir simüslanyon eğer kullanıcı sisteme girdiyse veya girmediyse hangi butonu göreceğini gösteriyor.
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
        }
    }
}
