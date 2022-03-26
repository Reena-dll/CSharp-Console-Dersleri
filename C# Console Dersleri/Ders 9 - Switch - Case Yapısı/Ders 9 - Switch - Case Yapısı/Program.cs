using System;

namespace Ders_9___Switch___Case_Yapısı
{
    class Program
    {
        static void Main(string[] args)
        {
            // Switch ve Case çok fazla dallanma koşul ifadelerinde kullanılan komutlardır.
            // Dallanmanın fazla olduğu durumlarda fazla kod satırından kurtulup, daha az satırda aynı işlevi yapmamızı sağlıyor.

            // Klavyeden girilen sayıya göre haftanın ilgili gününü veren programı oluşturun.

            //int sayi;

            //Console.Write("1 ile 7 arasında bir sayı giriniz= ");
            //sayi = Convert.ToInt16(Console.ReadLine());

            //switch(sayi)
            //{
            //    case 1: Console.Write("Gün= Pazartesi");
            //        break;                                     // Break komutu ise kırılmayı sağlıyor. Case1 için işlem satırını sonlandırıyor.
            //   case 2: Console.Write("Gün= Salı");
            //        break;
            //    case 3: Console.Write("Gün= Çarşamba");
            //       break;
            //  case 4: Console.Write("Gün= Perşembe");
            //       break;
            //   case 5: Console.Write("Gün= Cuma");
            //      break;
            //    case 6: Console.Write("Gün= Cumartesi");
            //        break;
            //    case 7: Console.Write("Gün= Pazar");
            //        break;

            //   default: Console.Write("Hatalı Gün Girişi");
            //       break;
            //}

            //Console.Read();


            //----------------------------------------------------------------------------------------------

            //Kullanıcıdan her hangi bir mevsim değeri isteyelim. Girmiş olduğu mevsime göre ayları getirelim

            //string mevsim;

            //Console.Write("Lütfen bir mevsim girin= ");
            //mevsim = Console.ReadLine();

            //switch(mevsim)
            //{
            //    case "yaz": Console.Write("Yaz mevsiminin ayları: Haziran, Temmuz ve Ağustos");
            //        break;
            //    case "sonbahar": Console.Write("Sonbahar mevsiminin ayları: Eylül, Ekim ve Kasım");
            //        break;
            //    case "kış": Console.Write("Kış mevsiminin ayları: Aralık, Ocak ve Şubat");
            //        break;
            //    case "ilkbahar": Console.Write("İlkbahar mevsiminin ayları: Mart, Nisan ve Mayıs");
            //        break;

            //    default: Console.Write("Hatalı mevsim girişi");
            //        break;
            //}

            //Console.Read();


            // İstanbul iline 8 tane şehrin kaç km uzak olduğunu switch case yapısı ile çözün.

            //string sehir;

            //Console.Write("Lütfen şehri giriniz: ");
            //sehir = Console.ReadLine();

            //switch(sehir)
            //{
            //    case "adana": Console.Write("İstanbul ilinin Adana'ya uzaklığı 939km'dir");
            //            break;
            //    case "ankara": Console.Write("İstanbul ilinin Ankara'ya uzaklığı 453km'dir");
            //        break;
            //    case "antalya": Console.Write("İstanbul ilinin Antalya'ya uzaklığı 724km'dir");
            //        break;
            //    case "bursa": Console.Write("İstanbul ilinin Bursa'ya uzaklığı 243km'dir");
            //        break;
            //    case "elazığ": Console.Write("İstanbul ilinin Elazığ'a uzaklığı 1212km'dir");
            //        break;
            //    case "izmir": Console.Write("İstanbul ilinin İzmir'e uzaklığı 561km'dir");
            //        break;
            //    case "malatya":Console.Write("İstanbul ilinin Malatya'ya uzaklığı 1114km'dir");
            //        break;
            //    case "trabzon":Console.Write("İstanbul ilinin Trabzon'a uzaklığı 1070km'dir");
            //        break;

            //    default: Console.Write("Hatalı şehir girdiniz");
            //        break;
            //}
            //Console.ReadLine();


            int sayi1,sayi2;
            string secim;

            Console.Write("Birinci Sayıyı Giriniz: ");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz: ");
            sayi2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("İşlem Seçiniz");
            secim = Console.ReadLine();

            switch (secim)
            {
                case "+":
                    Console.Write(sayi1+sayi2);
                    break;                                     // Break komutu ise kırılmayı sağlıyor. Case1 için işlem satırını sonlandırıyor.
                case "-":
                    Console.Write(sayi1-sayi2);
                    break;
                case "*":
                    Console.Write(sayi1*sayi2);
                    break;

                default:
                    Console.Write("Hatalı Seçim Girişi");
                    break;
            }

            Console.Read();

        }
    }
}
