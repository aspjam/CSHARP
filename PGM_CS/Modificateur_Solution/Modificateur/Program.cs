using System;
using BibliClasse;

namespace Modificateur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Modif_C1_internal
    {
        public string champ_C1 = "champ_C1";
        //string champ2 = champ_C1; champ2 neut peut pas faire reference a un autre champ
        //ou propriete ou methode de la meme classe
        //var C3 = 55;var ne se declare pas dans les champs ou proprietes

        //Modif_C2_public

        //Modif_C2_public.champ_C2;N'existe pas
        Modif_C2_public c2 = new Modif_C2_public();//c2 est un champ de type Modif_C2_public
        Modif_C2_public c10;

        //Modif_C2_public c3 = c2.champ_C2;//Meme erreur que champ2

        //Methode 
        public void FC1_Internal()
        {
            //Classe public
            Modif_C2_public c2 = new Modif_C2_public();//Methode public internal private
            var c3 = c2.champ_C2;//Methode public internal private
            //var c4 = Modif_C2_public.champ_C2;N'est pas static

            //Classe public static           
            Modif_C4_public_static.champ_C2 = "ok";//Methode public internal private

            //Classe public de l'assembly BibliCalssse
            Bibli_C_public b = new Bibli_C_public();
            var gg = b.champ_Bibli_C_public;

            //Classe public de l'assembly BibliCalssse
            //Bibli_C_internal c = new Bibli_C_internal();
            //Inaccessible en raison de son niveau de protection internal

        }

    }

    public class Modif_C2_public
    {
        public string champ_C2 = "champ_C2";

        //Methode 
        public void FC2_public()
        {
            //Classe public
            Modif_C1_internal c2 = new Modif_C1_internal();//Methode public internal private
            var c3 = c2.champ_C1;//Methode public internal private
            //var c4 = Modif_C2_public.champ_C2;N'est pas static

            //Classe internal static           
            Modif_C3_internal_static.champ_C1 = "ok";//Methode public internal private

        }
    }

    static class Modif_C3_internal_static
    {
        public static string champ_C1 = "champ_C1";

        public static void FC3_Internal_Static()
        {
            //Classe public
            Modif_C2_public c2 = new Modif_C2_public();//Methode public internal private
            var c3 = c2.champ_C2;//Methode public internal private
            //var c4 = Modif_C2_public.champ_C2;N'est pas static

            //Classe public static           
            Modif_C4_public_static.champ_C2 = "ok";//Methode public internal private

            //Classe public
            Modif_C1_internal c5 = new Modif_C1_internal();//Methode public internal private
            var c8 = c5.champ_C1;//Methode public internal private
            //var c4 = Modif_C2_public.champ_C2;N'est pas static

            //Classe internal static           
            Modif_C3_internal_static.champ_C1 = "ok";//Methode public internal private

        }
    }

    public static class Modif_C4_public_static
    {
        public static string champ_C2 = "champ_C2";
    }
}
