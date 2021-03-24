using System;

namespace premier_programme
{
    class Program
    {
        static void AfficherInfosPersonne(string nom, int age)
        {
            Console.WriteLine();
            Console.WriteLine("Vous vous appelez " + nom + ", vous avez " + age + " ans");
            Console.WriteLine("bientôt vous aurez " + (age + 1) + " ans");

            // si l'age >= 18 -> majeur sinon mineur

            if (age >= 18)
            {
                Console.WriteLine("Vous êtes majeur");
            }
            else
            {
                Console.WriteLine("Vous êtes mineur");
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

            // DEMANDE LE NOM
            string nom1 = DemanderNom(1);
            string nom2 = DemanderNom(2);

            // DEMANDE L'AGE
            int age1 = DemanderAge(nom1);
            int age2 = DemanderAge(nom2);

            // AFFICHE LES RESULTATS
            AfficherInfosPersonne(nom1, age1);
            AfficherInfosPersonne(nom2, age2);

        }
    }
}
