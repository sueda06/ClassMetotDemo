using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" adlı musteri eklendi");
            Console.WriteLine("---------------------");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Musterinin adı: "+musteri.Ad);
            Console.WriteLine("Musterinin adı: "+musteri.Soyad);
            Console.WriteLine("Musterinin adı: "+musteri.Telefon);
            Console.WriteLine("---------------------");
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " adlı musteri silindi");
            Console.WriteLine("---------------------");
        }
    }
}
