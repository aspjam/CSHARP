using System;
using System.Collections;
using System.Text;

namespace Hashtable_Name
{
    class Program
    {

        /*
           Hashtable est une classe de dictionnaire à usage général 
             qui stocke une collection de paires clé / valeur
         
         Implémente
            ICollection  IDictionary  IEnumerable  ICloneable  
            IDeserializationCallback  ISerializable
            
            IDictionary:ICollection            
         
            PROPRIÉTÉS
            Count
            Obtient le nombre d’éléments contenus dans le ICollection.(Hérité de ICollection)
        
            Item[Object]
            Obtient ou définit l'élément à l'aide de la clé spécifiée.        
         
            Keys
            Obtient un objet ICollection contenant les clés de l'objet IDictionary.        
         
            Values
            Obtient un objet ICollection contenant les valeurs de l'objet IDictionary.         
         
            MÉTHODES
            Add(Object, Object)
            Ajoute un élément avec la clé et la valeur fournies à l'objet IDictionary.

            Clear()
            Supprime tous les éléments de l'objet IDictionary.

            Contains(Object)
            Détermine si l'objet IDictionary contient un élément avec 
            la clé spécifiée.

            CopyTo(Array, Int32)
            Copie les éléments de ICollection dans Array, 
            à partir d'un index particulier de Array.(Hérité de ICollection)

            GetEnumerator()
            Retourne un objet IDictionaryEnumerator pour l’objet IDictionary.

            Remove(Object)
            Supprime de l’objet IDictionary l’élément ayant la clé spécifiée.
*/


        static void Main(string[] args)
        {

            /*Add(Object, Object)
            Ajoute un élément avec la clé et la valeur fournies à l'objet IDictionary.*/
            var p = new Produit();


            Hashtable hash = new Hashtable();
            hash.Add("cle_string0", "value_string0");
            hash.Add("cle_string1", 12.56);
            hash.Add(12.56, "value_string1");
            hash.Add(12, 55.236);
            hash.Add(true, 55);
            hash.Add(p, "objet");
            hash.Add(false, p);

            Console.WriteLine(hash.Count);//7

            Console.WriteLine("\nKeys");
            Show_Keys(hash.Keys);
            /*
            12,56
            cle_string1
            cle_string0
            Hashtable_Name.Produit
            True
            12
            False
             */

            Console.WriteLine("\nValues");
            Show_Values(hash.Values);
            /*             
            value_string1
            12,56
            value_string0
            objet
            55
            55,236
            Hashtable_Name.Produit
             */

            Console.WriteLine("\nHash item");
            Show_Hash(hash);
            /*
            System.Collections.DictionaryEntry
            System.Collections.DictionaryEntry
            System.Collections.DictionaryEntry
            System.Collections.DictionaryEntry
            System.Collections.DictionaryEntry
            System.Collections.DictionaryEntry
            System.Collections.DictionaryEntry
             */

            /* Item[Object]
             Obtient ou définit l'élément à l'aide de la clé spécifiée.*/
            Console.WriteLine(hash["cle_string1"]);//12.56

            // Contains(Object)
            /* Détermine si l'objet IDictionary contient un élément avec 
             la clé spécifiée.*/
            Console.WriteLine(hash.Contains("cle_string1"));//True+

            /*  Remove(Object)
              Supprime de l’objet IDictionary l’élément ayant la clé spécifiée.*/
            hash.Remove("cle_string1");

            /*Clear()
            Supprime tous les éléments de l'objet IDictionary.*/
            hash.Clear();

            void Show_Hash(Hashtable hash1)
            {
                foreach (var item in hash1)
                {
                    Console.WriteLine(item);

                }
            }

            void Show_Keys(ICollection keys)
            {
                foreach (var item in keys)
                {
                    Console.WriteLine(item);
                }
            }
            void Show_Values(ICollection values)
            {
                foreach (var item in values)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }

    class Produit { }
}
