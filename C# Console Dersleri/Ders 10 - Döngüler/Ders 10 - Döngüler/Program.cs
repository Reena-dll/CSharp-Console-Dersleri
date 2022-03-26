using System;

namespace Ders_10___Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Döngüler= Tekrar gerektiren ifadelerde kullanılan komutlardır.
            // a+=1 bu ifade a++ aynı ifadedir. İkisi de her defasında birer birer arttır anlamı taşır.

            // Ekrana 10 defa Merhaba Dünya yazdıran komut.

            //int i;
            //for (i=1 ; i<=30 ; i++)
            //{
            //    Console.WriteLine("Merhaba Dünya");
            //} 
            //Console.Read();

            //---------------------------------------------------------------------------------------

            // 1 ile 10 arasında sayıları alt alta yazdıran program

            //int i;
            //for(i=1;i<=10;i++)
            //{
            //    Console.WriteLine("Sayı " + i);
            //}
            //Console.Read();  

            //int j;
            //for(j=0;j<=20;j+=3)
            //{
            //    Console.WriteLine(j);
            //}
            //Console.Read();

            // 1 ile 10 arasında ki sayıları toplayıp ekrana yazdıran program (1 ile 10 dahil )

            //int sayac, toplam;
            //toplam = 0;
            //for(sayac=1; sayac<=10; sayac++)

            //{
            //    toplam = sayac+toplam;              
            //}
            //Console.Write(toplam);
            //Console.ReadLine();

            // 1 ile 10 arasında çift tam sayıları toplayan program 

            //int sayac, toplam;
            //toplam = 0;

            //for(sayac=0;sayac<=10;sayac+=2)
            //{
            //    toplam = sayac + toplam;
            //}
            //Console.Write(toplam);
            //Console.Read();

            // 1 ile 10 arasında tek tam sayıları toplayan program 

            int sayac, toplam;
            toplam = 0;

            for(sayac=1;sayac<=10;sayac+=2)
            {
              toplam = sayac + toplam;
            }
            Console.Write(toplam);
            Console.Read();
        }
    }
}
