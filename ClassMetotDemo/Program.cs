using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAd = "Umutcan";
            musteri1.MusteriSoyad = "Kibar";
            musteri1.MusteriTel = 123456;
            musteri1.MusteriAdres = "Turkey";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAd = "Kenan";
            musteri2.MusteriSoyad = "Kibar";
            musteri2.MusteriTel = 345678;
            musteri2.MusteriAdres = "Turkey";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAd = "Çağrı";
            musteri3.MusteriSoyad = "Kibar";
            musteri3.MusteriTel = 567890;
            musteri3.MusteriAdres = "Turkey";

            MusteriManager musteri = new MusteriManager();
            musteri.Listele(musteri1);

            Console.WriteLine("--------------------------");

            musteri.Add(musteri2);

            Console.WriteLine("--------------------------");

            musteri.Delete(musteri3);
        }
    }
}
