using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1,int sayi2)
        {

            int toplam = sayi1 + sayi2;

            Console.WriteLine("Sonuç : " +toplam);



        }


        public void Carp(int sayi1,int sayi2)
        {

            int carpim = sayi1 * sayi2;

            Console.WriteLine("İki Sayının Çarpımı : " + carpim);

        }

        public void Bol(int sayi1,int sayi2)
        {
            int bolme = sayi1 / sayi2;

            Console.WriteLine("İki Sayının Bölümü  : " + bolme);


        }

    }
}
