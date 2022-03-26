using System;

namespace Ders_21___Byte_Sbyte_Short_Ushort
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte sayi;
            //sayi = 255; // Byte tipinde değerler pozitif olmalı ve 0 ile 255 arasında olmalı.
            //Console.WriteLine(sayi);
            //Console.Read();

            //byte s1, s2;
            //s1 = 20;
            //s2 = 240;
            //Console.Write(s1 + s2);
            //Console.Read();


            // SByte ve Byte bellekte kapladıkları alan aynı. Fakat sbyte -120 pozitifte +127. Yani byte nin pozitife verdiği değerlerin yarısını negatife veriyor.

            //sbyte deger;
            //deger = 5;
            //Console.WriteLine(deger);
            //Console.Read();


            // HAVA DURUMU

            //Console.WriteLine(".....Doğru Anadolu Bölgesi Hava Durumu.....");
            //Console.WriteLine();

            //Console.WriteLine("1-Ocak 2016 Hava Tahminleri");
            //sbyte Erzurum, Malatya, Elazig;

            //Erzurum = -35;
            //Malatya = 3;
            //Elazig = -7;

            //Console.WriteLine("Erzurum Karlı: " + Erzurum+" Derecedir.");
            //Console.WriteLine("Malatya Çok Bulutlu: " + Malatya+" Derecedir.");
            //Console.WriteLine("Elazığ Karla Karışık Yağmurlu: " + Elazig+" Derecedir.");
            //Console.Read();

            // Short: + ve - 32.768 değerlerini alır.  

            //short s1, s2, s3;
            //s1 = 32767;
            //s2 = 30;
            //s3 = 40;                    
            //Console.WriteLine(s1 + s2 + s3);  // WriteLine işlemi int değişkeninde toplamayı yaptığından dolayı toplam byte sınırı geçmiş olsa da değeri verir.
            //Console.Read();


            // ushort ise Pozitif değerler alır. 64 bine kadar değer alır.

            ushort s1, s2;
            s1 = 1;
            s2 = 21;
            Console.Write(s1 + s2);
            Console.Read();
        }
    }
}
