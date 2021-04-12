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

        }
    }

}
