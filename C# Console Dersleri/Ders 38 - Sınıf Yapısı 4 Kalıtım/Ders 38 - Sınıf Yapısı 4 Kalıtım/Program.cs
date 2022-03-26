using System;

namespace Ders_38___Sınıf_Yapısı_4_Kalıtım
{
    class Program
    {
        static void Main(string[] args)
        {

            Ucak uck = new Ucak();

            uck.MARKA = "Türk Hava Yolları";
            uck.KALKİS = "Adana-Şakirpaşa";
            uck.VARİS = "İstanbul-Sabihagökçen";
            uck.AD = "oğuzhan";
            uck.SOYAD = "soyad";
            uck.CINSIYET = "erkek";
            uck.YAS = -23;

            Console.WriteLine("Havayolu: " + uck.MARKA);
            Console.WriteLine("Uçak Kalkış: " + uck.KALKİS);
            Console.WriteLine("Uçak Varış: " + uck.VARİS);
            Console.WriteLine("Adınız: " + uck.AD);
            Console.WriteLine("Soyadınız: " + uck.SOYAD);
            Console.WriteLine("Cinsiyetiniz: " + uck.CINSIYET);
            Console.WriteLine("Yaşınız: " + uck.YAS);

            Console.Read();
        }
    }
}
