using System;

namespace String_Ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //string isim;
            //isim = "Oğuzhan";
            //Console.WriteLine("Merhaba " + isim);
            //Console.Read();

            //string sehir;
            //sehir = "İstanbul";
            //Console.Write(sehir);
            //Console.Read();

            // string isim; // String: Sözcük geçen yani veri tipi harflerle ve sayılarla oluşan verileri değişkene atama tipi. İsim atında String veri tipli bir değişken oluşturduk. String ifade de bir değişkene sahip iseniz o değişkende aritmatik işlemler yapılamaz.
            // Console.Write("İsminizi Giriniz : "); // Kullanıcıdan İsim istiyoruz.   
            // isim = Console.ReadLine(); // Kullanıcının girdiği metini İsim değişkenine atıyoruz.
            // Console.WriteLine("Hoş geldiniz: " + isim); // Kullanıcıdan aldığımız isim değişkenini yazdırma işleminde kullandık.
            // Console.Read(); // Ekranda okuttuk.

            //string ad, soyad, yas, meslek, sehir;
            //Console.WriteLine("Lütfen sırası ile Ad,Soyad,Yaş,Meslek ve Şehrinizi giriniz...");

            //ad = Console.ReadLine();
            //soyad = Console.ReadLine();
            //yas = Console.ReadLine();
            //meslek = Console.ReadLine();
            //sehir = Console.ReadLine();

            //Console.WriteLine("Ad: " + ad);
            //Console.WriteLine("Soyad: " + soyad);
            //Console.WriteLine("Yaş: " + yas);
            //Console.WriteLine("Meslek: " + meslek);
            //Console.WriteLine("Şehir: " + sehir);

            //Console.Read();

            //string ad;
            //Console.WriteLine("Lütfen İsminizi Girin: ");
            //ad = Console.ReadLine();
            //Console.WriteLine("Merhaba : {0}",ad);  // Parametre 0'dan başlar.
            //Console.Read();

            string ad, soyad, sehir;
            Console.WriteLine("Ad: ");
            ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı girin: ");
            soyad = Console.ReadLine();
            Console.WriteLine("Şehrinizi Girin: ");
            sehir = Console.ReadLine();

            Console.WriteLine("Ad: {0}  Soyad: {1}  Şehir: {2}", ad,soyad,sehir);
            Console.Read();

        }
    }
}
