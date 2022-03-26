using System;

namespace Ders_7___Karar_Yapıları__
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int sinav1, sinav2, ortalama;

            //    Console.WriteLine("***** Not Hesaplama *****");
            //    Console.WriteLine();

            //    Console.Write("Birinci sınavınızı giriniz= ");
            //    sinav1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Birinci İkinci giriniz= ");
            //    sinav2 = Convert.ToInt32(Console.ReadLine());

            //    ortalama = (sinav1 + sinav2) / 2;
            //    Console.WriteLine("Ortalamanız= " + ortalama);

            //    if (ortalama>0 && ortalama < 30)      // "&&" Ve sembolüdür.
            //    {
            //        Console.WriteLine("VASAT!!!");
            //    }
            //    else if (ortalama>=30 && ortalama < 50)
            //    {
            //        Console.WriteLine("Kötü");
            //    }

            //    else if (ortalama>50 && ortalama < 75)
            //    {
            //        Console.WriteLine("İyi");
            //    }
            //    else if (ortalama>75 && ortalama < 100)
            //    {
            //        Console.WriteLine("Çok iyi");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Lütfen Geçerli Bir Not Girin");
            //    }


            //    Console.ReadLine();


            // KLAVYEDEN GİRİLEN BİR SAYININ TEK Mİ ÇİFT Mİ OLDUĞUNU BULAN PROGRAM

            // int sayi;

            // Console.WriteLine("*****Bir Sayının Tek Mi Çift Mi Olduğunu Söyleyen Program*****");
            // Console.WriteLine();

            // Console.Write("Bir sayı giriniz= ");
            // sayi = Convert.ToInt32(Console.ReadLine());

            //if(sayi % 2 == 1)   // "%" işareti Mod alma sembolüdür. Sayi'nin 2 ile bölümünden kalan 1'e eşit ise.
            // {
            //     Console.WriteLine("Sayınız " + sayi +" ve bu sayı Tektir.");
            // }

            //else
            // {
            //     Console.WriteLine("Sayınız " + sayi + " ve bu sayı Çifttir");


            // }

            // Console.ReadLine();


            int sayi;
            Console.WriteLine("*****Bir sayının 5'e bölünüp bölünemediğini söyleyen program*****");
            Console.WriteLine();

            Console.Write("Bir sayı giriniz= ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 5 == 0)
            {
                Console.WriteLine("Bu sayı 5'e tam bölünür");
            }

            else
            {
                Console.WriteLine("Bu sayı 5'e tam bölünmez");
            }
            Console.ReadLine();
        }

    }
}
