using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Dipendis İnjection Denir
        public void BasvuruYap(IKrediManager krediManager,ILoggerServis loggerServis)//Buraya taşıt krediside gönder ihtiyaçta gönder ona göre hesaplamayapar..
        {

            //Basvuran bilgileri değerlendir.
            //Başka şeylerde yapılıyor


            krediManager.Hesapla();
            loggerServis.Log();



        }

        public void KrediOnbilgilendirmesiYap(List<IKrediManager> krediler)
        {

            foreach (var kredi in krediler)//Hangi kredi gelir ise ona göre hesaplama yapar 
            {

                kredi.Hesapla();


            }

        }


    }
}
