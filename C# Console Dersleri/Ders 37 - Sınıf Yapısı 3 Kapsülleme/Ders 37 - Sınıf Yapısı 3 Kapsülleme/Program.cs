using System;

namespace Ders_37___Sınıf_Yapısı_3_Kapsülleme
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kapsülleme, Değişkenleri ve verileri hatalı kullanım ve dış etkenlerden korumaktır. Başka kod ve sınıflar tarafından kullanılmaması için bariyer görevi görür.

            Emlak eml = new Emlak();

            eml.SEMT = "Sarıyer";
            eml.RENK = "Mavi";
            eml.odasayi = 4;
            eml.katnumara = -8;
            eml.ALAN = -80;

            Console.WriteLine("Evin Bulunduğu Semt: " + eml.SEMT);
            Console.WriteLine("Evin Oda Renkleri: " + eml.RENK);
            Console.WriteLine("Evin Toplam Oda Sayısı: " + eml.odasayi);
            Console.WriteLine("Evin Kat Numarası: " + eml.katnumara);
            Console.WriteLine("Evin Toplam Alanı: " + eml.ALAN+" Metrekare");

            Console.Read();
        
        
        }
    }
}
