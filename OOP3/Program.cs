using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        // İnterface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
        static void Main(string[] args)
        {
            //interface lerde o interface'i implemente eden class'ın referans numarasını tutabiliyor.
            //Aşağıdakiler şubedeki görevlinin ekranı gibi düşün krediler var. Bu şekilde simüle ediyoruz.
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();//ister böyle newleyip basvuruManager.BasvuruYap metodunda new DatabaseLoggerService() yerine databaseLoggerService yazabiliriz.yada basvuruManager.BasvuruYap metodunda yazdığı gibi newleyebiliriz.
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };//basvuruManager.BasvuruYap daki gibi newleyedebiliriz buradaki gibi listemizi oluşturup loggers değikenini orayada yazabiliriz.

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new List<ILoggerService>{ new SmsLoggerService(), new DatabaseLoggerService()});//BasvuruYap metoduIKrediManager tipinde parametre istiyor IKrediManager implemente edilmiş class'lardan birini verebiliriz.//Çoklu logger göndereceğimiz için List yaptık.

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager, konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
