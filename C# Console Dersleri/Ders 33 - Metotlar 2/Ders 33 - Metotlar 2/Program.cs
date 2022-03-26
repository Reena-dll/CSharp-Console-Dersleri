using System;

namespace Ders_33___Metotlar_2
{
    class Program
    {
        // Girilen string ifadeyi 10 kez yazdıran metot.
        private static void yazdir(string bilgi)
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine(bilgi);
        }

        // Girilen Sayıları toplayan metot.
        private static int Topla(int s1, int s2)
        {
            int t = s1 + s2;
            return t;
        }


        // Girilen sayıların farkını aldıran metot:
        private static int fark(int sayi1, int sayi2)
        {
            int f = sayi1 - sayi2;
            return f;
        }


        // Girilen Sayının Küpünü aldıran metot:

            private static int kup(int kup1)
        {
            int islem = kup1 * kup1 * kup1;
            return islem;
        }
        static void Main(string[] args)
        {

            // Girilen string ifadeyi 10 kez yazdıran program.

            //Console.Write("Metni Girin: ");
            //string blg = Console.ReadLine();
            //yazdir(blg);
            //Console.Read();

            // Girilen Sayıları toplayan program.

            //Console.WriteLine("Toplam: "+Topla(5,8));
            //Console.WriteLine("Toplam: " + Topla(7, 1));
            //Console.Read();

            // Girilen sayıların farkını aldıran program:

            //Console.WriteLine("Farkları: " + fark(9, 4));
            //Console.Read();

            // Girilen Sayının Küpünü aldıran metot:

            Console.Write("Bir Sayı Giriniz: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sayınızın Küpü: " + kup(k));
            Console.Read();

        }
    }
}
