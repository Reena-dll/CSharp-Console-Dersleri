using System;

namespace Ders_36___Sınıf_Yapısı_2_GET_SET_KAVRAMI
{
    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogr = new Ogrenci();
            ogr.ADI = "Baran";
            ogr.SOYADI = "YüceDağ";
            ogr.ALANI = "Türkçe-Matematik";
            ogr.YASI = 26;

            Console.WriteLine("Adı: " + ogr.ADI);
            Console.WriteLine("Soyadı: " + ogr.SOYADI);
            Console.WriteLine("Alanı: " + ogr.ALANI);
            Console.WriteLine("Yaşı: " + ogr.YASI);

            Console.Read();

        }
    }
}
