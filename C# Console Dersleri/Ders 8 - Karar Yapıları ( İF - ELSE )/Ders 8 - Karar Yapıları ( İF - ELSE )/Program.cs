using System;

namespace Ders_8___Karar_Yapıları___İF___ELSE__
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden Girilen Mevsime Göre O Mevsimin Aylarını Yazdıran Program

            //string mevsim;

            //Console.WriteLine("*****Mevsimin Aylarını Bulan Program*****");
            //Console.WriteLine();

            //Console.Write("Bir Mevsim Giriniz= ");
            //mevsim = Console.ReadLine();

            //if (mevsim=="sonbahar" || mevsim =="Sonbahar")  // "||" OR ifadesi için kullanılır. Her hangi bir koşulun doğru olması taktirde TRUE döner.
            //{
            //    Console.WriteLine("Sonbahar mevsiminin ayları şunlardır;");
            //    Console.WriteLine("Eylül, Ekim ve Kasım.");
            //}

            //else if (mevsim == "yaz" || mevsim == "Yaz")
            //{
            //    Console.WriteLine("Yaz mevsiminin ayları şunlardır;");
            //    Console.WriteLine("Haziran, Temmuz ve Ağustos");

            //}

            //else if (mevsim == "Kış" || mevsim == "kış")
            //{
            //    Console.WriteLine("Kış mevsiminin ayları şunlardır;");
            //    Console.WriteLine("Aralık, Ocak ve Şubat");

            //}

            //else if (mevsim == "ilkbahar" || mevsim =="İlkbahar")
            //{
            //    Console.WriteLine("İlkbahar mevsiminin ayları şunlardır;");
            //    Console.WriteLine("Mart, Nisan ve Mayıs.");
            //}

            //else
            //{
            //    Console.WriteLine("Girmiş olduğunuz mevsim yanlıştır.");
            //}

            //Console.Read();


            //----------------------------------------------------------------------------------------------------------------

            // Kitapçıdan alınan kitapların fiyatlarını listeleyen program.100tl üzeri alana şu kadar indirim. 150tl üsti alana bu kadar indirim gibi gibi

            int x, indirim, odenecek;

            Console.Write("Alışveriş Tutarını Giriniz= ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x<100)
            {
                indirim = x * 10 / 100;
                odenecek = x - indirim;
                Console.Write("Toplam Ödenecek Miktar= " + odenecek);

            }

            if (x < 150 && x>=100)
            {
                indirim = x * 15 / 100;
                odenecek = x - indirim;
                Console.Write("Toplam Ödenecek Miktar= " + odenecek);

            }

            if (x>=150 && x<200)
            {
                indirim = x * 20 / 100;
                odenecek = x - indirim;
                Console.Write("Toplam Ödenecek Miktar= " + odenecek);

            }

            Console.ReadLine();



        }
    }
}
