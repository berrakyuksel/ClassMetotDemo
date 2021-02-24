using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();



            musteri1.Ad = "Berrak";
            musteri1.SoyAd = "Yuksel";
            musteri1.ID = 0;

            musteri2.Ad = "Neşe";
            musteri2.SoyAd = "Yuksel";
            musteri2.ID = 1;

            musteri3.Ad = "Ömür";
            musteri3.SoyAd = "Yuksel";
            musteri3.ID = 2;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.listele(musteriler);






        }
    }
}
