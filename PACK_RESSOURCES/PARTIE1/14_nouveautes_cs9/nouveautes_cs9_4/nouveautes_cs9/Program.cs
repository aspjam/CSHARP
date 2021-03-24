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

    /*record PersonneRecord
    {
        public string nom { get; init; }
        public int age { get; init; }

        public PersonneRecord(string nom, int age)
        {
            this.nom = nom;
            this.age = age;
        }

        public void Deconstruct(out string nom, out int age)
        {
            nom = this.nom;
            age = this.age;
        }

        public void Afficher()
        {
            Console.WriteLine("nom: " + nom + " - age: " + age + " ans");
        }
    }*/

    /* Immutable */
    record PersonneRecord(string nom, int age);

    record PersonneRecordAffichable : PersonneRecord
    {
        public PersonneRecordAffichable(string nom, int age) : base(nom, age)
        {
        }

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

            var personne1 = new PersonneRecordAffichable("Toto", 20); /* { nom = "Toto", age = 20 };*/
            var personne2 = personne1 with { nom = "Tata" };

            //personne1.nom = "Tata";
            var (nom, age) = personne1;

            Console.WriteLine("nom: " + personne1.nom);
            Console.WriteLine("nom: " + nom);
            Console.WriteLine("age: " + age);


            personne1.Afficher();
            //personne2.Afficher();

            //Console.WriteLine(personne1 == personne2);

            /* Types simples (int, float, char...) -> Value Type (valeur)
             * structures -> Value Type (valeur = les valeurs des champs)
             * class -> Reference Type (valeur = adresse de l'objet)
             * List<string> -> Reference Type (valeur = adresse de l'objet)
             */

        }
    }
}
