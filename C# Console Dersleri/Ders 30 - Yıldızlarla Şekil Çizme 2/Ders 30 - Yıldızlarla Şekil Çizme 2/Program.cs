using System;

namespace Ders_30___Yıldızlarla_Şekil_Çizme_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // YILDIZLARDAN KARE YAPIMI

            int kare;
            Console.Write("Kenar Sayısını Girin: ");
            kare = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine();
            // ÜST KISIM 
            for(int i=0;i<kare;i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();

            // ORTA KISIM
            for (int k = 0; k < kare - 2; k++)
            {
                Console.Write("* ");

                for(int l=0;l<kare-2;l++)
                {
                    Console.Write("  ");
                }
                Console.Write("*");
                    Console.WriteLine();
            }

            // Alt kısım

            for(int x=0;x<kare;x++)
            {
                Console.Write("* ");
            }

            Console.Read();
        }
    }
}
