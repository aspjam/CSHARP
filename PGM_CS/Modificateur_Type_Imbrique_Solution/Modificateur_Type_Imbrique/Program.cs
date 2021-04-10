using System;

namespace Modificateur_Type_Imbrique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            C1 c1 = new C1();
            //C2 c2 = new C2();Impossible car type imbriquee privee par defaut
            C1.C2 c2 = new C1.C2();
            c2.FC2();

            //C1.C4//Ne marche pas car classe privée
        }

    }

    public class C1
    {
        int chpC1;
        C2 c2;
        C3 c3;
        C4 c4;//Accessible au niveau du conteneur direct

        public void FC2()
        {
            C4 c4 = new C4();
            //var t=c4.chpC4;
        }

        public class C2
        {
            int chpC2;
            C4 c4;

            public void FC2()
            {
                C4 c4 = new C4();
                //var t = c4.chpC4;
            }


        }

        internal class C3
        {
            int chpC3;
            C4 c4;

            public void FC3()
            {
                C4 c4 = new C4();
                //var t = c4.chpC4;chpC4 est privée
            }
        }


        private class C4
        {
            private int chpC4;

            public void FC4()
            {
                C5 c5;
                C1 c1;
            }


        }

        private class C5
        {
            public int chpC5;

            public void FC5()
            {
                C4 c4 = new C4();
                //c4.chpC4;//Impossible car privée
            }

        }


    }//classe C1

    public class D1
    {
        C1 c1;//Acces ok
        //C4 c4;//Par defaut un type imbriqué est privée
        //C2 c2;//Par defaut un type imbriqué est privée
    }

}
