using System;

namespace OdevClaslar
{
    class Program
    {
        static void Main(string[] args)
        {


            Kitap Roman = new Kitap();

            Roman.Adi = "Kürk Mantolu Madonna";
            Roman.Yazari = "Sabahattin Ali";
            Roman.Fiyati = 35;

            Kitap Hikaye = new  Kitap();

            Hikaye.Adi = "Keloğlan";
            Hikaye.Yazari = "Ali Işık";
            Hikaye.Fiyati = 12;


            Kitap[] urunler = new Kitap[] { Roman,Hikaye };

            foreach ( var listele in urunler)
            {
                Console.WriteLine(listele.Adi + ": " +listele.Yazari + " : " + listele.Fiyati);

            }



        }
    }



    class Kitap
    {

        public string Adi { get; set; }

        public string Yazari { get; set; }

        public int Fiyati { get; set; }




    }


}
