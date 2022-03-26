using System;

namespace Ders_23___Arka_Plan_Rengi
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.BackgroundColor = ConsoleColor.Blue; // Programın arka plan rengini düzenler.
            //Console.ForegroundColor = ConsoleColor.Yellow;  // Programın yazı rengini belirler.
            //Console.Title = "Oğuzhan Sadıkoğlu";   // Programın başlığını düzenler.
            //Console.Clear();  // Programı temizler. Bunu yapmadan yukarıdakileri yapamayız.


            //Console.Write("Selamun Aleyküm");


            //Console.Read();


            // kullanıcıdan sayı alalım ilgili sayıya göre rengi getirelim.

            int sayi;

            //Console.Write("Lütfen Bir Sayı Giriniz: ");
            //sayi = Convert.ToInt16(Console.ReadLine());

            // UZUN YOL !!!!!

            //switch(sayi)
            //  {
            //      case 1: Console.BackgroundColor = ConsoleColor.Red; Console.Clear();
            //          break;
            //      case 2: Console.BackgroundColor = ConsoleColor.Green; Console.Clear();
            //          break;
            //      case 3: Console.BackgroundColor = ConsoleColor.Yellow; Console.Clear();
            //          break;
            //      case 4:
            //          Console.BackgroundColor = ConsoleColor.Blue; Console.Clear();
            //          break;
            //      case 5:
            //          Console.BackgroundColor = ConsoleColor.Magenta; Console.Clear();
            //          break;
            //      case 6:
            //          Console.BackgroundColor = ConsoleColor.Cyan; Console.Clear(); 
            //          break;
            //      case 7:
            //          Console.BackgroundColor = ConsoleColor.Gray; Console.Clear();
            //          break;
            //      case 8:
            //          Console.BackgroundColor = ConsoleColor.White; Console.Clear();
            //          break;
            //      case 9:
            //          Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            //          break;
            //      case 10:
            //          Console.BackgroundColor = ConsoleColor.DarkBlue; Console.Clear();
            //          break;
            //      case 11:
            //          Console.BackgroundColor = ConsoleColor.DarkYellow; Console.Clear();
            //          break;
            //      case 12:
            //          Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.Clear();
            //          break;
            //      case 13:
            //          Console.BackgroundColor = ConsoleColor.DarkRed; Console.Clear();
            //          break;
            //      case 14:
            //          Console.BackgroundColor = ConsoleColor.DarkGray; Console.Clear();
            //          break;
            //      case 15:
            //          Console.BackgroundColor = ConsoleColor.DarkGreen; Console.Clear();
            //          break;
            //      case 16:
            //          Console.BackgroundColor = ConsoleColor.DarkCyan; Console.Clear();
            //          break;

            //      default: Console.WriteLine("Yanlış değer girdiniz");
            //          break;



            // Daha kısa bir yol     




            Console.Write("Lütfen Bir Sayı Girin: ");
            ConsoleColor renk = (ConsoleColor)Convert.ToInt16(Console.ReadLine());  // UNBAX İŞLEMİ.
            Console.BackgroundColor = renk;
            Console.Clear();
            Console.Read();

        }
       

     }
   }

