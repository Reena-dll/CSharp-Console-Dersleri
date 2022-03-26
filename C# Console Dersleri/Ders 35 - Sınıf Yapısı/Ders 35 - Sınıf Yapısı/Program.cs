using System;

namespace Ders_35___Sınıf_Yapısı
{
    class Program
    {
        static void Main(string[] args)
        {

            Araba arbsnf = new Araba();
            arbsnf.renk = "Siyah";
            arbsnf.fiyat = 150000;
            arbsnf.model = "2016";
            arbsnf.vites = "Otomatik";
            arbsnf.plaka = "16-Bursa";

            Console.WriteLine("Araba Rengi: " + arbsnf.renk);
            Console.WriteLine("Araba Fiyatı: " + arbsnf.fiyat);
            Console.WriteLine("Araba Model Yılı: " + arbsnf.model);
            Console.WriteLine("Araba Vites Modeli: " + arbsnf.vites);
            Console.WriteLine("Araba Plaka: " + arbsnf.plaka);

            Console.WriteLine();

            arbsnf.renk = "Beyaz";
            arbsnf.fiyat = 140000;
            arbsnf.model = "2015";
            arbsnf.vites = "Otomatik";
            arbsnf.plaka = "34-İstanbul";
            Console.WriteLine("Araba Rengi: " + arbsnf.renk);
            Console.WriteLine("Araba Fiyatı: " + arbsnf.fiyat);
            Console.WriteLine("Araba Model Yılı: " + arbsnf.model);
            Console.WriteLine("Araba Vites Modeli: " + arbsnf.vites);
            Console.WriteLine("Araba Plaka: " + arbsnf.plaka);

       

            Console.Read();
        }
    }
}
