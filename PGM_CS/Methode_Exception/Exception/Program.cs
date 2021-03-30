using System;

namespace Exception1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception

            /*
             * 
             * une exception est une erreur produite durant l'exécution de votre programme. Sémantiquement parlant, le terme d'exception a été retenue car une erreur est censée être exceptionnelle : c'est n'est pas le mode de fonctionnement nominale de votre application.
             * 
             * La chose la plus importante à comprendre c'est qu'en cas de déclenchement d'exception (d'erreur) le programme passe dans un mode d'exécution particulier : il faut qu'il trouve un gestionnaire d'erreur (un bloc d'instruction try / catch).
             * 
             * .NET Framework fournit plusieurs classes d'exception
             * 
             * Exception
             * SystemException
             * ApplicationException
             * NullReferenceException
             * FileNotFoundException
             * SerializationException
             * 
             * Une exception est l'indication d'une erreur ou d'une condition exceptionnelle. 
             * Une méthode peut lever une exception lorsqu'elle détecte qu'un événement inattendu s'est produit, par exemple, l'application tente d'ouvrir un fichier qui n'existe pas.
             * 
             * 
             * Try{ code appelant } catch(xxxException 1)  { code gestion exception 1 } ... catch(xxxException n){ code gestion exception n }
             * Si la methode leve un exception dans tous les cas le code appelant est abandonné
             * La methode recherche l'exception dans les catch et si il a la trouve execute le code de gestion
             * 
             * Et si aucun code ne gere cette exception le processus s'arrete et affiche un mesaage d'eerue
             * 
             * Toutes les exceptions heritent de la classe Exception
             * 
             * Lorsqu'une méthode lève une exception, elle crée un objet Exception et peut le renseigner avec des informations sur la cause de l'erreur. L'objet Exception est ensuite passé au code qui gère l'exception.
             * 
             * On place toujours la classe d'exception ciblée en premier et la générale en dernier en l'occurence Exeption
             * 
             */

            int[] values = null;

            //Unhandled exception. System.NullReferenceException: 
            //Object reference not set to an instance of an object.
            //Console.WriteLine(values[0]);

            /*try
            {
                Console.WriteLine("Code appelant dans Try avant1");//EXECUTE
                Console.WriteLine("Code appelant dans Try avant2");//EXECUTE
                Console.WriteLine("values[0] = " + values[0]);//PAS EXECUTE
                Console.WriteLine("Code appelant dans Try apres1");// PAS EXECUTE
                Console.WriteLine("Code appelant dans Try apres2");// PAS EXECUTE

            }
            catch (Exception e)
            {
                Console.WriteLine("Data " + e.Data);//System.Collections.ListDictionaryInternal
                Console.WriteLine("InnerException " + e.InnerException);//null
                Console.WriteLine("Message " + e.Message);//Object reference not set to an instance of an object.
                Console.WriteLine("Source " + e.Source);//Source Exception
                Console.WriteLine("TargetSite " + e.TargetSite);//TargetSite Void Main(System.String[])

            }

            Console.WriteLine("Apres le catch");//EXECUTE*/

            /*try
            {
                Console.WriteLine("Code appelant dans Try avant1");//EXECUTE
                Console.WriteLine("Code appelant dans Try avant2");//EXECUTE
                Console.WriteLine("values[0] = " + values[0]);//PAS EXECUTE
                Console.WriteLine("Code appelant dans Try apres1");// PAS EXECUTE
                Console.WriteLine("Code appelant dans Try apres2");// PAS EXECUTE

            }
            catch (NullReferenceException e) //Capturé ici CODE EXECUTE
            {

                Console.WriteLine("\n\nNullReferenceException");
                Console.WriteLine("Data " + e.Data);//System.Collections.ListDictionaryInternal
                Console.WriteLine("InnerException " + e.InnerException.Message);//NullReferenceException
                Console.WriteLine("Message " + e.Message);//Object reference not set to an instance of an object.
                Console.WriteLine("Source " + e.Source);//Source Exception
                Console.WriteLine("TargetSite " + e.TargetSite);//TargetSite Void Main(System.String[])

            }
            catch (Exception e)//Pas capturé car capturé avant par NullReferenceException et code NON EXECUTE
            {
                Console.WriteLine("\n\nException");
                Console.WriteLine("Data " + e.Data);//System.Collections.ListDictionaryInternal
                Console.WriteLine("InnerException " + e.InnerException.Message);//rien
                Console.WriteLine("Message " + e.Message);//Object reference not set to an instance of an object.
                Console.WriteLine("Source " + e.Source);//Source Exception
                Console.WriteLine("TargetSite " + e.TargetSite);//TargetSite Void Main(System.String[])


            }

            Console.WriteLine("Apres le catch");//EXECUTE*/


            //Division par zéro


            try
            {

                Console.Write("\n\nEntrez un nombre : ");
                int n = int.Parse(Console.ReadLine());//Si n=0 PAS EXECUTE et tout ce qui suit
                Console.WriteLine("100/nombre = {0}", 100 / n);
            }
            catch (Exception e)
            {
                Console.WriteLine("Entré dans Catch Exception = " + e.Message);
                //throw;
                Console.WriteLine("Source " + e.Source);//Source Exception
            }

            Console.WriteLine("Apres catch");//EXECUTE

            Console.Write("\n\nEntrez un nombre : ");
            int n1 = int.Parse(Console.ReadLine());//Si n=0 PAS EXECUTE et tout ce qui suit
            Console.WriteLine("100/nombre = {0}", 100 / n1);


        }
    }
}
