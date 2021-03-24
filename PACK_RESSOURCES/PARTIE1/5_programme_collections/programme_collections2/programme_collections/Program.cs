using System;

namespace programme_collections
{
    class Program
    {
        // Somme (int a, int b, int c)
        static int SommeTableau(int[] t)
        {
            int somme = 0;

            for (int i = 0; i < t.Length; i++)
            {
                somme += t[i];
            }

            return somme;
        }

        static void AfficherTableau(int[] tableau)
        {
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("[" + i + "] " + tableau[i]);
            }
        }

        static void AfficherValeurMaximale(int[] t)
        {
            // La valeur maximale est : xx
            int max = t[0];
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] > max)
                {
                    max = t[i];
                }
            }
            Console.WriteLine("La valeur maximale est : " + max);
        }

        static void AfficherValeurMinimale(int[] t)
        {
            // La valeur maximale est : xx
            int min = t[0];
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] < min)
                {
                    min = t[i];
                }
            }
            Console.WriteLine("La valeur minimale est : " + min);
        }

        static void Tableaux()
        {
            //int[] t = { 200, 40, 15, 8, 12 };
            const int TAILLE_TABLEAU = 20;

            // int[] t
            // Initialiser chaque element valeur aléatoire entre 0 et 100

            int[] t = new int[TAILLE_TABLEAU];
            Random r = new Random();
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = r.Next(101);
            }

            AfficherTableau(t);
            AfficherValeurMaximale(t);
            AfficherValeurMinimale(t);


        }

        static void Main(string[] args)
        {
            Tableaux();
        }
    }
}
