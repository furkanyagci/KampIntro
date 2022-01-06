using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection - BasvuruYap metodunda metot injeksiyonu yapıyoruz yani metodun hangi kredi türü olacağını hangi loglayıcı olacağını injeksiyon ediyoruz.
        public void BasvuruYap(IKrediManager krediManager ,List<ILoggerService> loggerServices)//ILoggerService List'e çevirdik birden fazla log yollayacağımız için
        {
            //KonutKrediManager konutKrediManager = new KonutKrediManager();//Bu şekilde yazrsam kredi başvurusunu konutkredisine bağımlı hale getiririm.bunu silip  konutKrediManager.Hesapla(); kısmını krediManager.Hesapla() olarak değiştirip metot parametresine IKrediManager krediManager tipinde değşken verirsem tüm class'ları bu metoda gönderebilirim.Yani Tüm kredi tiplerini çalıştırabilirim
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)//Çoklu log kullanacağımız için foreach yaptık
            {
                loggerService.Log();

            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
