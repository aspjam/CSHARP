using System;

namespace jeu_de_maths
{
    class Program
    {
        static bool PoserQuestion(int min, int max)
        {
            Random rand = new Random();
            int reponseInt = 0;
            while (true)
            {
                int a = rand.Next(min, max+1);
                int b = rand.Next(min, max + 1);
                int o = rand.Next(1, 3);
                int resultatAttendu;
                // o => 1 ou 2
                //      1 -> addition
                //      2 -> multiplication

                if (o == 1) // Addition
                {
                    Console.Write(a + " + " + b + " = ");
                    resultatAttendu = a + b;
                }
                else // Multiplication
                {
                    Console.Write(a + " x " + b + " = ");
                    resultatAttendu = a * b;
                }
                
                string reponse = Console.ReadLine();
                try
                {
                    reponseInt = int.Parse(reponse);
                    if (reponseInt == resultatAttendu)
                    {
                        return true;
                    }

                    return false;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
                }
            }
            // reponseInt
        }

        static void Main(string[] args)
        {
            // 5 + 2 = 7
            // Bonne réponse / mauvaise réponse
            // a + b 
            // min et max

            // 1 - définir MIN ET MAX
            // 2 - nombres aléatoires pour a et b
            // 3 - calculer a+b == reponseInt
            // 4 - return true/false
            // 5 - true -> bonne reponse / mauvaise reponse

            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            const int NB_QUESTIONS = 5;

            int points = 0;

            // boucle for
            for (int i = 0; i < NB_QUESTIONS; i++)
            {
                // Question n° 1 / 3 
                Console.WriteLine("Question n°" + (i+1) + "/"  + NB_QUESTIONS);
                bool bonneReponse = PoserQuestion(NOMBRE_MIN, NOMBRE_MAX);
                if (bonneReponse)
                {
                    Console.WriteLine("Bonne réponse");
                    points++;
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Nombre de points : " + points + "/" + NB_QUESTIONS);

            // 100% bonnes réponses => Excellent
            // 0 -> Révisez vos maths

            // 10 -> 5 ( 10/2 = 5)
            // 5/2 = 2,5 -> 2
            int moyenne = NB_QUESTIONS / 2;

            // > moyenne -> pas mal
            // <= moyenne -> Peut mieux faire

            if (points == NB_QUESTIONS)
            {
                Console.WriteLine("Excellent !");
            }
            else if (points == 0)
            {
                Console.WriteLine("Révisez vos maths !");
            }
            else if (points > moyenne)
            {
                Console.WriteLine("Pas mal");
            }
            else
            {
                Console.WriteLine("Peut mieux faire");
            }
        }
    }
}
