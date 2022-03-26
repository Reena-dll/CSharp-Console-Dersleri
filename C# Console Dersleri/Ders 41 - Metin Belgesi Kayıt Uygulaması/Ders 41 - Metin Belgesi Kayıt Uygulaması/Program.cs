using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ders_41___Metin_Belgesi_Kayıt_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            string dosyaismi;

            Console.Write("Lütfen dosya ismini girin :");

            dosyaismi = Console.ReadLine();

            

            string dosya = @"C:\Users\Reena\Desktop\Notlar\ " + dosyaismi + ".txt";
            FileStream fs1 = new FileStream(dosya, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs1);

            string veri;

            Console.Write("dosya'ya yazmak istediklerinizi buraya yazın  :");

            veri = Console.ReadLine();

            sw.WriteLine(veri);

            sw.Close();


            Console.Read();

        }
    }
}
