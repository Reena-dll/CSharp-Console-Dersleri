using System;

namespace Ders_17___Random_Komutu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random komutu rastgele değerler getirmek için kullanılır.
            // Random rastgele(isim) = new random();  // Kullanım şekli.


            //Random rastgele = new Random();
            //int a;
            //a = rastgele.Next(0, 10);   // Parantez içerisinde ki değerlerden 0dan 9a kadar random bir değer verir. Parentez içerisinde ki değerlerden sağ tarafda ki değer random gelecek değerlere tabi tutulmaz. Yani random gelecek olan değerlerden 10 gelemez. Fakat 0 dahildir ve gelebilir.

            //Console.Write(a);
            //Console.Read();

            //Random rastgele = new Random();

            //int a, b;

            //a = rastgele.Next(0, 10);
            //b = rastgele.Next(0, 10);

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.Read();


            //Random rastgele = new Random();

            //int a;
            //a = rastgele.Next(50);     // Bu ise 0 dan 50'e kadar değerler arasından random değer seçer.
            //Console.WriteLine(a);
            //Console.Read();

            //Random rastgele = new Random();
            //int a;

            //a = rastgele.Next();      // Parantezin içi boş ise değişkenin tipinin alabileceği değerlere göre random bir değer verecek.
            //Console.WriteLine(a); 
            //Console.Read();

            // ŞEHİR ATAMA PROGRAMI

            Random rastgele = new Random();
            
            Console.WriteLine("***** Şehir Atama Programı *****");
            Console.WriteLine();
            string[] sehirler = { "Adana", "Antalya", "İzmir", "Aydın", "İstanbul",
                "Edirne", "Trabzon", "Samsun", "Ankara", "Konya", "Elazığ", "Malatya", "Diyerbakır", "Şanlıurfa" };          
            int a;

            a = rastgele.Next(0, sehirler.Length);            // Random komutumumuzun uzunluğuunu bizim dizimizin uzunluğuna eşitledik. bu sayede değer aralığıda uyuşmuş oldu.
            Console.WriteLine(a);
            Console.Write(sehirler[a]);
            Console.Read();

            
        }
    }
}
