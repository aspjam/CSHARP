using System;
using System.Collections;
using System.Globalization;

namespace Collection_SortedList_Queue_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortedList
            //Implémente ICollection IDictionary  IEnumerable ICloneable

            //Constructeurs

            /*             
            SortedList()
            Initialise une nouvelle instance de la classe SortedList 
            qui est vide, possède la capacité initiale par défaut et 
            est triée suivant l'interface IComparable implémentée par 
            chaque clé ajoutée à l'objet SortedList.
            */

            SortedList Slist1_num = new SortedList();
            SortedList Slist1_string = new SortedList();
            SortedList Slist1_obj = new SortedList();
            SortedList Slist1_tout = new SortedList();

            Slist1_num.Add(10, 12);
            Slist1_num.Add(1, 55);
            Slist1_num.Add(-5, 2);

            ShowList(Slist1_num);

            /* Trier par ordre croissant des clés
            -5 , 2
            1 , 55
            10 , 12             
             */
            //On ne peut pas avoir 2 clé identiques
            Slist1_string.Add("zgh", 12);
            Slist1_string.Add("cgh", 55);
            Slist1_string.Add("Zgh", 2);
            Slist1_string.Add("Art", 2);
            Slist1_string.Add("0rt", 2);
            Slist1_string.Add("5rt", 2);

            Console.WriteLine();
            ShowList(Slist1_string);

            /* Trier par ordre croissant des clés
            0rt , 2
            5rt , 2
            Art , 2
            cgh , 55
            zgh , 12
            Zgh , 2            
             */

            /*Slist1_obj.Add(new Produit(120), 12);
            Slist1_obj.Add(new Produit(14), 55);
            Slist1_obj.Add(new Produit(-9), 2);*/
            //System.InvalidOperationException:
            //Failed to compare two elements in the array.

            /*
            SortedList(IComparer)
            public SortedList (System.Collections.IComparer? comparer);

            public interface IComparer
            MÉTHODES
            Compare(Object, Object)

            Initialise une nouvelle instance de la classe SortedList
            qui est vide, possède la capacité initiale par défaut et 
            est triée suivant l'interface IComparer spécifiée.              
            */
            Comparer myCompIntl = new Comparer(new CultureInfo("fr-FR"));
            Console.WriteLine("Compare : " + myCompIntl.Compare("a", "b"));//-1
            Console.WriteLine("Compare : " + myCompIntl.Compare("b", "b"));//0
            Console.WriteLine("Compare : " + myCompIntl.Compare("b", "a"));//1

            Console.WriteLine("Compare : " + myCompIntl.Compare(12, 15));//-1
            Console.WriteLine("Compare : " + myCompIntl.Compare(13, 13));//0
            Console.WriteLine("Compare : " + myCompIntl.Compare(100.23, 0.123));//1


            SortedList Slist1_obj1 = new SortedList(new Compare_Produit());
            Slist1_obj1.Add(new Produit(120), 12);
            Slist1_obj1.Add(new Produit(14), 55);
            Slist1_obj1.Add(new Produit(-9), 2);

            Console.WriteLine();
            ShowList(Slist1_obj1);


            /*
            SortedList(IDictionary)
            Initialise une nouvelle instance de la classe SortedList 
            qui contient des éléments copiés à partir du dictionnaire 
            spécifié, possède la capacité initiale correspondant au
            nombre d'éléments copiés et est triée suivant l'interface 
            IComparable implémentée par chaque clé. 

            
             
            */

            Hashtable hash = new Hashtable();
            hash.Add("hash", 1000);
            hash.Add("hash2", 2000);
            hash.Add("hash3", 3000);

            SortedList l1 = new SortedList(hash);
            Console.WriteLine();
            ShowList(l1);
            /*
            hash , 12
            hash2 , 55
            hash3 , 2 
            */

            SortedList l2 = new SortedList(15);
            l2.Add("zgh", 12);
            l2.Add("cgh", 55);
            Console.WriteLine();
            ShowList(l2);

            Console.WriteLine(l1.Count);//3
            Console.WriteLine(l1.Capacity);//3

            Console.WriteLine(l2.Count);//2
            Console.WriteLine(l2.Capacity);//15

            Console.WriteLine(l1["hash"]);//1000
            l1.Keys;
            l1.Values;

            /*
             MÉTHODES
                Add(Object, Object)
                Ajoute un élément avec la clé et la valeur spécifiées dans un objet SortedList.
                
                Clear()
                Supprime tous les éléments d'un objet SortedList.
                
                Clone()
                Crée une copie superficielle d'un objet SortedList.

                Contains(Object)
                Détermine si un objet SortedList contient une clé spécifique.

                ContainsKey(Object)
                Détermine si un objet SortedList contient une clé spécifique.

                ContainsValue(Object)
                Détermine si un objet SortedList contient une valeur spécifique.                
                
                GetByIndex(Int32)
                Obtient la valeur à l'index spécifié d'un objet SortedList.
                
                GetKey(Int32)
                Obtient la clé à l'index spécifié d'un objet SortedList.

                GetKeyList()
                Obtient les clés d'un objet SortedList.
               
                GetValueList()
                Obtient les valeurs d'un objet SortedList.

                IndexOfKey(Object)
                Retourne l'index de base zéro de la clé spécifiée dans un objet SortedList.

                IndexOfValue(Object)
                Retourne l'index de base zéro de la première occurrence de la valeur spécifiée dans un objet SortedList.

                
                Remove(Object)
                Supprime d'un objet SortedList l'élément ayant la clé spécifiée.

                RemoveAt(Int32)
                Supprime l'élément à l'index spécifié d'un objet SortedList.
                SetByIndex(Int32, Object)
                Remplace la valeur à l'index spécifié dans un objet SortedList. 
             
             */

            void ShowList(SortedList collection)
            {
                foreach (DictionaryEntry item in collection)
                {
                    if (item.Key is Produit)
                    {
                        Produit prix = (Produit)item.Key;
                        Console.WriteLine(prix.Prix + " , " + item.Value);
                    }
                    else
                    {
                        Console.WriteLine(item.Key + " , " + item.Value);
                    }

                }
            }

        }
    }

    class Produit
    {
        public Produit(int prix)
        {
            Prix = prix;
        }

        public int Prix { get; set; }
        public string Marque = "Pomme";



    }
    class Compare_Produit : IComparer
    {
        public int Compare(object x, object y)
        {
            //Compare deux objets et retourne une valeur indiquant
            //si le premier est inférieur, égal ou supérieur au second.

            //Quand sort est appelé il compare 2 a 2 les clés qui sont des produits
            //Object x=Produit px_key passage par reference
            //Object y=Produit py_key passage par reference

            Produit px = (Produit)x;
            Produit py = (Produit)y;

            var prix_x = px.Prix;
            var prix_y = py.Prix;

            return prix_y.CompareTo(prix_x);
        }
    }
}
