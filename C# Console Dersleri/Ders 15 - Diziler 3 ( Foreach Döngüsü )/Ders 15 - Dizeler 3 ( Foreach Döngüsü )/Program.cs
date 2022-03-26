using System;

namespace Ders_15___Dizeler_3___Foreach_Döngüsü__
{
    class Program
    {
        static void Main(string[] args)
        {
            // Foreach: Bir dizi veya nesnenin tüm elemanlarına ulaşmak için kullanılır. Foreach( Değişken_Türü, Değişken_Adı, in , Dizi_Adı)

            // Her bölgeden 7 tane şehir yazdıralım. Ardından yazdığımız bu şehirleri foreach döngüsü ile döndürelim

            //string[] sehirler = { "Mersin", "İzmir", "Kocaeli", "Artvin", "Ankara", "Erzurum", "Şanlıurfa" };

            //foreach(String i in sehirler)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Read();

            //int[] sayilar = { 1, 4, 8, 52, 41, 75, 126, 85, 24 };

            //foreach(int i in sayilar)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadLine();

            //    int[] sayilar = { 1, 4, 8, 9, 6 };
            //    int toplam = 0;
            //    foreach (int i in sayilar)
            //    {
            //        toplam = toplam + i;

            //    }

            //    Console.WriteLine("Toplam= "+toplam);

            //    Console.Read();

            // 2 ye tam bölünen elemanları alalım

            //int[] rakamlar = { 1, 7, 5, 4, 8, 6, 9, 3 };

            //foreach(int i in rakamlar)
            //{
            //    if(i %2==0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //Console.ReadLine();


            // Dizide ki bütün elemanların çarpımı veren program

            int[] degeler = { 1, 2, 3, 4, 5, 6 };

            int sonuc = 1;

            foreach(int i in degeler)
            {

                sonuc = i * sonuc;

            }
            Console.Write(sonuc);

            Console.Read();


        }
    }
}
