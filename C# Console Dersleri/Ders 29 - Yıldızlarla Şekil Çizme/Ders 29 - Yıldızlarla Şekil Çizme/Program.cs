using System;

namespace Ders_29___Yıldızlarla_Şekil_Çizme
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrana 10 defa yıldız yazacağız.
            //for(int i=0;i<10;i++)
            //{
            //    Console.WriteLine("*");

            //}
            //Console.Read();

            // Dik üçgene Benzeyen yıldız şeması.

            //for (int i=1;i<=10;i++)
            //{
            //    for(int j=0;j<i;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}
            //Console.Read();


       
            for(int i=0;i<20;i++)
            {
                for (int j = 20; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.Read();

        }
    }
}
