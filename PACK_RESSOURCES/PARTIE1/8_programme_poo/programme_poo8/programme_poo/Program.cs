using System;
using System.Collections.Generic;
using System.Linq;

namespace programme_poo
{
    class Personne
    {
        static int nombreDePersonnes = 0;

        public string nom { get; init; }
        public int age { get; set; }
        public string emploi { get; set; }

        int numeroPersonne;

        /*public string GetNom()
        {
            return nom;
        }*/

        /*public void SetNom(string value)
        {
            nom = value;
        }*/

        public Personne()
        {
            nombreDePersonnes++;
            this.numeroPersonne = nombreDePersonnes;
        }

        public Personne(string nom, int age, string emploi = null) : this()
        {
            this.nom = nom;
            this.age = age;
            this.emploi = emploi;
        }

        public void Afficher()
        {
            Console.WriteLine("PERSONNE N°" + numeroPersonne);
            Console.WriteLine("  NOM : " + nom);
            Console.WriteLine("  AGE : " + age + " ans");
            if (emploi == null)
            {
                Console.WriteLine("  Aucun emploi spécifié");
            }
            else
            {
                Console.WriteLine("  EMPLOI : " + emploi);
            }
        }

        public static void AfficherNombreDePersonnes()
        {
            Console.WriteLine("Nombre total de personnes : " + nombreDePersonnes);
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

            //Personne personne1 = new Personne("Paul", 30, "Développeur");
            //personne1.Afficher();

            //Console.WriteLine("nom personne1: " + personne1.nom);

            /*
            Personne personne2 = new Personne("Jacques", 35, "Professeur");
            personne2.Afficher();*/

            /*var personnes = new List<Personne> {
                new Personne("Paul", 30, "Développeur"),
                new Personne("Jacques", 35, "Professeur"),
                new Personne("David", 20, "Etudiant"),
                new Personne("Juliette", 8, "CP"),
            };

            //personnes = personnes.OrderBy(p => p.nom).ToList();

            foreach (var personne in personnes)
            {
                personne.Afficher();
            }

            Personne.AfficherNombreDePersonnes(); */

            //var personne1 = new Personne("Paul", 30);
            var personne1 = new Personne() { age = 30, nom = "Paul", emploi="Ingénieur" };

            Console.WriteLine("Nom de la personne : " + personne1.nom);

            //personne1.nom = "Toto";


            personne1.Afficher();


            // EMPLOI : (non spécifié)
        }
    }
}
