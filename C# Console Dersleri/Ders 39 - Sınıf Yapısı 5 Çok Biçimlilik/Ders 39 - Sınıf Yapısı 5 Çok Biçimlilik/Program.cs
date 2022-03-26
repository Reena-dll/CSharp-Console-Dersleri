using System;

namespace Ders_39___Sınıf_Yapısı_5_Çok_Biçimlilik
{
    class Program
    {
        class insan
        {
            public virtual void selamver()
            {
                
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Title = "Örnek Şubat 2020";
                Console.WriteLine("Merhaba Soğuk Kış Günleri");

            }
        }

        class Türk : insan
        {
            public override void selamver()
            {
                Console.WriteLine("Esenlikler");
            }
        }

        class Fransız : insan
        {
            public override void selamver()
            {
                Console.WriteLine("Bonjour");
            }
        }

        class ingiliz : insan
        {
            public override void selamver()
            { 

                Console.BackgroundColor = ConsoleColor.Red;
                
                Console.WriteLine("Hello");
                
            }
        }

        class Azeri: insan
        {
            public override void selamver()
            {
                Console.WriteLine("Salam");
            }
        }

        static void Main(string[] args)
        {
            Azeri az = new Azeri();
            az.selamver();
            Console.Read();


        }
    }
}
