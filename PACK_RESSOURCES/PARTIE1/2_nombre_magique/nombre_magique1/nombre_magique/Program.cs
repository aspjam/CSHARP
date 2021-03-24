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

        static int DemanderNombre()
        {
            int nombreUtilisateur = 0;

            while(nombreUtilisateur == 0)
            {
                Console.Write("Rentrez un nombre: ");
                string reponse = Console.ReadLine();

                try
                {
                    nombreUtilisateur = int.Parse(reponse);
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

            int nombre = DemanderNombre();

            Console.WriteLine("Votre nombre est : " + nombre);
        }
    }
}
