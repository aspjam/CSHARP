using System;

namespace ListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List2.List<int> L = new List2.List<int>();
            L.Add(100);
            L.Add(13);
            L.Add(56);
            L.Add(200);
            L.Sort();

        }
    }
}
