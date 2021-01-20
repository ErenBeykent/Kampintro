using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public static void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi: " + musteri.ad +" "+ musteri.soyad);
        }
        public static void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi:  " + musteri.ad +" "+ musteri.soyad);
        }
        public static void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteri Listesi ");
            foreach (Musteri m in musteriler)

            {
                Console.WriteLine(m.ad);
                Console.WriteLine(m.soyad);
                Console.WriteLine(m.TcNo);
                Console.WriteLine(m.PostaKodu);
                Console.WriteLine("------------------------------");
            }
        }
    }
}
