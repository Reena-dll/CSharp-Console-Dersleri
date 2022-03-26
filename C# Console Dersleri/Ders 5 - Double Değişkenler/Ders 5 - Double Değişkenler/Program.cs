using System;

namespace Ders_5___Double_Değişkenler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Double değişkenler ise aritmatik işlemlerin içerisine ondalık değer girmesine denir. Ondalık sayılarda işlem yapacak isek double değişken kullanmamız gerekecek.

            Console.WriteLine("***** Öğrenci Not Hesaplama *****");
            Console.WriteLine();

            String ad, soyad, numara;
            double sinav1, sinav2, proje, ortalama;

            Console.Write("İsminizi Giriniz= ");
            ad = Console.ReadLine();

            Console.Write("Soyadınızı Giriniz= ");
            soyad = Console.ReadLine();

            Console.Write("Numaranızı Giriniz= ");
            numara = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("***** Kişisel Bilgiler *****");
            Console.WriteLine();

            Console.WriteLine("İsminiz= " + ad);
            Console.WriteLine("Soyadınız= " + soyad);
            Console.WriteLine("Numaranız= " + numara);

            Console.WriteLine();
            Console.WriteLine("***** Sınav Bilgileri *****");
            Console.WriteLine();

            Console.Write("Lütfen Birinci Sınavınızı Giriniz= ");
            sinav1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lütfen İkinci Sınavınızı Giriniz= ");
            sinav2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lütfen  Proje Notunu Giriniz= ");
            proje = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1. Sınav= " + sinav1);
            Console.WriteLine("2. Sınav= " + sinav2);
            Console.WriteLine("Proje= " + proje);

            ortalama = (proje + sinav1 + sinav2) / 3;

            Console.Write("Ders Ortalamanız= "+ortalama);


            Console.Read();


        }
    }
}
