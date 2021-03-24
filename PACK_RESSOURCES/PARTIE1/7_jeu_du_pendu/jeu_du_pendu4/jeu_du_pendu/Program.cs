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
            // Boucler (true)
            //  AfficherMot()
            //  DemanderUneLettre
            //      -> "Cette lettre est dans le mot" -> List<char> add ()
            //      -> "Cette lettre n'est pas dans le mot"

            var lettresDevinees = new List<char>();
            const int NB_VIES = 6;
            int viesRestantes = NB_VIES;

            while (viesRestantes > 0)
            {
                AfficherMot(mot, lettresDevinees);
                Console.WriteLine();
                var lettre = DemanderUneLettre();
                Console.Clear();

                if (mot.Contains(lettre))
                {
                    Console.WriteLine("Cette lettre est dans le mot");
                    lettresDevinees.Add(lettre);
                }
                else
                {
                    Console.WriteLine("Cette lettre n'est pas dans le mot");
                    viesRestantes--;
                    Console.WriteLine("Vies restantes : " + viesRestantes);
                }
                Console.WriteLine();
            }

            if (viesRestantes == 0)
            {
                Console.WriteLine("PERDU ! Le mot était : " + mot);
            }
            
            
        }


        static void Main(string[] args)
        {
            string mot = "ELEPHANT";

            DevinerMot(mot);
            //AfficherMot(mot, new List<char> { 'L', 'E', 'T', 'Z'  });
            //char lettre = DemanderUneLettre();
            //AfficherMot(mot, new List<char> { lettre });
        }
    }
}
