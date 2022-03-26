using System;

namespace Ders_31___Yıldızlarla_Şekil_Çizme_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger;
            Console.Write("Baklava sayısını girin: ");
            deger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i <= deger; i++)
            {
                for(int x=deger;x>i;x--)
                {
                    Console.Write(" ");
                }
                for(int y = 1; y <= i; y++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();

            }

            for(int k = 1; k <= deger; k++)
            {
                for(int m = 1; m <= k; m++)
                {
                    Console.Write(" ");
                }
                for(int n = deger; n > k; n--)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
