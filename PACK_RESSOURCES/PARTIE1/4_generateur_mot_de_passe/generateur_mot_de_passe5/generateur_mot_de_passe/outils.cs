using System;
using System.Collections.Generic;
using System.Text;


// FormationCS.outils.DemanderNombrePositifNonNul

namespace FormationCS
{
    static class outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue);
        }

        public static int DemanderNombreEntre(string question, int min, int max)
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

        public static int DemanderNombre(string question)
        {
            // poser la question
            // récupérer la réponse
            // convertir
            // gérer l'erreur de conversion
            // boucler tant qu'on a pas recu une réponse valide (qui contient que des chiffres)
            while (true)
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

    }
}
