using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individual(Bireysel demek aslında) - Gerçek
    class GercekMusteri : Musteri//Bu class Musteri class'ı bu varlık(entity) class'ı bu class içinde operasyonlar olmaz yani metotlar kodlama olmaz.MusteriManager adında bir class açıp onun içine yazabiliriz operasyonları.
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }

    }
}
