using System;

namespace Ders_22___Bool_Değişkeni
{
    class Program
    {
        static void Main(string[] args)
        {
            // bool değişkeni koşullu yapılarda kullanılan mantıksal değişken
            //int sayi;
            //Console.Write("Bir Sayı Giriniz: ");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //bool durum1 = sayi > 0;
            //Console.WriteLine("Sayı Pozitif mi {0}", durum1);        
            //bool durum2 = sayi > 10;
            //Console.WriteLine("Sayı büyük mü 10'dan {0}", durum2);
            //Console.Read();


            int sifre;

            Console.Write("Şifreyi Girin: ");
            sifre = Convert.ToInt32(Console.ReadLine());
            bool durum1 = sifre == 12345;
            Console.WriteLine("Girdiğiniz şifre  {0}", durum1);

            Console.Read();


        }
    }
}
