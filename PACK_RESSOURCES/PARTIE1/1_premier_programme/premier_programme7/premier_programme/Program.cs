using System;

namespace premier_programme
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Quel est ton nom ? ");
            string nom = Console.ReadLine();

            Console.Write("Quel est ton age ? ");
            string age_str = Console.ReadLine();

            int age_num = 0;

            try
            {
                age_num = int.Parse(age_str);

                Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + age_num + " ans");

                int age_prochain = age_num + 1;
                Console.WriteLine("bientôt vous aurez " + age_prochain + " ans");
            }
            catch
            {
                Console.WriteLine("Erreur, vous devez rentrer un age valide.");
            }
            */

            // while => tant que
            int i = 0;
            // == => comparaison d'égalite (vrai ou faux)
            // a < b  => a inférieur à b
            // a > b
            // a <= b 
            // a >= b
            // a != b => a est différent de b ?
            while (i != 5)
            {
                Console.WriteLine("Valeur de i : " + i);
                //i = i + 2; // incrémente la valeur de la variable i
                i += 1; // incrémente de 2
                //i++; // incrémente de 1
            }

            Console.WriteLine("Fin de la boucle, valeur de i: " + i);

        }
    }
}
