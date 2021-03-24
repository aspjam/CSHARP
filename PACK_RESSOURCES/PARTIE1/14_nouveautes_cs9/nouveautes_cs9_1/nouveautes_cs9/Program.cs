using System;

namespace nouveautes_cs9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            foreach(var arg in args)
            {
                Console.WriteLine(arg);
            }
        }
    }
}
