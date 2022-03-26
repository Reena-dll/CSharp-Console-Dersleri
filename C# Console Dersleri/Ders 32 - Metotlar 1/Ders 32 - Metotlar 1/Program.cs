using System;

namespace Ders_32___Metotlar_1
{
    class Program
    {
        private static void veriler()
        {
            Console.WriteLine("Müdür: Oğuzhan Sadıkoğlu");
            Console.WriteLine("Öğretmen: Ahmet Yıldız");
            Console.WriteLine("Okul: Recaizade Ekrem İlköğretim Okulu");
            Console.WriteLine("Eğitsel Kol: Kütüphanecilik");
            Console.WriteLine("Şehir: İstanbul");
            Console.WriteLine(DateTime.Now.ToLongDateString());   // Tarihi Getirir.
        }
        static void Main(string[] args)
        {

            // Metot: Programın her hangi bir yerinde kullanılmak için tasarlanmış programlardır. Kod fazlalığından kurtarır. 
            // Public dışarıdan erişimi var. Private dışarıdan erişimi yok!!!.

            veriler();          
            Console.Read();

        }
    }
}
