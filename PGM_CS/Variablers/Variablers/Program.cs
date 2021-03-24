using System;

namespace Variablers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i = 50;
            //int i = 100;//Ne peut pas déclarer 2 fois la meme variable
            Console.WriteLine(i);
            float f = 12.5f;
            Console.WriteLine(f);//12,5
            double d = 150.231d;
            Console.WriteLine(d);//150,231
            decimal dc = 50.2536987m;
            Console.WriteLine(dc);
            bool b = false;
            Console.WriteLine(b);//False
            char r = 'a';
            Console.WriteLine(r);//a
            string mot = "Bonjour";
            Console.WriteLine(mot);//Bonjour

            //Concatenation
            Console.WriteLine(mot + " tout le \nmonde");

            //DateTime

            //Declaration de l'objet de type struct
            DateTime date = new DateTime();
            Console.WriteLine(date);
            DateTime date1 = DateTime.Now;
            Console.WriteLine(date1);
            DateTime d3 = new DateTime(2010, 03, 01, 10, 20, 03);
            Console.WriteLine(d3);//01/03/2010 10:20:03
            Console.WriteLine(d3.Year.GetType());//System.Int32
            Console.WriteLine(d3.Date);//01/03/2010 00:00:00
            Console.WriteLine(d3.Day);//1
            Console.WriteLine(d3.Day);//1
            Console.WriteLine(d3.DayOfWeek);//Monday
            Console.WriteLine(d3.DayOfYear);//60 compris entre 1 et 3666
            Console.WriteLine(d3.Hour);//10






        }
    }
}
