using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            Musteri musteri1 = new Musteri();

            musteri1.Adi = "ZAFER";
            musteri1.Soyadi = "YAZICI";
            musteri1.Yasi = 35;

            Musteri musteri2 = new Musteri();

            musteri2.Adi = "ALİ";
            musteri2.Soyadi = "CAN";
            musteri2.Yasi = 45;

            Musteri musteri3 = new Musteri();

            musteri3.Adi = "AYŞE";
            musteri3.Soyadi = "SARI";
            musteri3.Yasi = 23;

            Musteri[] musteris = new Musteri[] { musteri1, musteri2, musteri3 };


            MusteriManager.MusteriEkle(musteri3);
            MusteriManager.MusteriListele(musteris);
            MusteriManager.MusteriSilme(musteri1);






            
        }
    }
}
