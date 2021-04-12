using System;
using System.Collections.Generic;
using System.Text;

namespace Classe_Interface_Astraite
{

    /*
     Le mot clé static permet d'appeler des membres par la classe
    et non pas par l'objet

    Et dons this ne peut pas etre utiliser

    static : classes interfaces evenements 
            Pas les indexeurs et finaliseurs
    static : champs propriete methode operateur constructeurs

    [modificateur d'acces] [modificateur static] [type]
     
     */


    //Tous les membres doivent etre static
    static class ClassStatic
    {
        public static int Prix { get; set; }
        private static int _prix2 = 500;

        //Constructeur static non pad de modificateur d'acces et pas de parametres
        static ClassStatic()
        {
            Console.WriteLine("Appelle Constructeur");
            Prix = 100;
        }

        public static int Somme(int a, int b)
        {

            return a + b + Prix;
        }
    }

    class Standard
    {
        public int g = ClassStatic.Prix;
        int _marge = 100;
        static string mot = "toto";

        public void FS()
        {
            var t = g;
            var m = mot;
            Console.WriteLine(ClassStatic.Somme(10, 100));
        }

        public static void FStatic()
        {

            //var t = g;//NON STATIC
            //var f = _marge;//NON STATIC
            //FS();//NON STATIC

            //Accepte des objets NON STATIC imbriqués ou a l'exterieur
            C c = new C();
            var r = c.t;
            D d = new D();
            var r1 = d.t1;

            var m = mot;
            Console.WriteLine(ClassStatic.Somme(10, 100));
        }

        public class D
        {
            public int t1 = 55;

        }


    }

    public class C
    {
        public int t = 55;

    }
}
