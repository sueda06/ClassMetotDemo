using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Sueda";
            musteri1.Soyad = "Akın";
            musteri1.Telefon = 4758962881;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Elif";
            musteri2.Soyad = "Akın";
            musteri2.Telefon = 1258962881;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);

            Console.ReadLine();
        }
    }
}
