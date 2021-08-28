using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Tebrikler." + musteri.MusteriAd + " " + musteri.MusteriSoyad + " " + "İsimli Müşteri Eklendi!!");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Tebrikler." + musteri.MusteriAd + " " + musteri.MusteriSoyad + " " + "İsimli Müşteri Silindi!!");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri Aşağıdaki gibidir");
            Console.WriteLine("Müşteri Id       :" + musteri.MusteriId);
            Console.WriteLine("Müşteri Adı      :" + musteri.MusteriAd);
            Console.WriteLine("Müşteri Soyadı   :" + musteri.MusteriSoyad);
            Console.WriteLine("Müşteri Numarası :" + musteri.MusteriTel);
            Console.WriteLine("Müşteri Adresi :" + musteri.MusteriAdres);
        }
    }
}
