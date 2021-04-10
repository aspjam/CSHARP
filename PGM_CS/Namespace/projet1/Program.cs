using System;
using projet2;
using bibli1;
using DP4;

namespace projet1
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            P2 p = new P2();//P2 namespace projet1
            int u = p.Q;

            //P3 p3 = new P3();//Erreur P3 namespace projet2 et pas de using projet2

            //Avec using projet2
            P3 p3 = new P3();//OK

            /*
             Création projet blibliotheque de classe bbli1
            solution1 contient 2 dossiers projet1 et bibli1

            solution1\projet1\bin\Debug\netcoreapp3.1
                fichier json
                projet1.dll //assembly projet1
                projet1.exe//assembly projet1
                projet1.pdb
                bibli1.dll //assembly bibli1
                bibli1.exe//assembly bibli1
                bibli1.pdb

            Donc ona deux assembly projet1 et bibli1

            using bbili1 ajouter une reference de Projet dans projet1
            et selectionner bibli1
             
            Attention si j'ajoute une refenrence projet1 dans bibli1 
            alors erreur dependance circulaire
             
             */
            Cbibli b = new Cbibli();

            //Si je mets pas public à la classe CBilbli alors par defaut
            //le modificateur d'acces est interal et on peut pas acceder
            //car 2 assembly differents

            SBibli s = new SBibli();//idem pour les structures

            P4 p4 = new P4();
        }
    }
}
