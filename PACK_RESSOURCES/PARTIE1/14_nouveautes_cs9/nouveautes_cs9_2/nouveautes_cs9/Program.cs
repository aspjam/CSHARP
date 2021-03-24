using System;

namespace nouveautes_cs9
{
    class Personne
    {
        public string nom { get; init; }
        public int age { get; set; }

        public void Afficher()
        {
            Console.WriteLine("nom: "+ nom + " - age: " + age + " ans");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var personne1 = new Personne() { nom = "Toto", age = 20 };
            //personne1.nom = "Tata";
            personne1.Afficher();

            Console.WriteLine("nom de la personne " + personne1.nom);

            /*Console.WriteLine("Hello World!");
            foreach(var arg in args)
            {
                Console.WriteLine(arg);
            }*/
        }
    }
}
