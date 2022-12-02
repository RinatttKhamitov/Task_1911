using System;

namespace Тумаков
{
    class Program
    {
        static void Main(string[] args)
        {
            ACipher a = new ACipher();
            Console.WriteLine(a.decode("abc"));
            Console.ReadLine();
            BCipher b = new BCipher();
            Console.WriteLine(b.decode("abc", 75675));
            Console.WriteLine(b.encode("abc", 27));
            Console.ReadLine();
            Console.Clear();
        }
       
    }
}
