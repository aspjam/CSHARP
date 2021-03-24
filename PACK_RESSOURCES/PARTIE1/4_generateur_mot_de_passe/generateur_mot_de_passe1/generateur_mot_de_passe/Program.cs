using System;

namespace generateur_mot_de_passe
{
    class Program
    {
        static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue);
        }

        static int DemanderNombreEntre(string question, int min, int max)
        {
            // nombre = DemanderNombre(question)
            // si le nombre est bien entre min et max -> ERREUR / boucler ...

            int nombre = DemanderNombre(question);
            if ((nombre >= min) && (nombre <= max))
            {
                // valide
                return nombre;
            }
            Console.WriteLine("ERREUR : Le nombre doit être compris entre " + min + " et " + max);

            return DemanderNombreEntre(question, min, max);
        }

        static int DemanderNombre(string question)
        {
            // poser la question
            // récupérer la réponse
            // convertir
            // gérer l'erreur de conversion
            // boucler tant qu'on a pas recu une réponse valide (qui contient que des chiffres)
            while(true)
            {
                Console.Write(question);
                string reponse = Console.ReadLine();
                try
                {
                    int reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
                }
            }
        }

        static void Main(string[] args)
        {
            // 1 - Demander a longueur du mot de passe (DemanderNombre) int longeur_mot_de_passe = ...
            int longeurMotDePasse = DemanderNombre("Longueur du mot de passe : ");

            // 2 - alphabet "abcd1234"
            // 3 - comment choisir un caractère aléatoire
            // 4 - generer le mot de passe
            // 5 - Améliorations : choix alphabet

        }
    }
}
