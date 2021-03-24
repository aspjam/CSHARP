using System;

namespace nombre_magique
{
    class Program
    {
        // DemanderNombre
        // afficher : Rentrez un nombre
        // tester si ce nombre est valide (convertion -> try/catch) -> ERREUR : ce nombre n'est pas valide
        // reboucler tant que le nombre n'est pas valide
        // considérer que 0 est invalide
        // retourner la valeur (int)

        static int DemanderNombre(int min, int max)
        {
            int nombreUtilisateur = max + 1;

            while ((nombreUtilisateur < min) || (nombreUtilisateur > max))
            {
                Console.Write("Rentrez un nombre entre " + min + " et " + max + " : ");
                string reponse = Console.ReadLine();

                try
                {
                    nombreUtilisateur = int.Parse(reponse);

                    if ((nombreUtilisateur < min) || (nombreUtilisateur > max))
                    {
                        Console.WriteLine("ERREUR : le nombre doit être entre " + min + " et " + max);
                    }

                    // tester si nombreUtilisateur entre min et max
                    // ERREUR
                    // nombreUtilisateur = 0 <- forcer à reboucler
                }
                catch
                {
                    Console.WriteLine("ERREUR : rentrez un nombre valide");
                }
            }

            return nombreUtilisateur;
        }

        static void Main(string[] args)
        {
            // appler cette fonction DemanderNombre() une seule fois.

            // write line : votre nombre est : xx

            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            const int NOMBRE_MAGIQUE = 5;

            int nombre = NOMBRE_MAGIQUE+1;

            while (nombre != NOMBRE_MAGIQUE)  // tant qu'on a pas trouvé le nombre magique (nombre != NOMBRE_MAGIQUE)
            {
                nombre = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);

                // comparer nombre à NOMBRE_MAGIQUE
                // 1 - le nombre magique est plus petit
                // 2 - le nombre magique est plus grand
                // 3 - Bravo, vous avez trouvé le nombre magique
                if (NOMBRE_MAGIQUE > nombre)
                {
                    Console.WriteLine("le nombre magique est plus grand");
                }
                else if (NOMBRE_MAGIQUE < nombre)
                {
                    Console.WriteLine("le nombre magique est plus petit");
                }
            }

            Console.WriteLine("Bravo, vous avez trouvé le nombre magique");
        }
    }
}
