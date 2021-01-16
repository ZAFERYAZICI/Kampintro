using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun Urun1 = new Urun();

            Urun1.Adi = " Elma";
            Urun1.Fiyati = 15;

            Urun1.Aciklama = "Amasya Elması";


            Urun Urun2 = new Urun();

            Urun2.Adi = "Karpuz";
            Urun2.Fiyati = 12;
            Urun2.Aciklama = "BAFRA KARPUZU";


            Urun[] urunler = new Urun[] { Urun1, Urun2 };

            foreach (Urun urunlerimiz in urunler)
            {
                Console.WriteLine(urunlerimiz.Adi);
                Console.WriteLine(urunlerimiz.Fiyati);
                Console.WriteLine(urunlerimiz.Aciklama);
            }


            Console.WriteLine("--------METOTLAR----");


            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(Urun1);
            sepetManager.Ekle(Urun2);
           


        }
    }
}
