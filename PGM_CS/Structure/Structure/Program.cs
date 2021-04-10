using System;

namespace N1
{
    struct structN1 { }

    class Program
    {

        /*
         Un structure est de type valeur et  qui regroupe differents types personnalisés.
        Il devient un type complexe contenant plusieurs autre types

        Les types intégrés comme int,bool sont des structures         
         
         */

        /*
        Modificateur d'acces autorisés
       public (classe et exterieur)
       internal:même assembly (projet)
       private  (classe) 

       Modificateur non Valide : protected,static,sealed virtual ....

       struct peut inclure des constructeurs, des constantes, des champs, 
       des méthodes, des propriétés, des indexeurs, des opérateurs, 
       des événements et des types imbriqués.

       struct ne peut pas inclure un constructeur sans paramètre ou un destructeur.
       struct peut implémenter des interfaces, comme la classe.

       struct ne peut pas hériter d'une autre structure ou classe, 
       et il ne peut pas être la base d'une classe.

       struct les membres ne peuvent pas être spécifiés comme abstraits, 
       scellés, virtuels ou protégés.
        */

        static void Main(string[] args)
        {


            //Instancier une structure
            Coffee coffee1 = new Coffee();//Appel le constructeur par defaut
                                          //coffee1.strength = 3;//Champ et Pas de modificateur d'acces
                                          //coffee1.Bean = "Arabica";//Public
                                          //coffee1.CountryOfOrigin = "Kenya";//Propriété Private et pas d'accesseur

            string[] boissons = { "Chocolat", "The" };

            Coffee coffe2 = new Coffee(18, "Arabica", "Kenyia", boissons);
            Console.WriteLine(coffe2.Bean);
            Console.WriteLine(coffe2.Strength);
            Console.WriteLine(coffe2.CountryOfOrigin);
            Console.WriteLine(coffe2[0]);//Chocolat
            Console.WriteLine(coffe2[1]);//The
            //coffe2[3] = "Cafe au lait";Erreur out of range
            coffe2[0] = "Jus d'orange";
            Console.WriteLine(coffe2[0]);//Jus d'orange
            Console.WriteLine("\n");

            coffe2.YourCoffe();
            //Vous avez choisit un café avec un grain Arabica , de force 18, provenant du Kenyia

            //Appel d'une methode static
            Coffee.MStatic();

            //Appel d'une propriete static
            Console.WriteLine(Coffee.PStatic);//500

            //Appel d'une methode surcharhée avec parametre facultatif et de sortie
            int s;
            coffe2.YourCoffe(a: 50, b: 100, out s);


        }

        /*Création d'une structure*/
        public struct Coffee
        {
            //Champ
            int strength;
            //accesseur get et set
            public int Strength
            {
                get
                {
                    return this.strength;
                }

                set
                {
                    if (this.strength > 5)
                    {
                        this.strength = value;
                    }
                }

            }

            //Propriétés implémentées automatiquement
            public string Bean { get; set; }
            public string CountryOfOrigin { get; set; }
            public static int PStatic = 500;

            //public string CountryOfOrigin { get; }//En lecture seule
            //public string CountryOfOrigin { set; }//En Ecriture seule
            //public string CountryOfOrigin { get;private set; }//Lecture et ecriture privée
            //public string CountryOfOrigin { private get;set; }//Lecture privée et Ecriture 
            //public string CountryOfOrigin { set; }//En Ecriture seule

            //Création d'un indexeur
            /*
             Un indexeur est similaire à une propriété,
            en ce sens qu'il utilise des accesseurs get et set 
            pour contrôler l'accès à un champ. Plus important encore, 
            un indexeur vous permet d'accéder aux membres de la collection
            directement à partir du nom de la structure ou de la classe
            contenant en fournissant une valeur d'index entière. 
            Pour déclarer un indexeur, vous utilisez le mot clé this,
            qui indique que la propriété sera accessible en utilisant 
            le nom de l'instance de struct.
             */
            public string[] boissons;
            //Indexeur
            public string this[int index]
            {
                get { return this.boissons[index]; }
                set { this.boissons[index] = value; }
            }


            //Initialiser le Constructeur

            //public Coffee(){} Structure ne peut pas avoir de constructeur sans parametres

            /* public Coffee(int s)
             {
                 this.strength = s;
             }
            Il faut attribuer toutes les valeurs a tous les proprétés
             */

            public Coffee(int s, string b, string c, string[] bois)
            {
                this.strength = s;
                this.Bean = b;
                this.CountryOfOrigin = c;
                this.boissons = bois;
            }

            //Création de methode
            public void YourCoffe()
            {
                Console.WriteLine("Vous avez choisit un café avec un grain {0} , de force {1}, provenant du {2}", Bean, Strength, CountryOfOrigin);
            }

            public static void MStatic()
            {
                Console.WriteLine("Appel d'une methode static");
            }

            //Methode surcharée
            public int YourCoffe(int a, int b, out int somme, int c = 20)
            {

                somme = a + b + c;
                return a + b;

            }







        }



    }//classe

}//namespace

