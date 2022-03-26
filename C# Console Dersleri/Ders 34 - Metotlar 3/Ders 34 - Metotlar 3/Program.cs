using System;

namespace Ders_34___Metotlar_3
{
    class Metotlar
    {

        int topla(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {

            Metotlar mtr = new Metotlar();
            int z;
            z = mtr.topla(1, 3);
            Console.Write("Sonuç: " + z);
            Console.Read();
            
        }
    }
}
 