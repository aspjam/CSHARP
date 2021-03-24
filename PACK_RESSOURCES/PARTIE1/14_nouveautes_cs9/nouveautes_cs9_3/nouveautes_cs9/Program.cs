using System;

namespace nouveautes_cs9
{
    struct PersonneStruct
    {
        public string nom { get; set; }
        public int age { get; set; }

        public void Afficher()
        {
            Console.WriteLine("nom: " + nom + " - age: " + age + " ans");
        }
    }

    record PersonneRecord
    {
        public string nom { get; set; }
        public int age { get; set; }

        public void Afficher()
        {
            Console.WriteLine("nom: " + nom + " - age: " + age + " ans");
        }
    }

    class PersonneClass
    {
        public string nom { get; set; }
        public int age { get; set; }

        public void Afficher()
        {
            Console.WriteLine("nom: "+ nom + " - age: " + age + " ans");
        }

        /*public override bool Equals(object obj)
        {
            PersonneClass objetAComparer = (PersonneClass)obj;
            if ((nom == objetAComparer.nom) && (age == objetAComparer.age)) return true;

            return false;
            //return base.Equals(obj);
        }*/
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 5;
            int b = 10;

            b = a;
            a = 6;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);*/

            var personne1 = new PersonneRecord() { nom = "Toto", age = 20 };
            var personne2 = personne1 with { };

            //personne1.nom = "Tata";


            personne1.Afficher();
            personne2.Afficher();

            Console.WriteLine(personne1 == personne2);

            /* Types simples (int, float, char...) -> Value Type (valeur)
             * structures -> Value Type (valeur = les valeurs des champs)
             * class -> Reference Type (valeur = adresse de l'objet)
             * List<string> -> Reference Type (valeur = adresse de l'objet)
             */

        }
    }
}
