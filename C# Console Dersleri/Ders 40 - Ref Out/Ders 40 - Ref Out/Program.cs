using System;

namespace Ders_40___Ref_Out
{
    class Program
    {
        static void arttir(/* ref */out int s)
        {
            s = 12;
            s++;
        }
        static void Main(string[] args)
        {
            //int a = 9;
            //arttir(ref a);
            //Console.Write(a);

            int a;
            arttir(out a);
            Console.WriteLine(a);


            Console.Read();
        }
    }
}
