using System;

namespace premier_programme
{
    class Program
    {
        static void Main(string[] args) {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Quel est ton nom ? ");
            string nomDeLaPersonne = Console.ReadLine();
            Console.WriteLine("Bonjour, vous vous appelez " + nomDeLaPersonne);


        }
    }
}
