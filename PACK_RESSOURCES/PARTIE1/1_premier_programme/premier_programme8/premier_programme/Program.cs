using System;

namespace premier_programme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Quel est ton nom ? ");
            string nom = Console.ReadLine();

            int age_num = 0;

            while (age_num == 0)
            {
                Console.Write("Quel est ton age ? ");
                string age_str = Console.ReadLine();

                try
                {
                    age_num = int.Parse(age_str);
                }
                catch
                {
                    Console.WriteLine("Erreur, vous devez rentrer un age valide.");
                }
            }

            // ici age_num est forcément différent de 0

            Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + age_num + " ans");

            int age_prochain = age_num + 1;
            Console.WriteLine("bientôt vous aurez " + age_prochain + " ans");




        }
    }
}
