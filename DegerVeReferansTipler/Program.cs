using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Değer Tipi Örneği");

            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;

            Console.WriteLine(sayi1);


            Console.WriteLine("Referans Tipi Örneği");


            string[] sehirler1 = new string[] {"İstanbul","Samsun","Adana" };

            string[] sehirler2 = new string[] { "Kastamonu", "Ankara", "Malatya" };

            sehirler1 = sehirler2;

            sehirler1[0] = "Karabük";
            Console.WriteLine(sehirler2[0]);



        }
    }
}
