using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {

            string kategorietiketi = "kategoril";
            int faizorani = 123123;
            bool sistemegirisyapmismi = true;
            double dolarDun = 7.45;
            double doalrBugun = 7.45;


            if (dolarDun>doalrBugun)
            {
                Console.WriteLine("Azalış");
            }
            else if (dolarDun<doalrBugun)
            {
                Console.WriteLine("Artış");
            }
            else
            {
                Console.WriteLine("değişmedi");
            }

            if ( sistemegirisyapmismi==true)
            {
                Console.WriteLine("Kullanici Ayar");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategorietiketi);



        }
    }
}
