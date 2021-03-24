using System;

namespace premier_programme
{
    class Program
    {
        static void Main(string[] args) {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Quel est ton nom ? ");
            string nom = Console.ReadLine();

            Console.Write("Quel est ton age ? ");
            string age_str = Console.ReadLine();
            // "30"

            // 0, 1, 2, 3, -1, -2.. => int
            int age_num = int.Parse(age_str);
            // 30

            Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + age_num + " ans");
            
            int age_prochain = age_num + 1; // 30 + 1 => 31
            Console.WriteLine("bientôt vous aurez " + age_prochain + " ans");
            // bientôt vous aurez 31 ans


        }
    }
}
