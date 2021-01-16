using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();

            kurs1.KursAdi = "c#";
            kurs1.Egitmeni = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "JAVA";
            kurs2.Egitmeni = "ZAFER";
            kurs2.IzlenmeOrani = 63;



            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "PYTON";
            kurs3.Egitmeni = "ALİ";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "ANGULAR";
            kurs4.Egitmeni = "MEHMET";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " :" + kurs1.Egitmeni);



            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3,kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " +kurs.Egitmeni);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }

}
