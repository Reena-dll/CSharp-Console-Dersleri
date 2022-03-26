using System;

namespace Ders_12___Döngüler_3___While__
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrana 10 kere Merhaba Eskişehir programı. For ve While ile.

            //int i;

            //for (i=1;i<=10; i++)
            //{
            //    Console.WriteLine("Merhaba Eskişehir");
            //}
            //Console.Read();

            //int i;
            //i = 1;
            //while(i <= 10)   // i küçük 10 olana kadar
            //{
            //    Console.WriteLine("Merhaba Çanakkale");
            //    i++;

            //}
            //Console.Read();

            //-------------------------------------------------------------------------------------------------------------------

            // 1 ile 10 arasında ki sayıları listeyelen program

            //int i;
            //i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.Read();

            //-------------------------------------------------------------------------------------------------------------------

            // Klavyeden tek sayı girilene kadar kullanıcıdan sayı isteyen program.

            //int sayi;
            //Console.WriteLine("Bir Sayı Gir: ");
            //sayi = Convert.ToInt16(Console.ReadLine()); 

            //while (sayi %2 == 0)
            //{
            //    Console.WriteLine("Bir Sayı Gir: ");
            //    sayi = Convert.ToInt16(Console.ReadLine());

            //}
            //Console.WriteLine("Tek Sayı Girdiniz");
            //Console.Read();

            // Kullanıcının klavyeden girdiği sayının faktöriyel hesabını yapıp bulan program.

            int sayi;
            int fakt;

            fakt = 1;
            Console.Write("Bir Sayı Giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            while (sayi>=1)
            {
                fakt = fakt * sayi;
                sayi = sayi - 1;
             
            }
            Console.WriteLine("Girdiğiniz sayının faktöriyeli "+fakt);

            Console.ReadLine();

        }
    }
}
