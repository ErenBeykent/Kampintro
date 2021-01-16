using System;

namespace Ödev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Pantolon";
            urun1.Renk = "Beyaz";
            urun1.Fiyat = 59.99;
            Urun urun2 = new Urun();
            urun2.UrunAdi = "Sweat";
            urun2.Renk = "Bordo";
            urun2.Fiyat = 79.49;
            Urun urun3 = new Urun();
            urun3.UrunAdi = "Ayakkabı";
            urun3.Renk = "Siyah";
            urun3.Fiyat = 250.0;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };
            Console.WriteLine("Foreach");
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " :  " + urun.Renk + " :  " + urun.Fiyat);
            }
            Console.WriteLine("------------");
            Console.WriteLine("FOR");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + " :  " + urunler[i].Renk + " :  " + urunler[i].Fiyat);
            }
            Console.WriteLine("------------");
            Console.WriteLine("While");
            int a = 0;
            while ( a < urunler.Length)
            {
                Console.WriteLine(urunler[a].UrunAdi + " :  " + urunler[a].Renk + " :  " + urunler[a].Fiyat);
                a++;
            }

        }
    }
}


class Urun
{
    public string UrunAdi { get; set; }

    public string Renk { get; set; }

    public double Fiyat { get; set; }

}
