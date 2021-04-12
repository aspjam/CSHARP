using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseStandard
{
    public class MyClass
    {

        //Champ
        public string _myField = string.Empty;

        private int _myPropertyVar;
        //Propriété avec les accesseurs get et set
        public int MyProperty
        {
            get { return _myPropertyVar; }
            set { _myPropertyVar = value; }
        }

        private int _myPropertyVar2;
        //Propriété
        public int MyProperty2
        {
            get
            {
                return _myPropertyVar2 / 2;
            }

            set
            {
                if (value > 100)
                    _myPropertyVar2 = 100;
                else
                    _myPropertyVar2 = value; ;
            }
        }

        //Propiété implémenté automatiquement
        public int MyAutoImplementedProperty { get; set; }

        //Lecture seule
        public int Prix { get; private set; }
        //Ecriture seule
        public int Prix2 { private get; set; }

        //Impossible de priver les 2 accesseurs
        //public int Prix3 { private get; private set; }


        //Constructeur
        public MyClass()
        {
            MyProperty = 10;
        }

        public MyClass(string s)
        {
            _myField = "Constructeur";
        }

        public MyClass(string s, int b)
        {
            _myField = s;
            MyProperty = 10;
        }

        //this() appel le constructeur  MyClass()
        public MyClass(int p, string s) : this()
        {
            _myField = s;
            Prix = p;
        }

        //this(s) appel MyClass(s) ou this("toto")  appel MyClass("toto") 
        public MyClass(int p, string s, int p2) : this(s)
        {
            _myField = s;
            Prix = p;
            Prix2 = p2;
        }

        public void MyMethod(int parameter1, string parameter2)
        {
            Console.WriteLine("First Parameter {0}, second parameter {1}",
                                                        parameter1, parameter2);
        }

        //Surcharge
        public int MyMethod(int a)
        {
            return a;
        }

        //Surcharge avec parametre facultatif et de sortie
        public int MyMethod(int a, out int c, out string h, int b = 50, bool g = false)
        {
            h = "sortie";
            c = 100;
            return a + b;
        }
    }
}
