using System;

namespace Ders_4___Aritmetik_4_İşlem
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi1, sayi2, toplam;
            //Console.WriteLine("***** Toplama İşlemi *****");
            //Console.WriteLine();

            //Console.WriteLine("Birinci Sayıyı Giriniz= ");
            //sayi1 = Convert.ToInt32(Console.ReadLine()); // Convert, kullanıcının girdiği veriyi İnt tipine çevirme işlemini gerçekleştirir. Ardından int değişkenine bu değeri atar.

            //Console.WriteLine("İkinci Sayıyı Giriniz");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //toplam = sayi1 + sayi2;
            //Console.WriteLine("Toplam= " + toplam);

            //Console.Read();
            // ---------------------------------------------------------------------

            //int sayi1, sayi2, toplam, fark, carpim, bolum;

            //Console.WriteLine("***** Sayı Bilgileri *****");
            //Console.WriteLine();
            //Console.Write("Birinci Sayıyı Giriniz: ");
            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("İkinci Sayıyı Giriniz: ");
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("***** Aritmetik İşlemler *****");
            //Console.WriteLine();

            //toplam = sayi1 + sayi2;
            //Console.WriteLine("İki Sayının Toplamı: " + toplam);

            //fark = sayi1 - sayi2;
            //Console.WriteLine("İki Sayının Farkı: " + fark);

            //carpim = sayi1 * sayi2;
            //Console.WriteLine("İki Sayının Çarpımı: " + carpim);

            //bolum = sayi1 / sayi2;
            //Console.WriteLine("İki Sayının Bölümü: " +bolum);

            //Console.Read();

            // ---------------------------------------------------------------------

            int kenar, karealan, kareçevre;
            int kısakenar, uzunkenar, dikalan, dikcevre;

            Console.WriteLine("***** Kare Alan ve Çevre Hesaplama ******");
            Console.WriteLine();

            Console.WriteLine("Lütfen Karenin Bir Kenar Uzunluğunu Giriniz");
            kenar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            karealan = kenar * kenar;
            Console.WriteLine("Karenin Alanı= " + karealan);

            kareçevre = kenar * 4;
            Console.WriteLine("Karenin Çevresi= " + kareçevre);


            Console.WriteLine();
            Console.WriteLine("***** Diktörtgen Alan ve Çevre Hesaplama ******");
            Console.WriteLine();

            Console.WriteLine("Lütfen Diktörtgenin Kısa Kenar Uzunluğunu Giriniz");
            kısakenar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen Diktörtgenin Uzun Kenar Uzunluğunu Giriniz");
            uzunkenar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            dikalan = kısakenar * uzunkenar;
            Console.WriteLine("Diktörtgenin Alanı= " + dikalan);

            dikcevre = (kısakenar * 2) + (uzunkenar * 2);
            Console.WriteLine("Diktörtgenin Çevresi= " + dikcevre);

            Console.Read();

        }
    }
}
