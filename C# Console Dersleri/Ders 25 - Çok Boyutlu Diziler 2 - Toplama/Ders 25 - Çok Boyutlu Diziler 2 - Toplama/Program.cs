using System;

namespace Ders_25___Çok_Boyutlu_Diziler_2___Toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            // Matrisler arası toplama yaparken tipleri aynı olmayı yani 2x2 ile 2x2 arasında toplama işlemi gerçekleştirilirken 2x3 ve 2x2 nin arasında gerçekleştirilemez.

            //Console.WriteLine(".....MATRİSLERDE TOPLAMA.....");
            //Console.WriteLine();

            //int[,] matris1 = { { 10, 12, 14, 18 }, { 20, 14, 16, 13 }, { 25, 14, 41, 21 }, { 32, 36, 41, 57 } };
            //int[,] matris2 = { { 40, 30, 20, 10 }, { 7, 9, 8, 6 }, { 21, 22, 23, 24 }, { 34, 35, 36, 37 } };

            //int[,] toplam = new int[4, 4];

            //for(int i=0;i<4;i++)
            //{
            //    for(int j=0;j<4;j++)
            //    {
            //        toplam[i, j] = matris1[i, j] + matris2[i, j];
            //    }
            //}

            // for(int k=0;k<4;k++)
            //{
            //    Console.WriteLine();
            //    for(int m=0;m<4;m++)
            //    {
            //        Console.Write(toplam[k, m]+" ");
            //    }
            //}


            //Console.Read();


            // 4x2 tipinde matrisi toplayıp listeyen program EV ÖDEVİ. 4 satır 2 kolon

            Console.WriteLine("..... MATRİS TOPLAMA .....");
            Console.WriteLine();

            int [,] matris1 = { { 10, 20 }, { 21, 36 }, { 5, 6 }, { 27, 11 } };
            int [,] matris2 = { { 31, 7 }, { 50, 25 }, { 11, 19 }, { 26, 12 } };

            int [,] toplam = new int[4,2];

            for(int i=0;i<4;i++)
            {
                for (int j=0;j<2;j++)
                
                    toplam[i,j] = matris1[i,j] + matris2[i,j];
                
            }

            for(int k=0;k<4;k++)
            {
                Console.WriteLine();
                for (int l = 0; l < 2; l++)
                
                    Console.Write(toplam[k, l] + " ");
                
            }

            Console.Read();
          }
           
        }
 }

