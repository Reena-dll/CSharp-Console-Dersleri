using System;

namespace Ders_27___Matematiksel_Fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {

            // Sayıların Mutlak Değerli İfadeleri.

            //int sayi;
            //Console.Write("Bir Sayı Giriniz: ");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Mutlak Değerli Hali: " + Math.Abs(sayi));    // Math.abs yani absolute den geliyor. Mutlak anlamı vardır.
            //Console.Read();

            // Sayıyı üste yuvarlama işlemi. Sayıyı alta yuvarlama işlemi.

            //double sayi;
            //Console.Write("Bir sayı giriniz: ");
            //sayi = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Sayınızın Üste Yuvarlanmış Hali: " +Math.Ceiling(sayi));   // Floor aşağıya yuvarlar, Ceiling ise yukarıya yuvarlar.
            //Console.Write("Sayınızın Alta Yuvarlanmış Hali: " +Math.Floor(sayi));
            //Console.Read();

            // Klavyeden girilen bir sayının 5. kuvvetini alalım. Yani üs alma.


            //int sayi;
            //Console.Write("Bir Sayı Giriniz: ");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sayınızın 5. Kuvveti: " + Math.Pow(sayi,5));  // Üs alma. Math.Pow üs almak için kullanılır.Parantez içinde ki ilk değer, üst alınacak sayının taban kısmı diğer değer ise üst kısmı.
            //Console.Read();

            // Klavyeden girilen sayının karekökünü bulalım.

            //int sayi;
            //Console.Write("Bir Sayı Giriniz: ");
            //sayi = Convert.ToInt32(Console.ReadLine()); 
            //Console.Write("Karakök değeri: " + Math.Sqrt(sayi));   // math.sqrt bir sayının karekökünü alma
            //Console.Read();

            // Cosinüs bulan program.

            //double sayi;
            //Console.Write("Dereceyi Giriniz: ");
            //sayi = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Sonuç: " + Math.Cos(sayi));
            //Console.Read();

            // Klavyeden girilen değerlerden büyük olanı bulalım.

            //double sayi1, sayi2;

            //Console.Write("Birinci Sayıyı Girin: ");
            //sayi1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("İkinci Sayıyı Girin: ");
            //sayi2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Büyük sayı: " + Math.Max(sayi1, sayi2)); // Math.Max büyük olan değeri verir.
            //Console.Read();


            // Klavyeden girilen değerlerden küçük olanı bulalım.

            //double sayi1, sayi2;

            //Console.Write("Birinci Sayıyı Girin: ");
            //sayi1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("İkinci Sayıyı Girin: ");
            //sayi2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Büyük sayı: " + Math.Min(sayi1, sayi2)); // Math.Min küçük olan değeri verir.
            //Console.Read();



            // EV ÖDEVİ!!!
            double sayi1, sayi2;
            Console.Write("Birinci Sayıyı Giriniz: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 == sayi2)
                Console.Write("Sayılarınız birbirine eşittir");

            else if (sayi1 < sayi2)
                Console.Write("Büyük Sayı: "+sayi2);

            else if (sayi1 > sayi2)
             Console.Write("Büyük Sayı: "+sayi1);
                
            
            
            Console.Read();

        }
    }
}
