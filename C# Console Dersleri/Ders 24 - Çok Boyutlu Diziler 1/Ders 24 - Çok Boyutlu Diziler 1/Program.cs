using System;

namespace Ders_24___Çok_Boyutlu_Diziler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////  [,]  iki boyutlu dizi olduğunu belli etme ifadesi. MATRİS !!!!

            //int[,] dizi = new int[2, 2];
            //dizi[0, 0] = 25;
            //dizi[0, 1] = 35;
            //dizi[1, 0] = 17;
            //dizi[1, 1] = 16;

            //for (int i=0;i<2;i++)
            //{
            //     for (int j=0;j<2;j++)

            //        Console.Write(" {0} ", dizi[i, j]);
            //        Console.WriteLine();

            //}
            //Console.Read();

            // 2x3 tipinde MATRİS oluşturalım.   // 2x3 yani 2 satır sayısı 3 tane kolon

            //int[,] dizi = new int[2, 3];
            //dizi[0, 0] = 10;
            //dizi[0, 1] = 20;
            //dizi[0, 2] = 30;
            //dizi[1, 0] = 40;
            //dizi[1, 1] = 50;
            //dizi[1, 2] = 60;

            //for(int i=0;i<2;i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //        Console.Write(" {0} ", dizi[i, j]);
            //        Console.WriteLine();
            //}
            //Console.Read();

            // 3x2 tipinde MATRİS!!!!

            int[,] dizi = new int[3, 2];
            dizi[0, 0] = 10;
            dizi[0, 1] = 20;
            dizi[1, 0] = 30;
            dizi[1, 1] = 40;
            dizi[2, 0] = 50;
            dizi[2, 1] = 60;
            for(int i=0;i<3;i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write(" {0} ", dizi[i, j]);
                Console.WriteLine();
        
            }

            Console.Read();

        }


    }
}
