using System;
using System.Data.SqlClient;

namespace Ders_18___Char_Değişkeni
{
    class Program
    {
        static void Main(string[] args)
        {
            // Char tek bir karakteri tutar hafızada. String gibi fakat tek karakterlik veriler için kullanılır. Fiziksel bellek olarak çok az yer kaplar. Değişkene sadece bir karakter atayabiliriz. 
            //char harf;
            //harf = 'G';
            //Console.WriteLine(harf);
            //Console.Read();

            // Bay bayan örneği


            //char cinsiyet;

            //Console.Write("Cinsiyetiniz Nedir E-K ? ");
            //cinsiyet = Convert.ToChar(Console.ReadLine());

            //if(cinsiyet=='E'|| cinsiyet=='e')
            //{
            //    Console.WriteLine("Cinsiyetiniz Erkek.");
            //}
            //else if (cinsiyet=='K'|| cinsiyet=='k')
            //{
            //    Console.WriteLine("Cinsiyetiniz Kadın.");
            //}

            //else
            //{
            //    Console.WriteLine("Girmiş olduğunuz değer yanlış.");
            //}
            //Console.ReadLine();


            // Klavyeden girilen dersin baş harfine göre dersi getirelim.

            Console.WriteLine("***** YGS DERSLERİ MENÜSÜ *****");
            Console.WriteLine();

            Console.WriteLine("Türkçe...");
            Console.WriteLine("Matematik...");
            Console.WriteLine("Sosyal Bilgisi...");
            Console.WriteLine("Fen Bilgisi...");
            Console.WriteLine();
            char ders;
            Console.Write("Almak istediğiniz dersin baş harfini giriniz= ");
            ders = Convert.ToChar(Console.ReadLine());

            if (ders == 'T' || ders == 't')
            {
                Console.WriteLine("Tebrikler Türkçe Dersini Seçtiniz");
            }

            else if (ders == 'M' || ders == 'm')
            {
                Console.WriteLine("Tebrikler Matematik Dersini Seçtiniz");

            }
            else if (ders =='S'||ders=='s')
            {
                Console.WriteLine("Tebrikler Sosyal Bilgisi Dersini Seçtiniz");
            }
            else if (ders == 'F'||ders=='f')
            {
                Console.WriteLine("Tebrikler Fen Bilgisi Dersini Seçtiniz");

            }
            else
            {
                Console.WriteLine("Girmiş olduğunuz ders kodu başarısız.");
            }

            Console.ReadLine();
        }
    }
}
