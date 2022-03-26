using System;

namespace Ders_16___Diziler_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Elemanları girilmiş dizide ki pozitif ve tek sayıları listeleyelim.

            //int[] sayilar = { 4, 1, 7, -8, 23, 14, 51, 84, -75, 26, -8, 9 };

            //foreach(int i in sayilar)
            //{
            //    if(i>0 && i %2==1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();

            //int[] sayilar = new int[5];

            //for(int i=0;i<5;i++)
            //{
            //    Console.Write("Sayıyı Girin: ");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());

            //}

            //Array.Sort(sayilar);    // Küçükten büyüğe sıralama komutu

            // Console.WriteLine(sayilar[0]); // Küçükten büyüğe sıralanmış bir dizinin birinci sırasındakini çeker. Yani en küçük sayıyı.
            // Console.WriteLine(sayilar[5]); // Küçükten büyüğe sıralanmış bir dizinin sonuncu sorasındakini çeker. Yani en büyük sayıyı.
            // Console.WriteLine(sayilar.Lenght); // Dizinin boyutu uzunluğuunu belirtir.

            // foreach(int i in sayilar)
            //{
            //    Console.WriteLine(i);
            //}



            //Console.ReadLine();

            // Klavyeden girilmiş olan değerleri tersten yazdıralım. Örneğin 1 3 2 7 4 girildiyse 4 7 2 3 1 gibi sıralansın. Son giren değer ilk çıksın.

            int[] sayilar = new int[5];

            for (int i=0;i<5;i++)
            {
                Console.Write("Sayı Giriniz: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Reverse(sayilar);       // Son giren değer ilk çıksın komutu. Sırlama.Diziyi tersten sıralar.



            foreach(int i in sayilar)
            {
                Console.WriteLine(i);

            }
            Console.Read();

        }
    }
}
