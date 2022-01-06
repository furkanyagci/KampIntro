using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafKrediManager : IKrediManager
    {
        //Yeni bir kredi çıkardım ve sadece bir class ekleyerek bu işi yaptım gidip kodların içinde iflerin içinde boğulmadım. Bu şekilde interface ve classlarla programlama daha kolay ve rahat

        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi ödeme planı hesaplandı");
        }
    }
}
