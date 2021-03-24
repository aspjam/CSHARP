using System;
using System.Collections.Generic;
using System.Linq;

namespace programme_poo
{

    class Etudiant : Personne
    {
        string infoEtudes;
        public Personne professeurPrincipal { get; init; }

        public Etudiant(string nom, int age, string infoEtudes) : base(nom, age, "Etudiant")
        {
            this.infoEtudes = infoEtudes;
        }

        public override void Afficher()
        {
            AfficherNomEtAge();
            Console.WriteLine("  Etudiant en " + infoEtudes);

            if (professeurPrincipal != null)
            {
                Console.WriteLine("  Le professeur principal est :");
                professeurPrincipal.Afficher();
            }
            
            // Le professeur principal est :
            // afficher les informations
        }

    }

    class Personne
    {
        static int nombreDePersonnes = 0;

        protected string nom;
        protected int age;
        string emploi;

        protected int numeroPersonne;


        public Personne(string nom, int age, string emploi = null)
        {
            this.nom = nom;
            this.age = age;
            this.emploi = emploi;

            nombreDePersonnes++;
            this.numeroPersonne = nombreDePersonnes;
        }

        public virtual void Afficher()
        {
            AfficherNomEtAge();
            if (emploi == null)
            {
                Console.WriteLine("  Aucun emploi spécifié");
            }
            else
            {
                Console.WriteLine("  EMPLOI : " + emploi);
            }
        }

        // AfficherNomEtAge

        protected void AfficherNomEtAge()
        {
            Console.WriteLine("PERSONNE N°" + numeroPersonne);
            Console.WriteLine("  NOM : " + nom);
            Console.WriteLine("  AGE : " + age + " ans");
        }

        public static void AfficherNombreDePersonnes()
        {
            Console.WriteLine("Nombre total de personnes : " + nombreDePersonnes);
        }
    }

    class Program
    {
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
            //var personne1 = new Personne() { age = 30, nom = "Paul", emploi="Ingénieur" };
            

            var etudiant = new Etudiant("David", 20, "école d'ingénieur informatique") {
                professeurPrincipal = new Personne("Jacques", 35, "Professeur")
            };

            //etudiant.professeurPrincipal = new Personne("Jacques", 35, "Professeur");

            //var etudiant = new Etudiant("Jacques", 35, "Professeur");
            etudiant.Afficher();

        }
    }
}
