using System;

namespace Methode_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Methode*/

            //Nom de la Methode UpperCamelCase et 
            //Commence avec lettre ou _
            //Le reste alphnumerique et _ : ex:_52BopT_45

            void _52BopT_45() { };


            //Valeur de retour int si rien void
            //a et b sont des parametre local n'existe que dans la methode
            //Somme(int a,int b) Signature d'une methode (pas de valeur de retour)
            //int Somme(int a,int b) //Spécification de la méthode il manque l'accessibilité devant int (public private)

            //Déclaration ou définition de la Methode
            int Somme(int a, int b)
            { return a + b; }//Corps de la Methode

            //Appel de la Fonction 
            //Les valeurs qu'on passe à la fonction s'appellent des arguments
            Console.WriteLine("Somme=" + Somme(5, 6));//11

            //Portée des variables
            int x = 100;
            int y = 15;
            int z = 12;

            int Portee(int a, int b)
            {
                x += a;
                return a + b;
            }

            Console.WriteLine("x=" + x);//100
            //Console.WriteLine("a=" + a);//a n'existe pas ds le context actuel
            //Console.WriteLine("b=" + b);//b n'existe pas ds le context actuel
            Portee(y, z);
            Console.WriteLine("x=" + x);//115

            //a et b recuperent une copie des valeurs de x et y
            //Parametres en lowerCamelCase
            //type f(int a) 'int a' definition du parametre a 

            //Passage par référence avec mot clé ref
            int REF(ref int a, int b)
            {
                a = 250;
                return a + b;
            }

            Console.WriteLine("y=" + y);// y=15
            Console.WriteLine(REF(ref y, z));// 262
            Console.WriteLine("y=" + y);//250

            //La variable 'a' pointe sur y et toute modification de
            //'a' modifiera 'y'

            //Chaque chemin d'execution doit renvoyer un return sauf si void

            /*string Aff(bool b)//Les chemins de code ne renvoie pas tous une valeur
            {
                if (b)
                {
                    return "Chemine vrai";
                }
            };*/

            string Aff(bool b)//Les chemins de code ne renvoie pas tous une valeur
            {
                if (b)
                {
                    return "Chemine vrai";
                }
                else
                {
                    return "Chemine faux";
                }
            }
            Console.WriteLine(Aff(true));
            Console.WriteLine(Aff(false));

            //Methode Surchargee(Overloaded)

            //Même nom
            //Signature unique donc parametres differents

            Sur();
            Sur(51);






        }
        static void Sur() { Console.WriteLine("Original"); }

        //Changer le type de retour      


        static void Sur(int d) { Console.WriteLine("Surcharge" + d); }
    }
}
