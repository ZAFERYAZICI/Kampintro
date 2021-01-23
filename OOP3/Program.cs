using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();//İnterfaceler onu iplement eden clasın referans değerini alıyor
            IKrediManager tasitKrediManager = new TasitKrediManager();


            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerServis fileloggerservis = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();


            //YAZILIMDA SÜRDÜRÜLEBİLİRLİĞİ SAĞLAR
            basvuruManager.BasvuruYap(konutKrediManager, new SmsLoggerServis());///İşte olay burada sen hangi krediyi verirsen ona başvurup hesaplıyor


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };//burada gönderilen iki kredinin hesaplaması yapıldı

            //basvuruManager.KrediOnbilgilendirmesiYap(krediler);

        }
    }
}
