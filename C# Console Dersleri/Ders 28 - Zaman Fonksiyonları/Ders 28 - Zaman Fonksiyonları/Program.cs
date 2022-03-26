using System;

namespace Ders_28___Zaman_Fonksiyonları
{
    class Program
    {
        static void Main(string[] args)
        {
            //    DateTime zaman;
            //    zaman = DateTime.Now;
            //    Console.Write("Tarih ve Saat: {0}",zaman);
            //    Console.Read();

            //DateTime zaman;
            //zaman = DateTime.Now;
            //int ay = zaman.Month;
            //int gün = zaman.Day;
            //int yıl = zaman.Year;
            //DayOfWeek haftanıngunu = zaman.DayOfWeek;
            //Console.WriteLine("Gün: {0}", gün);
            //Console.WriteLine("Ay: {0}", ay);
            //Console.WriteLine("Yıl: {0}", yıl);
            //Console.WriteLine("Haftanın Günü: {0}", haftanıngunu);
            //Console.Read();

            DateTime zaman;
            zaman = DateTime.Now;
            Console.WriteLine("***** C# Dersleri Tarih Saat Fonksiyonları *****");
            Console.WriteLine("Kısa Tarih: {0:d}",zaman);   // Gün ay yıl yazdırır kısaca. "d"   
            Console.WriteLine("Kısa Tarih: {0:D}", zaman);  // Gün ay yıl açıklamalı yazdırır.
            Console.WriteLine("Tam Tarih: {0:f}", zaman);  // Uzun ve açıklamalı yazdırır ekstra olarak saati de yazar. "f" FullTarih
            Console.WriteLine("Tam Tarih: {0:F}", zaman); // Uzun ve açıklamalı yazdırır saati ve saniyeyi  de yazdırır.
            Console.WriteLine("Tarih Formatı: {0:g}", zaman);  // Kısa tarih ve saati yazar.
            Console.WriteLine("Tam Tarih: {0:G}", zaman);  // Kısa tarih , saati ve saniyeyi yazar.
            Console.WriteLine("Ay: {0:m}", zaman);  // Hangi ayda olduğumuzu ve ayın kaçı olduğunu yazar.
            Console.WriteLine("Uzun tarih: {0:r}", zaman);
            Console.WriteLine("Ay: {0:s}", zaman);
            Console.WriteLine("Saat: {0:t}", zaman); // SADECE SAATİ VERİR
            Console.WriteLine("Ay: {0:t}", zaman);  // Saniyeyi ve saati verir.
            Console.WriteLine("Ay ve yıl: {0:y}", zaman);  // Ay ve yılı veriyor.
            Console.Read(); 




        }
    }
}
