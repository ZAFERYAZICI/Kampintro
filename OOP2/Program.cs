using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();

            musteri1.MusteriNo = "1231231";
            musteri1.Id = 1;
            musteri1.Adi = "ENGİN";
            musteri1.Soyadi = "DEMİR";
            musteri1.TcNo = "13123123";



            TuzelMusteri musteri2 = new TuzelMusteri();

            musteri2.Id = 12;
            musteri2.MusteriNo = "23424234";
            musteri2.SirketAdi = "KODLAMAID";
            musteri2.VergiNo = "1231234332";


            Musteri musteri3 = new GercekMusteri();

            Musteri musteri4 = new TuzelMusteri();

            MusteriOperasyonlari musteriOperasyonlari = new MusteriOperasyonlari();

            musteriOperasyonlari.Ekle(musteri1);
            musteriOperasyonlari.Ekle(musteri2);
            musteriOperasyonlari.Ekle(musteri4);
            musteriOperasyonlari.Ekle(musteri3);


        }



    }
}
