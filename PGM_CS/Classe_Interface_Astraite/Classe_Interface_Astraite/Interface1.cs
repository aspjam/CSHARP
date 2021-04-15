using System;
using System.Collections.Generic;
using System.Text;

namespace Classe_Interface_Astraite
{
    /*
     une interface peut être définie à l'aide du interfacemot - clé. 
    Elle definit une sorte de contrat avec la classe qui l'implémente.
    La classe est obligé d'implementer tous memnbres de l'interface
    Une interface peut contenir des déclarations de méthodes, 
    de propriétés, d'indexeurs et d'événements. 
    Cependant, il ne peut pas contenir de champs, de propriétés implémentées automatiquement.

    Tous les membres sont publics par défaut tous les modificateurs sont interdits
    sauf private ou il faut implementer le corps de la methode

    Une interface ne peut contenir que des déclarations mais pas des implémentations sauf private
     
     
     
     */

    interface IFile
    {
        void ReadFile(); //compile-time error
        //private void WriteFile(string text);//compile-time error
        void WriteFile(string text);

    }

    interface ICalcul
    {
        int Somme(int a, int b);
    }

    //Une classe ou une struct peut implementer une ou plusieurs interface

    class Test_Interface : ICalcul, IFile
    {
        public void ReadFile()
        {
            Console.WriteLine("Implemente ReadFile de IFile");
        }

        public int Somme(int a, int b)
        {
            Console.WriteLine("Implemente Somme de ICalcul");
            return b + b;
        }

        public void WriteFile(string text)
        {
            Console.WriteLine("Implemente WriteFile de IFile");
        }
    }

    interface IExp
    {
        void Explicite();
        void NotExplicite();
        void Explicite2();
        void NotExplicite2();
    }

    class Produit : IExp
    {
        //Aucun modificateur n'est autorisé et donc la methode est privée par deafaut
        void IExp.Explicite() { Console.WriteLine("Explicite"); }
        void IExp.Explicite2() { Console.WriteLine("Explicite2"); }
        public void NotExplicite() { Console.WriteLine("NotExplicite"); }
        public void NotExplicite2() { Console.WriteLine("NotExplicite2"); }


        public string Marque { get; set; }
    }
}
