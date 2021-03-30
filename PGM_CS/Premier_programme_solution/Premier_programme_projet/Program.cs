using System;

namespace Premier_programme_projet
{
    class Program
    {
        static void Main(string[] args)
        {

            string nom = "";
            do
            {
                Console.Write("Quel est votre nom ?");
                nom = Console.ReadLine();
                nom = nom.Trim();//Trim efface les espaces avant et apres
                if (nom == "")
                {
                    Console.WriteLine("\nLe nom ne doit pas être vide\n");
                }
            }
            while (nom == "");

            int age_num = 0;

            while (age_num <= 0)
            {
                Console.Write("Quel est votre age ?");
                string age = Console.ReadLine();



                try
                {
                    age_num = int.Parse(age);
                    if (age_num <= 0)
                    {
                        Console.WriteLine("\nL'age doit etre positif\n");
                    }


                }
                catch (Exception)
                {

                    //Console.WriteLine("age_num : " + age_num);
                    Console.WriteLine("Erreur vous devez entrer un age valide");
                }


                Console.WriteLine("Bonjour vouv vous appelez " + nom + " et vous avez " + age_num + " ans");

            }


        }//main
    }//pgm
}//nps
