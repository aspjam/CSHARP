using System;
using System.Collections.Generic;
using POO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture v1 = new Voiture();
            Voiture v2 = new Voiture(250);
            Voiture v3 = new Voiture(300, "rouge", Engin.Carburants.GAZOIL);

            /*Console.WriteLine(v1);//POO.Voiture
            Console.WriteLine(v1.Vitesse);//0*/

            //Collection list
            List<string> mots = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                mots.Add("Mot" + i);//System.Collections.Generic.List`1[System.String]
            }

            List<Voiture> voitures = new List<Voiture>();
            voitures.Add(v1);
            voitures.Add(v2);
            voitures.Add(v3);

            for (int j = 1; j <= voitures.Count; j++)
            {
                Console.WriteLine($"v{j}.Vitesse = {voitures[j - 1].Vitesse}");
                Console.WriteLine($"v{j}.Couleur = {voitures[j - 1].Couleur}");

            }

            Console.WriteLine((v1.Couleur == null) ? "null" : "pas null");//null

            /*
            v1.Vitesse = 120
            v1.Couleur =
            v2.Vitesse = 250
            v2.Couleur =
            v3.Vitesse = 300
            v3.Couleur = rouge
            null
             */

            v1.Rouler();
            //v1.Carburant;//Inaccessible car protected est private
            v2.Rouler();

            //Substitution override
            Voiture voiture1 = new Voiture(220, "bleu", Engin.Carburants.ESSENCE);
            Camion camion1 = new Camion(220, "bleu", Engin.Carburants.GAZOIL);

            voiture1.Rouler();
            camion1.Rouler();

            camion1.ToString();

            //Cast
            Engin engin = new Engin();
            Engin engin1 = (Engin)voiture1;
            Console.WriteLine(engin1.GetType());//POO.Voiture
            Console.WriteLine(voiture1.GetType());//POO.Voiture
            Console.WriteLine(typeof(Engin));//POO.Engin

            engin.Rouler();//Vous roulez au GAZOIL
            engin1.Rouler();//Je suis une voiture
            voiture1.

            int val = 10;
            Console.WriteLine(val.GetType());//System.Int32
            Console.WriteLine(val.GetType());//System.Int32
            Object obj = val;//boxing conversion type valeur vers un type reference
            Console.WriteLine(val.GetType());//System.Int32
            Console.WriteLine(obj.GetType());//System.Int32
            Console.WriteLine(val);//10
            Console.WriteLine(obj);//10
            val = 50;
            Console.WriteLine(obj);//10
            obj = 150;
            Console.WriteLine(val);//50
            Console.WriteLine(obj);//150
            //int p =obj;//impossible convertir implicitement obj en in
            Console.WriteLine(obj.GetType());//System.Int32


        }
    }
}
