using System;

namespace Ders_13___Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diziler: Sıralı listelerdir. Çok sayıda değişken var iken bunları kısayoldan okuma işlemi. Köşeli parantez ile gösterilir. []

            //int[] sayilar = { 10, 45, 21, 35, 64, 75, 84, 26 };
            //Console.Write(sayilar[0]) ;    // Köşeli parantez içine yazılan rakam bizim elemanlarımızın sırasıdır. Hangi sıra seçilir ise o elemanımız gelir. Elemanların indexi yani başlangıcı '0'dan başlar.
            //Console.Read(); 

            //string[] isimler = { "Ali", "Veli", "Ahmet", "Ayşe", "Ebrar", "Oğuzhan", "Murat", "Meryem" };
            //Console.Write(isimler[5]);
            //Console.Read();

            // 3 tane şehir girelim. Dizi oluşturalım ardından diziyi listeleyim.

            string [] sehirler = new string[3];
            for (int i=0;i<3;i++)
            {
                Console.Write("Şehir: ");
                sehirler[i] = Console.ReadLine();
            }
            Console.WriteLine("*****Şehirler Listesi*****");
            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine(sehirler[i]);
            }
            Console.Read();
        }
    }
}
