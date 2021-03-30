using System;
using System.Globalization;
using System.Text;

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

            DateTime d0 = new DateTime(2010, 1, 1, 8, 0, 15);
            DateTime d1 = new DateTime(2010, 8, 18, 13, 30, 30);

            Console.WriteLine(d0);
            Console.WriteLine(d1);

            TimeSpan interval = d1 - d0;
            Console.WriteLine(interval);

            string[] formats = d0.GetDateTimeFormats();
            foreach (var item in formats)
            {
                Console.WriteLine(item);
            }

            /*
                2010-01-01 08:00:15Z
                vendredi 1 janvier 2010 07:00:15
                vendredi 1 janvier 2010 7:00:15
                1 janvier 2010 07:00:15
                1 janvier 2010 7:00:15
                1 janv. 10 07:00:15
                1 janv. 10 7:00:15
                janvier 2010
                janvier 2010 
             */

            Console.WriteLine("\n\n\n*****************************");

            string[] standards =
            {
                "d","D","f","F","g",
                "G","m","M","o","O",
                "r","R","s","t","T",
                "u","U","y","Y"

            };

            Console.WriteLine("date : " + d0);

            CultureInfo enUs = new CultureInfo("en-US");

            foreach (var stand in standards)
            {
                String format_string = d0.ToString(stand, enUs);
                Console.WriteLine("\"" + stand + "\"" + " : " + format_string);
            }
            /*
             date : 01/01/2010 08:00:15
            "d" : 01/01/2010
            "D" : vendredi 1 janvier 2010
            "f" : vendredi 1 janvier 2010 08:00
            "F" : vendredi 1 janvier 2010 08:00:15
            "g" : 01/01/2010 08:00
            "G" : 01/01/2010 08:00:15
            "m" : 1 janvier
            "M" : 1 janvier
            "o" : 2010-01-01T08:00:15.0000000
            "O" : 2010-01-01T08:00:15.0000000
            "r" : Fri, 01 Jan 2010 08:00:15 GMT
            "R" : Fri, 01 Jan 2010 08:00:15 GMT
            "s" : 2010-01-01T08:00:15
            "t" : 08:00
            "T" : 08:00:15
            "u" : 2010-01-01 08:00:15Z
            "U" : vendredi 1 janvier 2010 07:00:15
            "y" : janvier 2010
            "Y" : janvier 2010
             
             */


            //Variable implicitement typée mot clé var
            var prix = 50;
            var f2 = 15.23;
            var mot2 = "toto";
            var t1 = DateTime.Today;


            Console.WriteLine("prix = " + prix + " type = " + prix.GetType());
            Console.WriteLine("f2 = " + f2 + " type = " + f2.GetType());
            Console.WriteLine("mot2 = " + mot2 + " type = " + mot2.GetType());
            Console.WriteLine("t1 = " + t1 + " type = " + t1.GetType());

            /*
            prix = 50 type = System.Int32
            f2 = 15,23 type = System.Double
            mot2 = toto type = System.String
            t1 = 24/03/2021 00:00:00 type = System.DateTime
             */

            //Conversion implicite
            int a = 4;
            long c = 50;
            c = a;
            //a = c;//impossible de convertir implicitementlong en int
            long l2 = 525;
            decimal d2 = 12.52m;
            //grand=petit
            d2 = l2;


            //Conversion explicite car perte d'informations
            a = (int)c;

            //petit=(petit)grand
            l2 = (long)d2;

            //Avec Convert
            decimal dec = 123.56m;
            int j = Convert.ToInt32(dec);
            Console.WriteLine(j);
            Console.WriteLine(Convert.ToString(dec));//"123,56"
            //Console.WriteLine(Convert.ToChar(dec));//"Invalid cast from decimal"
            Console.WriteLine(Convert.ToBoolean(dec));//True

            //Parse
            string o = "123,45";
            //Console.WriteLine(Int32.Parse(o));//input is not a correct format
            Console.WriteLine(Double.Parse(o));//123,45
            Console.WriteLine(Decimal.Parse(o));//123,45


            //TryParse

            double nbr = 0;
            string m5 = "12345";

            if (double.TryParse(m5, out nbr))
            {
                Console.WriteLine("Nombre vaut : " + nbr);
            }
            else
            {
                Console.WriteLine("Nombre vaut : " + nbr);
            }

            //Concaténation
            StringBuilder sb = new StringBuilder("ABCDEFG");
            Console.WriteLine(sb);// "ABCDEFG"

            sb.Append(new char[] { 'D', 'E', 'F' });
            Console.WriteLine(sb);//"ABCDEFGDEF"

            sb.AppendFormat("GHI{0}{1}", 'J', 'k');
            Console.WriteLine(sb);//"ABCDEFGDEFGHIJk"

            //Insere a la position 3 "Alphabet: "
            //indice commence a 0
            sb.Insert(3, "Alphabet: ");
            Console.WriteLine(sb);//"ABCAlphabet: DEFGDEFGHIJk"

            sb.AppendFormat("KKkkkKKkkkabc");
            Console.WriteLine(sb);//"ABCAlphabet: DEFGDEFGHIJkKKkkkKKkkkabc"

            // Replace all lowercase k's with uppercase K's.
            sb.Replace('k', 'K');
            Console.WriteLine(sb);//ABCAlphabet: DEFGDEFGHIJKKKKKKKKKKKabc

            string mot6 = sb.ToString();

            sb.Clear();
            Console.WriteLine(sb);
        }
    }
}
