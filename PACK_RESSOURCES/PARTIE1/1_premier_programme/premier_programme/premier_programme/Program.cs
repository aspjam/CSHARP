using System;

namespace premier_programme
{
    class Program
    {
        static void AfficherInfosPersonne(int age, string nom, float taille = 0)
        {
            Console.WriteLine();

            //Console.WriteLine("Vous vous appelez " + nom + ", vous avez " + age + " ans");
            Console.WriteLine($"Vous vous appelez {nom},\nvous avez {age} ans");


            //Console.WriteLine("bientôt vous aurez " + (age + 1) + " ans");
            Console.WriteLine($"bientôt vous aurez {(age + 1)} ans");

            // si l'age >= 18 -> majeur sinon mineur
            // age == 17 -> Vous serez bientôt majeur
            // age == 18 -> Vous êtes tout juste majeur

            // age >= 60 -> Vous êtes sénior
            // age < 10 -> Vous êtes un enfant.

            // ET OU  (and &&  or ||)
            // age >= 12 ET age < 18 -> adolescent
            // age == 1 OU age == 2 -> bébé


            if (age == 18)
            {
                Console.WriteLine("Vous êtes tout juste majeur");
            }
            else if (age == 17)
            {
                Console.WriteLine("Vous serez bientôt majeur");
            }
            else if ((age >= 12) && (age < 18))
            {
                Console.WriteLine("Vous êtes adolescent");
            }
            else if ((age == 1) || (age == 2))
            {
                Console.WriteLine("Vous êtes un bébé");
            }
            else if (age >= 60)
            {
                Console.WriteLine("Vous êtes sénior");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Vous êtes majeur");
            }
            else if (age < 10)
            {
                Console.WriteLine("Vous êtes un enfant");
            }
            else
            {
                Console.WriteLine("Vous êtes mineur");
            }

            // Vous faites 1.75m de hauteur.
            if (taille != 0)
            {
                Console.WriteLine("Vous faites " + taille + "m de hauteur.");
            }
        }

        static string DemanderNom(int numeroPersonne)
        {
            string nom = "";
            while (nom == "")
            {
                Console.Write("Quel est le nom de la personne numéro " + numeroPersonne + " ? ");
                nom = Console.ReadLine();
                nom = nom.Trim();
                if (nom == "")
                {
                    Console.WriteLine("Erreur: le nom ne doit pas être vide");
                }
            }
            return nom;
        }

        static int DemanderAge(string nom)
        {
            int age_num = 0;
            while (age_num <= 0)
            {
                Console.Write(nom + ", quel est ton age ? ");
                string age_str = Console.ReadLine();

                try
                {
                    age_num = int.Parse(age_str);

                    if (age_num < 0)
                    {
                        Console.WriteLine("Erreur : L'age ne doit pas être négatif");
                    }
                    if (age_num == 0)
                    {
                        Console.WriteLine("Erreur: L'age ne doit pas être égal à 0");
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur :  Vous devez rentrer un age valide.");
                }
            }
            return age_num;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // string  "Bonjour"
            // int   5
            // float / double 1,80f
            // bool    true false

            // DEMANDE LE NOM
            //string nom1 = DemanderNom(1);
            //string nom2 = DemanderNom(2);
            string nom1 = "Jean";
            string nom2 = "Paul";
            // Personne1

            // DEMANDE L'AGE
            int age1 = DemanderAge(nom1);
            int age2 = DemanderAge(nom2);

            // 1.75m => virgules
            // int : 0, 1, 2, 3, -1, -2 ...
            // float / double
            // 1.75f

            //float taille = 1.75f;

            // AFFICHE LES RESULTATS
            AfficherInfosPersonne(age1, nom1, 1.75f);
            AfficherInfosPersonne(age2, nom2);
        }
    }
}
