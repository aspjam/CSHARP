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

        static void Tableaux()
        {
            // Tableaux -> Array
            /*int[] t = new int[5];
            t[0] = 2;
            t[1] = 4;
            t[2] = 1;
            t[3] = 5;
            t[4] = 6;*/

            //int[] t = { 2, 4, 1, 5, 6 };

            //int[] t = new int[5];
            //string[] t = { "Martin", "Emilie", "Paul" };

            //Console.WriteLine(t[0][1]);

            /*for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);
            }*/

            //Console.WriteLine("Somme : " + SommeTableau(t));

            

        }

        static void Main(string[] args)
        {
            Tableaux();
        }
    }
}
