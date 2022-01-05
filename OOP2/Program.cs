using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();

            //olay tamamen referans tip. Base class ın onu inheritance eden classların referansını tutabilmesi
            Musteri musteri3 = new GercekMusteri();//*** NOT : Miras(inheritance) vermektedki amaç sadece classlardaki rtak alanları bir class'a yazmak değil miras verilen class'ın diğer classların referansını tutabilmesidir.Burada Musteri class'ı gibi. MusteriManager Add Metoduna bak parametre olarak musteri tipi var bu sayede GercekMusteri ve TuzelMusteri classlarını oraya gönderebiliyoruz.
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);

        }
    }
}
