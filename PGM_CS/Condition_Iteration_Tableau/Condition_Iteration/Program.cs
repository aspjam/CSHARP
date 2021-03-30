using System;

namespace Condition_Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Condition
            int n = 50;

            if (n > 20)
            {
                int h = 200;
                n = n + 10;
                Console.WriteLine("Vrai n=" + n + "h=" + h);
            }
            else
            {
                int h = 500;
                n = n + 12;
                Console.WriteLine("Vrai n=" + n + "h=" + h);
            }

            Console.WriteLine("Dehors n=" + n);//60 n global
            //Console.WriteLine("Dehors h=" + h);//h n'existe pas local au bloc if

            //Boucle for
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("interieur boucle i = " + i);//0..9
            }

            //Console.WriteLine("exterieur boucle i = " + i);//i n'existe pas local a la boucle for
            int j = 0;

            for (j = 0; j < 10; j++)//impossible de mattre for(int j=0...) car j existe et est global
            {
                Console.WriteLine("interieur boucle j = " + j);//0..9
            }

            Console.WriteLine("exterieur boucle j = " + j + "\n\n");//10

            for (int i = 10; i > 0; i = i - 2)
            {
                Console.Write(i + " ");//10 8 6 4 2
            }

            Console.WriteLine("\n\n");

            for (int i = 10; i > 0; i = i - 2)
            {

                if (i < 5)
                {
                    Console.WriteLine("i<5");
                    break;
                }
                Console.Write(i + " ");//10 8 6 i<5
            }

            Console.WriteLine("\n\n");

            for (int i = 10; i > 0; i = i - 2)
            {

                if (i == 4)
                {
                    Console.WriteLine("i==4");
                    continue;
                }
                Console.Write(i + " ");//10 8 6 i==4 2

            }



            //Boucle while et do while
            int f = 0;
            while (f < 3)
            {
                int u = 50;
                Console.WriteLine("u local" + u);
                Console.WriteLine("f interieur" + f);//0 1 2
                f++;
            }

            //Console.WriteLine("u local" + u);//u n'existe pas
            Console.WriteLine("f exterieur" + f);//3

            Console.WriteLine("\n\nWHILE\n\n");
            int d = 0;
            while (d < 5)
            {
                Console.Write(d + " ");
                d++;
            }

            Console.WriteLine("\n\nDO WHILE\n\n");
            int e = 0;
            do
            {
                Console.Write(e + " ");
                e++;
            }
            while (e < 5);

            //boucle foreach
            Console.WriteLine("\n\nFOREACH\n\n");

            string mot = "Bonjour";
            int v = mot.Length;
            Console.WriteLine(v);//7
            foreach (var item in mot)
            {
                Console.WriteLine(item);//B o n j o u r
            }

            //Les tableaux
            Console.WriteLine("\n\nTableaux unidimensionnel\n\n");
            int[] tab1 = new int[3];

            Console.WriteLine("\n\n");
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.WriteLine("tab1[" + i + "] = " + tab1[i]);//0 0 0
            }

            tab1[0] = 12;
            tab1[1] = 24;

            Console.WriteLine("\n\n");
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.WriteLine("tab1[" + i + "] = " + tab1[i]);//12 24 0
            }

            tab1[2] = 88;
            //tab1[4] = 45;//Index out of the bound




            Console.WriteLine(tab1);//System.Int32[]

            int[] entiers = new int[] { 10, 15, 30, 35, 40, 45 };
            int[] entiers2 = { 10, 15, 20 };
            int[] entiers3 = new int[2];


            //Tabelau multidimentionnel

            int[,] image = new int[2, 3];//2lignes et 3colonnes
                                         // un tableau de 32*16 entiers, soit 512 entiers


            image = new int[2, 3] {
                {1,2,3 },
                {7,8,9 }
             };

            int x = image[0, 2];
            int w = image.Length;
            Console.WriteLine(x);//3
            Console.WriteLine(w);//6
            Console.WriteLine(image.Rank);//2 car 2 lignes
            Console.WriteLine(image.GetLength(0));//image[2.3]->2
            Console.WriteLine(image.GetLength(1));//image[2.3]->3


            Console.WriteLine("\n\n");
            for (int ligne = 0; ligne < image.Rank; ligne++)
            {
                for (int colonne = 0; colonne < image.GetLength(1); colonne++)
                {
                    Console.WriteLine("image[" + ligne + "," + colonne + "] = " + image[ligne, colonne]);//12 24 0
                }

            }
            /*
            image[0,0] = 1
            image[0,1] = 2
            image[0,2] = 3
            image[1,0] = 7
            image[1,1] = 8
            image[1,2] = 9
             */

            /*Tableaux dentelés ou dent de scie ou en escalier
             * ou jagged array est un tableau de tableaux
             *
             */

            int[][] jagTab = new int[4][];

            /*
             jagTab prend 3 tableaux
            chaque tableau peut avoir des dimensions differents 
            mais doit avoir le meme tyoe
             */

            //jagTab[0] ={ 12,45,1,2}; ne marche pas
            jagTab[0] = new int[] { 12, 41, 2 };
            jagTab[1] = new int[] { 125, 45 };
            jagTab[2] = new int[] { 2 };
            jagTab[3] = new int[] { 2, 45, 7, 88, -99, 78 };

            int[][] jaggedArray2 = new int[][]
            {
            new int[] { 1, 3, 5, 7, 9 },
            new int[] { 0, 2, 4, 6 },
            new int[] { 11, 22 }
            };

            Console.WriteLine(jagTab[0][1]);//41
            Console.WriteLine(jagTab.Rank);//1
            Console.WriteLine(jagTab.GetLength(0));//3
            Console.WriteLine(jagTab.Length);//4

            Console.WriteLine("\n\n");

            for (int ligne = 0; ligne < jagTab.Length; ligne++)
            {
                Console.Write("jagTab[" + ligne + "]=[");
                for (int colonne = 0; colonne < jagTab[ligne].Length; colonne++)
                {
                    Console.Write(jagTab[ligne][colonne]);
                    if (colonne < jagTab[ligne].Length - 1)
                    {
                        Console.Write(",");
                    }

                }
                Console.WriteLine("]");

            }

            Console.ReadLine();

        }
    }
}
