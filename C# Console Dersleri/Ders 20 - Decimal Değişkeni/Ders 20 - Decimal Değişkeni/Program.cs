using System;

namespace Ders_20___Decimal_Değişkeni
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hafızada 128 bitlik bellek kaplar. 16 byte. Kayan noktalı değerler için kullanılır. Finansal ve para değerlerinde çok sık kullanılır. 29 karakter kullanılabilir

            //decimal sayi;
            //sayi = 12.345m;   // virgüllü ifadelerde safex'i m Floatın ise f idi.
            //Console.Write(sayi);
            //Console.Read();

            //decimal s1;
            //int s2;
            //s1 = 2.45m;
            //s2 = 4;
            //decimal toplam;
            //toplam = s1 + s2;  // int ve decimal bir tip topluyor isek atayacağımız değişkenin decimal olması gerekiyor.
            //Console.Write("Toplam: " + toplam);
            //Console.Read();

            //decimal x = 0.997m; // Parasal işlem olarak yaptık. 0.997 olduğu için direkt 1.00'a yuvarladı.
            //decimal y = 999999;
            //Console.WriteLine("Para 1 {0:C}", x);
            //Console.WriteLine("Para 2 {0:C}", y);
            //Console.WriteLine("X: " + x);
            //Console.WriteLine("Y: " + y);
            //Console.Read();


            // Bir avm de ki kıyafet mağazısında ki ürünlerin satış miktarını decimal cinsinden yazdırın.

            decimal urun1, urun2, toplam;

            int s1, s2;

            urun1 = 14.85m;
            urun2 = 21.48m;

            Console.Write("1. Ürünün satış miktarı: ");
            s1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("2. Ürünün Satış Miktarı: ");
            s2 = Convert.ToInt16(Console.ReadLine());

            toplam = s1 * urun1 + s2 * urun2;
            Console.WriteLine("Gün Sonunda Kasada Olması Gereken Tutar: " + toplam+" TL");


            Console.Read();
        }
    }
}
