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
            AfficherMot(mot, new List<char> { 'L', 'E', 'T', 'Z'  });
        }
    }
}
