using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ad = "Eren";
            musteri1.soyad = "Gözsüz";
            musteri1.TcNo = "12345678999";
            musteri1.PostaKodu = 34220;

            Musteri musteri2 = new Musteri();
            musteri2.ad = "Esra";
            musteri2.soyad = "Atıcı";
            musteri2.TcNo = "14725836945";
            musteri2.PostaKodu = 34000;



            Musteri musteri3 = new Musteri();
            musteri3.ad = "Ahmet";
            musteri3.soyad = "Tatlıcı";
            musteri3.TcNo = "98765432112";
            musteri3.PostaKodu = 34140;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2};

            Console.WriteLine("-------------------Metotlar-------------------");

            MusteriManager musteriManager = new MusteriManager();
            MusteriManager.Ekle(musteri3);
            MusteriManager.Sil(musteri3);
            MusteriManager.Listele(musteriler);
            Console.WriteLine("-----------");




        }
    }
}
