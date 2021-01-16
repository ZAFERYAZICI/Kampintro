using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {


            string kurs1 = "Yazilim Geliştirme";

            string kurs2 = "Temel Kurs";


            string kurs3 = "Java  Kurs";


            string[] kurslar = new string[] { "Yazilim Geliştirme", "Temel Kurs", "Java  Kurs","Python","Ali" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");

        }
    }
}
