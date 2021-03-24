using FormationCS;
using System;

namespace generateur_mot_de_passe
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // 1 - Demander a longueur du mot de passe (DemanderNombre) int longeur_mot_de_passe = ...
            int longeurMotDePasse = outils.DemanderNombrePositifNonNul("Longueur du mot de passe : ");

            // 2 - alphabet "abcd1234"
            // 3 - comment choisir un caractère aléatoire

            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string alphabet = minuscules;
            string motDePasse = "";
            int longeurAlphabet = alphabet.Length;
            Random rand = new Random();


            // boucler sur longeurMotDePasse
            for (int i = 0; i < longeurMotDePasse; i++ )
            {
                int index = rand.Next(0, longeurAlphabet);
                motDePasse += alphabet[index];
            }
            

            Console.WriteLine("Mot de passe : " + motDePasse);

            // 4 - generer le mot de passe
            // 5 - Améliorations : choix alphabet

        }
    }
}
