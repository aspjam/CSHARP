using System;
using System.Collections.Generic;

namespace jeu_du_pendu
{
    class Program
    {

        static void AfficherMot(string mot, List<char> lettres)
        {
            // E L E _ _ _ _ _

            for (int i = 0; i< mot.Length; i++)
            {
                char lettre = mot[i];
                if (lettres.Contains(lettre))
                {
                    Console.Write(lettre + " ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }
            Console.WriteLine();

        }

        static char DemanderUneLettre()
        {
            // Rendrez une lettre
            // ERREUR : Vous devez rentrer une seule lettre
            // return -> majuscules (ToUpper)

            while(true)
            {
                Console.Write("Rendrez une lettre : ");
                string reponse = Console.ReadLine();
                if (reponse.Length == 1)
                {
                    reponse = reponse.ToUpper();
                    return reponse[0];
                }
                Console.WriteLine("ERREUR : Vous devez rentrer une lettre");
            }
        }


        static void DevinerMot(string mot)
        {
            ///

            // _ _ _ _
            // E _ _ E _ _
            // AfficherMot()

            // DemanderUneLettre
        }


        static void Main(string[] args)
        {
            string mot = "ELEPHANT";

            //DevinerMot(mot);
            //AfficherMot(mot, new List<char> { 'L', 'E', 'T', 'Z'  });
            char lettre = DemanderUneLettre();
            AfficherMot(mot, new List<char> { lettre });
        }
    }
}
