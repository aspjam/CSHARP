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

            /*Attention ici la methode main() est static , on dit que c'est une methode de classe 
             
            Une méthode d'instance peut utiliser un membre de classe (attribut static ou méthode static).
            Une méthode de classe (methode static) peut utiliser un membre de classe (attribut static ou méthode static)..
            Une méthode de classe ne peut pas utiliser un membre d'instance (attribut ou méthode).
            Une méthode de classe ne peut pas utiliser le mot-clé this.+
            
            Les methodes surchargées ne peuvent se faire que dans la classe et pas dans la methode
            Commme main est static elle ne peut utiliser que des methodes static
            C'est pour quoi on a declaré static void Sur() en dehors de la methode et ajoute static

             */

            Sur(12, true);//"Original a=12 et b=true"
            Sur(false, 12);//Original a=12 et b=False //Inversion des parametres
            Sur(12, true, 50);//Original a=12 et b=True c= 50 //Ajout d'un parametre

            //Parametre facultatif

            /*
             Ils fournissent une solution compacte et simple lorsqu'il n'est pas possible d'utiliser surcharge car les types de paramètres ne varient pas suffisamment pour permettre au compilateur de distinguer les implémentations.
             */

            void fac(int a, string m, int b = 45)
            {
                Console.WriteLine("a = " + a + " m = " + m + " b = " + b);
            }

            fac(12, "bonjour");//a = 12 m = bonjour b = 45
            fac(12, "bonjour", 150);//a = 12 m = bonjour b = 150
                                    //fac(12, 150, "bonjour");//Mauvais positionnement des parametres

            //Specifier tous les parametres obligatoire avant les parametres facultatif

            //Erreur parametres facultatif apres parametres requis
            /* void fac2(int a, string m="defaut", int b )
             {
                 Console.WriteLine("a = " + a + " m = " + m + " b = " + b);
             }*/

            //Arguments nommés (Named arguments)

            /*
             lors de l'appel d'une méthode, l'ordre et la position des arguments dans l'appel de méthode correspondent à l'ordre des paramètres dans la signature de la méthode. Si les arguments ne sont pas alignés et que les types ne correspondent pas, vous recevez une erreur de compilation.
             
             */

            void named(int a, string m, int b)
            {
                Console.WriteLine("a = " + a + " m = " + m + " b = " + b);
            }

            named(m: "bonjour", a: 55, b: 88);//a = 55 m = bonjour b = 88

            //named(55,b: 88,"bonjour");//Erreur b hors position

            void named2(int a, int b, string m = "bonjour")
            {
                Console.WriteLine("a = " + a + " m = " + m + " b = " + b);
            }

            named2(b: 100, a: 200);//a = 200 m = bonjour b = 100

            //Parametre de sortie output parameter

            void named3(out string message, out int b)
            {
                message = "Message"; //Obliger d'assigner message sinon erreur
                b = 50; // Obliger d'assigner b sinon erreur

            }

            string mes;
            int f = 10;
            named3(out mes, out f);
            Console.WriteLine(mes);//"Message"
            Console.WriteLine(f);//50

            named3(out string mes2, out int f2);
            Console.WriteLine("mes2=" + mes2);//"Message"
            Console.WriteLine("f2=" + f2);//50

            //On peut pas mettre parametre faculatatif avant parametre de sortie
            int named4(int a, out string message, out int b, int c = 100)
            {
                message = "Message suivant"; //Obliger d'assigner message sinon erreur
                b = 300; // Obliger d'assigner b sinon erreur
                return a + c;

            }

            Console.WriteLine(named4(100, out mes, out f));//200
            Console.WriteLine(mes);//"Message suivant"
            Console.WriteLine(f);//300


        }

        static void Sur(int a, bool b) { Console.WriteLine("Original a=" + a + " et b=" + b); }

        //Changer le type de retour : PAS DE SURCHARGE

        //static int Sur(int a,bool b) { return a; }//Erreur pas de surcharge

        //Inverser les parametres
        static void Sur(bool b, int a) { Console.WriteLine("Original a=" + a + " et b=" + b); }

        //Ajouter un parametre
        static void Sur(int a, bool b, int c) { Console.WriteLine("Original a=" + a + " et b=" + b + " c= " + c); }

        //Supprimer des parametres
        static void Sur() { Console.WriteLine("Aucun ârametre"); }

        //Modifier le corps de la methode : PAS DE SURCHARGE

        //static void Sur(int a, bool b) { Console.WriteLine("Corps modifié"); }//Erreur methode existe deja

        //Modifier la visibilité : PAS DE SURCHARGE
        //private static void Sur(int a, bool b) { Console.WriteLine("Corps modifié"); }
        //public static void Sur(int a, bool b) { Console.WriteLine("Corps modifié"); }



    }
}
