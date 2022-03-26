using System;

namespace Ders_6___Karar_Yapıları___İF___ELSE__
{
    class Program
    {
        static void Main(string[] args)
        {
            //string isim;

            //isim = "Mehmet";
            //if (isim == "Mehmet")  // İF = EĞER anlamını taşır. Parantez içine EĞER metodunun sorgusu yazılır. "==" ifadesi eşittir anlamına gelmektedir.
            //{
            //    Console.Write("Doğru İsim Girişi");
            //}
            //else
            //{
            //    Console.Write("Hatalı İsim");
            //}

            //Console.Read();


            //string isim;

            //Console.Write(" Kullanıcı Adınızı Girin= ");
            //isim = Console.ReadLine();

            //if (isim=="Oğuzhan")
            //{
            //    Console.Write("Doğru Kullanıcı Adı");
            //}
            //else
            //{
            //    Console.Write("Yanlış Kullanıcı Adı");

            //}
            //Console.Read();

            //string sehir;

            //Console.WriteLine("Türkiye'nin başkenti neresidir ?");
            //sehir = Console.ReadLine();

            //if (sehir=="ankara")
            //{
            //    Console.Write("Tebrikler Doğru Cevap verdiniz");
            //}
            //else if(sehir == "Ankara")
            //{
            //    Console.Write("Tebrikler Doğru Cevap verdiniz");
            //}

            //else
            //{
            //    Console.Write("Yanlış Cevap Verdiniz");
            //}
            //Console.ReadLine();


            // KLAVYEDEN GİRİLEN BİR  DEĞERİN POZİTİF Mİ NEGATİF Mİ OLDUĞUNU SÖYLEYEN PROGRAM:

            //int sayi;

            //Console.Write("Lütfen Bir Sayı Giriniz= ");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi <0 )
            //{
            //    Console.Write("Sayı Negatiftir");

            //}
            //else
            //{
            //    Console.Write("Sayı Pozitiftir");
            //}
            //Console.Read();

            // Klavyeden Girilen Notun Kalıp kalmadığını hesaplayan program

            int sinav1, sinav2, ortalama;
            

            Console.Write("Lütfen Birinci Sınavınızı Giriniz= ");
            sinav1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen İkinci Sınavınızı Giriniz= ");
            sinav2 = Convert.ToInt32(Console.ReadLine());

            ortalama = (sinav1 + sinav2) / 2;
            Console.WriteLine("Ortalama " + ortalama);

            if (ortalama<50)
            {
                Console.Write("Dersten Kaldınız");
            }
            else
            {
                Console.Write("Dersten Geçtiniz");
            }

            Console.ReadLine();
        }
    }
}
