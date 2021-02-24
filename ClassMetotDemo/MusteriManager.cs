using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" "+musteri.SoyAd+" isimli müşteri eklenmiştir.");
        }

        public void listele(Musteri[] musteri)
        {
            foreach (var musteriler in musteri)
            {
                Console.WriteLine(musteriler.Ad+" "+musteriler.SoyAd);
            }
        }
    }
}
