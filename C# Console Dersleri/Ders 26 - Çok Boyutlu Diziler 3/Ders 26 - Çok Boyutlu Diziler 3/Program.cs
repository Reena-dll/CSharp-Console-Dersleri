using System;

namespace Ders_26___Çok_Boyutlu_Diziler_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //int satir, sutun;
            //Console.Write("Satır Sayısını Girin: ");
            //satir = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Sütün Sayısını Girin: ");
            //sutun = Convert.ToInt16(Console.ReadLine());

            //int[,] matris = new int[satir, sutun];

            //for (int i=0;i<satir;i++)
            //{
            //    for(int j=0;j<sutun;j++)
            //    {
            //        Console.Write("Matrisin {0} x {1} Değeri: ", i + 1, j + 1);
            //        matris[i, j] = Convert.ToInt16(Console.ReadLine());
            //    }
            //}

            //for (int m=0;m<satir;m++)
            //{
            //    Console.WriteLine();
            //    for (int n=0;n<sutun;n++)
            //    {

            //        Console.Write(matris[m, n]+" ");
            //    }
            //}


            //// Transpoze

            //Console.WriteLine();

            //for(int k=0;k<satir;k++)
            //{
            //    Console.WriteLine();
            //    for(int l=0;l<sutun;l++)
            //    {
            //        Console.Write(matris[l, k] + " ");
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //// Kat sayı ile çarpımı / klavyeden girilen sayı ile çarpılsın
            //int carpim;
            //Console.Write("Hangi kat sayı ile çarpılmasını istersiniz: ");
            //carpim = Convert.ToInt32(Console.ReadLine());

            //for(int x=0;x<satir;x++)
            //{
            //    Console.WriteLine(); 
            //    for(int y=0;y<sutun;y++)
            //    {

            //        Console.Write(matris[x, y] * carpim + " ");

            //    }
            //}

            //Console.Read();

            // ********************************************************************************************************************

            // Determinant ALMA!!!

            int a, b, c, d, sonuc;
            Console.Write("A Değeri: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("B Değeri: ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.Write("C Değeri: ");
            c = Convert.ToInt16(Console.ReadLine());
            Console.Write("D Değeri: ");
            d = Convert.ToInt16(Console.ReadLine());

            sonuc = Math.Abs((a * d) - (b * c));    // Mutlak değerli ifade. 
            Console.Write("Determinant: " + sonuc);


            Console.Read();


        }
    }
}
