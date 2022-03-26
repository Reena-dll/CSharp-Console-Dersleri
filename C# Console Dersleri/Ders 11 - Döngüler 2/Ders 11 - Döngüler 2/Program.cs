using System;

namespace Ders_11___Döngüler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1 ile 100 arasında 9 a tam bölünen sayıları listele.
            //int i;
            //for(i=1; i<=100; i++)
            //{
            //    if(i%9==0)
            //   {
            //        Console.WriteLine(i);
            //   }  

            //}
            //Console.Read();

            //--------------------------------------------------------------------------

            // 120 Sayısını tam bölen sayılar.

            //int sayi = 120;

            //for (int i =1; i<=120; i++)
            //{
            //    if (sayi % i==0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.Read();

            // Fibonacci örneği.

            int a = 1;
            int b = 1;
            int c;

            Console.WriteLine(a);
            Console.WriteLine(b);

            for( int i=1;i<=8;i++)
            {
                c = b + a;
                a = b;
                b = c;
                Console.WriteLine(c);
            }

            Console.Read();
            
        }
    }
}
