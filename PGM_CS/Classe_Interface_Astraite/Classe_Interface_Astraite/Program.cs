using System;
using ClasseStandard;

namespace Classe_Interface_Astraite
{
    class Program
    {
        static void Main(string[] args)
        {

            /******************Classe*******************/

            MyClass c1 = new MyClass();
            Console.WriteLine(c1.MyProperty);//10

            //int p string s et this()
            MyClass c2 = new MyClass(50, "test");
            Console.WriteLine();
            Console.WriteLine(c2._myField);//test
            Console.WriteLine(c2.Prix);//50
            Console.WriteLine(c2.MyProperty);//10 ->this()

            //Methode
            int v = 0;
            string g = "";
            Console.WriteLine();
            Console.WriteLine(c2.MyMethod(120, out v, out g));//170
            Console.WriteLine(v);//100
            Console.WriteLine(g);//sortie

            /******************Classe Statique*******************/

            /*
             Un constructeur statique ne peut pas être appelé directement
            et est uniquement destiné à être appelé par le Common Language Runtime
            (CLR). Il est appelé automatiquement.
             
             */
            Console.WriteLine("/n/n/******************Classe Statique*******************//n");

            Console.WriteLine(ClassStatic.Prix);//100
                                                //ClassStatic._prix2;//Inaccesssible car privée

            Console.WriteLine("/n/n/*********************Interface*******************//n");

            Test_Interface test = new Test_Interface();
            IFile test_IFile = new Test_Interface();
            ICalcul test_ICalcul = new Test_Interface();

            test.ReadFile();
            test.WriteFile("Bonjour");
            test.Somme(10, 50);

            //Limitation implmentation implicite

            //test_IFile est de type IFile et ne peut acceder qu'aux membres de IFle
            test_IFile.ReadFile();
            test_IFile.WriteFile("Bonjour");
            //test_IFile.Somme(10, 50);Erreur Somme n'ont definit

            //test_ISomme est de type ISomme et ne peut acceder qu'aux membres de ISomme
            test_ICalcul.Somme(10, 50);
            //test_ICalcul.ReadFile();
            ///test_ICalcul.WriteFile("Bonjour");


            //Limitation implmentation explicite

            Produit p = new Produit();
            //p.Explicite();Error Pas accessible car implementation explicite
            //p.Explicite2();Error Pas accessible car implementation explicite
            p.NotExplicite();
            p.NotExplicite2();
            var m = p.Marque;

            IExp p2 = new Produit();
            p2.Explicite();
            p2.Explicite();
            p2.Explicite2();
            p2.NotExplicite();
            p2.NotExplicite2();

            //Cast d'interface 
            IFile test2_IFile = new Test_Interface();
            Console.WriteLine(test2_IFile.GetType());//Classe_Interface_Astraite.Test_Interface

            //Conversion explicite
            Test_Interface test2 = (Test_Interface)test2_IFile;

            //Conversion implicite
            ICalcul test3 = test2;

            //Ces conversions permettent de limiter  l'exposition aux menbres 
        }
    }

}
