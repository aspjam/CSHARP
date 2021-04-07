using System;

namespace Enumeration_Structure
{
    /*
     namespace on ne peut pas declarer private , protected,protected internal
     private protected
     */

    enum Day2 { dimanche, lundi, mardi, mercredi, jeudi, vendredi, samedi }

    class Program
    {

        /*
         En C #, un enum(ou type énumération) est utilisé pour 
        attribuer des noms de constantes à un groupe de valeurs 
        entières numériques. Il rend les valeurs constantes plus 
        lisibles, par exemple, WeekDays.Mondayest plus lisible que 
        le numéro 0 en se référant au jour dans une semaine.

        An enum est défini à l'aide du enummot - clé, directement 
        dans un espace de noms, une classe ou une structure. 
        Tous les noms de constantes peuvent être déclarés entre les 
        accolades et séparés par une virgule. Ce qui suit définit un 
        enumpour les jours de la semaine.   
        
        Une enum se declare dans un namespace ou dans une classe ou une structure
        mais ne se declare pas dans un methode
         
         
         */

        enum Day1
        {
            dimanche, //0
            lundi, //1
            mardi, //2
            mercredi, //3
            jeudi, //4
            vendredi, //5
            samedi
        }//6
        enum Day5
        {
            dimanche = 8, //8
            lundi,//9
            mardi,//10
            mercredi = 5,//5 
            jeudi,//6
            vendredi, //7
            samedi,//8;
        }

        static void Main(string[] args)
        {

            Day1 d1 = Day1.lundi;//d1 affiche lundi
            d1 = Day1.vendredi;//d1 affiche vendredi
            Console.WriteLine(d1);

            Console.WriteLine(Day1.dimanche);//dimanche
            Console.WriteLine((Day1)0);//dimanche
            Console.WriteLine(Day1.jeudi.GetType()); //Enumeration_Structure.Program + Day1

            var l = Day2.lundi;//lundi

            /*foreach (var item in Day1)
            {

            }*/// Impossible car n'implemente pas IEnumerable'

            //Recuperer un tableau de constante avec getValues(Type)
            var tab = Enum.GetValues((typeof(Day1)));
            Console.WriteLine("\n");
            foreach (var item in tab)
            {
                Console.WriteLine(item);//dimanche ..samedi
                Console.WriteLine((int)item);//0..6
            }

            var tab2 = Enum.GetValues((typeof(Day5)));
            Console.WriteLine("\n");
            foreach (var item1 in tab2)
            {
                Console.WriteLine(item1);//mercredi jeudi  dimanche  dimanche  lundi mardi
                Console.WriteLine((int)item1);//5 6 7 8 8 9 10
                /*
                    mercredi
                    5
                    jeudi
                    6
                    vendredi
                    7
                    dimanche
                    8
                    dimanche
                    8
                    lundi
                    9
                    mardi
                    10
                 */
            }

            Console.WriteLine("\n");
            Console.WriteLine((int)Day5.dimanche);//8
            Console.WriteLine((int)Day5.lundi);//9
            Console.WriteLine((int)Day5.mardi);//10
            Console.WriteLine((int)Day5.mercredi);//5
            Console.WriteLine((int)Day5.jeudi);//6
            Console.WriteLine((int)Day5.vendredi);//7
            Console.WriteLine((int)Day5.samedi);//8

            Console.WriteLine("\n");
            Console.WriteLine((Day5)8);//Dimanche


            Jour j = new Jour();
            //Day3 n'existe pas

        }
    }

    class Jour
    {
        public enum Day3 { Lundi, Vendredi }
        Day2 d1 = Day2.mardi;

        public void enumDay()
        {
            /*            public enum Day3 { Lundi, Vendredi }//Ne se declare pas dans un methode mais ds la classe
            */
            var l = Day2.lundi;
            d1 = (Day2)3;
        }
    }

}
