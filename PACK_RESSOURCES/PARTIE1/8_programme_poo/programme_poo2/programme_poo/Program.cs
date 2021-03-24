using System;
using System.Collections.Generic;

namespace programme_poo
{
    class Personne
    {
        string nom;
        int age;
        string emploi;

        public Personne(string nom, int age, string emploi)
        {
            this.nom = nom;
            this.age = age;
            this.emploi = emploi;
        }

        public void Afficher()
        {
            Console.WriteLine("NOM : " + nom);
            Console.WriteLine("  AGE : " + age + " ans");
            Console.WriteLine("  EMPLOI : " + emploi);
        }
    }

    class Program
    {
        /*static void AfficherInfosPersonne(string nom, int age, string emploi)
        {
            Console.WriteLine("NOM : " + nom);
            Console.WriteLine("  AGE : " + age + " ans");
            Console.WriteLine("  EMPLOI : " + emploi);
        }*/

        static void Main(string[] args)
        {
            // nom, age, emploi
            /*var noms = new List<string> { "Paul", "Jacques", "David", "Juliette" };
            var ages = new List<int> { 30, 35, 20, 8 };
            var emplois = new List<string> { "Développeur", "Professeur", "Etudiant", "CP" };

            for (int i = 0; i < noms.Count; i++)
            {
                AfficherInfosPersonne(noms[i], ages[i], emplois[i]);
            }*/

            Personne personne1 = new Personne("Paul", 30, "Développeur");
            personne1.Afficher();

            Personne personne2 = new Personne("Jacques", 35, "Professeur");
            personne2.Afficher();



        }
    }
}
