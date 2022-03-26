using System;

namespace Ders_3___İnt_Değişken_Tipi
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi1, sayi2, toplam; // int değişkeni + 2 milyar ve - 2 milyar arasında ki değerleri alabilen değişken tipimiz. Sadece tam sayılarda geçerlidir. Aritmatik işlemler yapılır. Ama string de aritmatik işlemler yapılamaz.
            //sayi1 = 5; // int tipinde ki sayi1 değişkenine değer atadık.
            //sayi2 = 7; // int tipinde ki sayi2 değişkenine değer atadık.
            //toplam = sayi1 + sayi2; // Toplam değişkenine sayi1 ile sayi2 nin toplamını atadık.
            //Console.Write("Toplam = {0}", toplam);
            //Console.Read(); // Enter tuşuna basana kadar ekranda oku komutu.

            //int A, B, carpim;
            //A = 8;
            //B = 7;
            //carpim = A * B;
            //Console.WriteLine("A * B= {0}",carpim);

            //Console.Read();
            // ---------------------------------------------------------------------
            //int deger1, deger2, bolum;
            //deger1 = 12;
            //deger2 = 22;
            //bolum = (deger1 + deger2) / 2;
            //Console.Write(bolum);

            //Console.Read();
            // ---------------------------------------------------------------------
            string ad, soyad, numara;
            int sinav1, sinav2, sinav3, proje, ortalama;
            Console.WriteLine("***** Öğrenci Bilgileri *****");
            Console.WriteLine();
            ad = "Mehmet";
            soyad = "Yücedağ";
            numara = "12345678";

            Console.WriteLine("İsim: "+ ad);
            Console.WriteLine("Soyad: " +soyad);
            Console.WriteLine("Numara: "+numara);

            Console.WriteLine();
            Console.WriteLine("***** Not Bilgileri *****");
            Console.WriteLine();

            sinav1 = 60;
            sinav2 = 70;
            sinav3 = 100;
            proje  = 90;
            Console.WriteLine("Sınav1= " + sinav1);
            Console.WriteLine("Sınav2= " + sinav2);
            Console.WriteLine("Sınav3= " + sinav3);
            Console.WriteLine("Proje= " + proje);

            Console.WriteLine();
            Console.WriteLine("***** Ortalama *****");
            Console.WriteLine();

            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;

            Console.WriteLine("Ortalamanız: " + ortalama);
            Console.Read();

            // ---------------------------------------------------------------------
        }
    }
}
