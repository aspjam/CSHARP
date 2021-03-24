using System;

namespace premier_programme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string nom = "";


            // "      " -> ""
            // "    toto" -> "toto"
            // "      toto    " -> "toto"

            while (nom == "")
            {
                Console.Write("Quel est ton nom ? ");
                nom = Console.ReadLine();
                nom = nom.Trim();
                if (nom == "")
                {
                    Console.WriteLine("Erreur: le nom ne doit pas être vide");
                }
            }


            int age_num = 0;

            while (age_num <= 0)
            {
                Console.Write("Quel est ton age ? ");
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

            // ici age_num est forcément différent de 0

            Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + age_num + " ans");

            int age_prochain = age_num + 1;
            Console.WriteLine("bientôt vous aurez " + age_prochain + " ans");
        }
    }
}
