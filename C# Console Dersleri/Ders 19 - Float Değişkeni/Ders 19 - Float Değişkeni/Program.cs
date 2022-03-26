using System;

namespace Ders_19___Float_Değişkeni
{
    class Program
    {
        static void Main(string[] args)
        {
            // Float: 32 bitlik kayan değerleri saklayan değişkendir. Finansal hesaplamarda çok kullanılır. Bazı bilimsel çalışmalarda kullanılır. 1 byte 8 bittir.

            //float sayi;
            //sayi = 123;
            //Console.Write("Sayı: " + sayi);
            //Console.Read();

            //float s1, s2, toplam;
            //s1 = 25;
            //s2 = 45;
            //toplam = s1 + s2;
            //Console.Write("Toplam= " + toplam);
            //Console.ReadLine();

            //float deger;
            //deger = 1234567;
            //Console.Write("Sayı: " + deger);
            //Console.Read();

            //float sayi;
            //sayi = 2.1427359f;  // 7 rakam değer girilebilir en fazla. 7 karakter sonrasında ki karakteri yuvarlar.
            //Console.Write("Sayı: " + sayi);
            //Console.Read();

            int x = 3;
            float y = 2.5F;
            int z = 4;

            float toplam;

            toplam = x + y + z;
            Console.Write("Toplam= " + toplam); // Toplam değişkeni float olmaz ise hata alırız. Çünkü topladığı değişkenlerden birinin tipi float. Bu yüzden float değerleri alabilecek bir değişkene ihtiyacımız olur.
            Console.Read();
        }
    }
}
