using System;

namespace premier_programme
{
    class Program
    {
        static void Main(string[] args) {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Quel est ton nom ? ");
            string nom = Console.ReadLine();

            Console.Write("Quel est ton age ? ");
            string age = Console.ReadLine();
            
            Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + age + " ans");


        }
    }
}
