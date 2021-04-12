using System;

namespace TestçCast_Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 4.1256d;
            int j = 50;

            //int i = d;//conversion implicite impossible
            double t = j;//conversion implicite

            Parent p = new Parent();
            object b = p;
            Parent f = (Parent)b;

            Parent p1 = new Parent(750);
            Console.WriteLine(p1._parent_public);//750
            Fille f1 = new Fille();
            Console.WriteLine(f1._parent_public);//20000

            /* p1 = f1;
             Console.WriteLine("\n");
             Console.WriteLine("p1 =" + p1._parent_public);//20000
             Console.WriteLine("f1 =" + f1._parent_public);//20000

             f1._parent_public = 800;
             Console.WriteLine("\n");
             Console.WriteLine("p1 =" + p1._parent_public);//800
             Console.WriteLine("f1 =" + f1._parent_public);//800*/

            //f1 = (Fille)p1;//Cast impossible lors de la compilation

            Console.WriteLine("\n");
            p1.Finterface1();
            p1.Finterface2();

            Interface2 p2 = new Parent(555555);
            p2.Finterface2();//Uniquemment acces a l'implementation de Finterface2()
            Console.WriteLine(p2.GetType());//Parent
            Console.WriteLine(typeof(Parent));//Parent
            Parent p3 = (Parent)p2;
            Console.WriteLine(p3._parent_public);
            Interface2 p4 = (Interface2)p2;
            
        }

        interface Interface1
        {
            void Finterface1();
        }

        interface Interface2
        {
            void Finterface2();
        }

        class Parent : Interface1, Interface2
        {
            int _parent_defaut = 500;
            public int _parent_public = 50;
            internal int _parent_internal = 50;
            protected int _parent_protected = 333;
            private int _parent_private = 333;



            public Parent()
            {
                _parent_public = 20000;
            }

            public Parent(int c)
            {
                _parent_public = c;
            }

            void FParent_defaut()
            { }

            internal void FParent_internal()
            { }

            public void FParent_public()
            {
                Console.WriteLine("Parent");
                _parent_public = 200;
                _parent_protected = 333;
                _parent_private = 333;
                _parent_internal = 50;
                FParent_Protect();
                FParent_private();
                FParent_defaut();
                FParent_internal();
            }
            protected void FParent_Protect()
            {
                Console.WriteLine("FParent_Protect");
                _parent_public = 200;
                _parent_protected = 333;
                _parent_private = 333;
                _parent_internal = 50;
                FParent_Protect();
                FParent_private();
                FParent_defaut();
                FParent_internal();
            }
            private void FParent_private()
            {
                Console.WriteLine("FParent_private");
                _parent_public = 200;
                _parent_protected = 333;
                _parent_private = 333;
                _parent_internal = 50;
                FParent_Protect();
                FParent_private();
                FParent_defaut();
                FParent_internal();
            }

            public void Finterface1()
            {
                Console.WriteLine("Interface1");
            }


            public void Finterface2()
            {
                Console.WriteLine("Interface2");
            }
        }

        class Fille : Parent
        {
            public int f = 333;
            Parent p = new Parent();

            public void FFille() { Console.WriteLine("Fille"); }

            public void FFille2()
            {
                var t = p._parent_public;
                var j = p._parent_internal;
                //var t2 = p._parent_protected;//uniquement les class derviée
                //var t3 = p._parent_private;//membre privé
                var t4 = _parent_protected;
                var t5 = _parent_public;
                //var t5 = _parent_private;//membre privée ne s'herite pas
                //var t2 = p._parent_protected;
            }
        }
    }
}
