using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {




        public static void MusteriEkle(Musteri musteri)
        {


            Console.WriteLine(musteri.Adi + " " +musteri.Soyadi + " Yaşı : " + musteri.Yasi +" Musteri Eklenmiştir");




        }

        public static void MusteriListele(Musteri[] musteri)
        {


            foreach (Musteri musterilerimiz in musteri)
            {

                Console.WriteLine(musterilerimiz.Adi + " " + musterilerimiz.Soyadi + " " +  musterilerimiz.Yasi +  " Musteri Listelenmiştir");
            }


        }
        public static void MusteriSilme(Musteri musteri)
        {

            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " Musteri Silinmiştir");

        }



    }
}
