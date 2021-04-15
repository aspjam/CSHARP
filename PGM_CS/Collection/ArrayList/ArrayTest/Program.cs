using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayTest
{
    class Program
    {
        enum Marque
        {
            Peugeot,
            Renault,
            Citroen
        }

        static void Main(string[] args)
        {
            /*
             ArrayList appartient au nemaspace System.Collections

              ArrayList est une liste à usage général qui stocke 
             une collection linéaire d'objets. 

            ArrayList:ICollection,IEnumerable,IList,ICloneable
             
            ICOllection:IEnumerable

                ICollection : Count 
                              CopyToArray Copie les éléments de ICollection dans Array, à partir d'un index particulier de Array.
                
                IEnumerable : Retourne un énumérateur qui itère au sein d’une collection.
                              "foreach"  implementer  IEnumerator GetEnumerator()
                              et retourne un objet dont la classe implemente IEnumerator
                                
                              IEnumerator :   Prend en charge une itération simple sur une collection non générique.
                                    Current : Obtient l’élément de la collection situé à la position actuelle de l’énumérateur.
                                    MoveNext() : Avance l’énumérateur à l’élément suivant de la collection.
                                    Reset() : Rétablit l'énumérateur à sa position initiale, qui précède le premier élément de la collection.

            Ilist

            Item[Int32] Obtient ou définit l'élément au niveau de l'index spécifié.
            
            MÉTHODES
            Add(Object)
            Ajoute un élément à IList.

            Clear()
            Supprime tous les éléments de IList.

            Contains(Object)
            Détermine si IList contient une valeur spécifique.

            CopyTo(Array, Int32)
            Copie les éléments de ICollection dans Array, à partir d'un index particulier de Array.(Hérité de ICollection)

            IndexOf(Object)
            Détermine l'index d'un élément spécifique d'IList.

            Insert(Int32, Object)
            Insère un élément dans IList à l’index spécifié.

            Remove(Object)
            Supprime la première occurrence d’un objet spécifique de IList.

            RemoveAt(Int32)
            Supprime l'élément IList au niveau de l'index spécifié.

            ICloneable
            MÉTHODES
            Clone()
            Crée un objet qui est une copie de l'instance actuelle.
             
             */

            ArrayList alist1 = new ArrayList();
            alist1.Add("Bonjour");
            alist1.Add(15);
            alist1.Add("Bonjour");
            alist1.Add(false);
            alist1.Add(new Produit());
            alist1.Add(false);
            alist1.Add(5.256);
            alist1.Add('A');
            alist1.Add(Marque.Renault);

            //Affichons les elemnts boucle foreach car ArrayList implemente IEnumerable
            foreach (var valeur in alist1)
            {
                Console.WriteLine(valeur);
            }

            /*
            Bonjour
            15
            Bonjour
            False
            ArrayTest.Produit
            False
            5,256
            A
            Renault             
             */

            /*Contains(Object)
            Détermine si IList contient une valeur spécifique.*/
            Console.WriteLine("\nContains");
            Console.WriteLine(alist1.Contains(5.256));//true
            Console.WriteLine(alist1.Contains(Marque.Renault));//true
            Console.WriteLine(alist1.Contains("bonjour"));//False Bonjour different bonjour sensible a la casse

            //PS public virtual bool Equals (object? obj);
            Produit p1 = new Produit();
            Produit p2 = p1;
            Produit p3 = new Produit();

            //== Operateur de comparaison de reference test si 2 objets ont la meme reference mais pas la valeur
            if (p2 == p1)
            { Console.WriteLine("p1 == p2"); }//ok
            else { Console.WriteLine("p1 != p2"); }
            Console.WriteLine(p2.Equals(p1));//True

            if (p3 == p1)
            { Console.WriteLine("p1 == p3"); }
            else { Console.WriteLine("p1 != p3"); }//ok
            Console.WriteLine(p3.Equals(p1));//False

            //La meme chose sauf que Equals on peut la surcharger 
            //et on peut comparer les valeurs de l-objet


            /*CopyTo(Array, Int32)
            Copie les éléments de ICollection dans Array, à partir d'un index particulier de Array.(Hérité de ICollection)*/

            int[] tab1 = new int[8];
            tab1[0] = 12;
            tab1[1] = 18;
            tab1[2] = 25;

            int[] tab2 = { 1000, 2000, 3000 };
            Console.WriteLine("tab1=" + tab1.GetType());//tab1=System.Int32[]
                                                        //tab1.CopyTo(alist1, 3);Conversion impossible ArrayList et Array

            //Copie tab2 dans tab1 a partir de l'indice 2 de tab1
            tab2.CopyTo(tab1, 2);
            AfficheCollection(tab1);
            /*
            12
            18
            1000
            2000
            3000
            0
            0
            0            
             */

            /* IndexOf(Object)
             Détermine l'index d'un élément spécifique d'IList.*/
            Console.WriteLine("\nIndexOf");
            Console.WriteLine(alist1.IndexOf("A"));//-1
            Console.WriteLine(alist1.IndexOf("Bonjour"));//0
            Console.WriteLine(alist1.IndexOf(Marque.Renault));//8

            /* Insert(Int32, Object)
             Insère un élément dans IList à l’index spécifié.*/
            Console.WriteLine("\nInsert");
            /*Bonjour
            15
            Bonjour
            False
            ArrayTest.Produit
            False
            5,256
            A
            Renault
            */
            alist1.Insert(3, "insertion");
            AfficheCollection(alist1);
            /*Bonjour
            15
            Bonjour
            insertion
            False
            ArrayTest.Produit
            False
            5,256
            A
            Renault*/

            //alist1.Insert(15, "insertion15");// ArgumentOutOfRange_ArrayListInsert

            /*Remove(Object)
            Supprime la première occurrence d’un objet spécifique de IList.*/
            Console.WriteLine("\nRemove");
            alist1.Remove("Bonjour");
            AfficheCollection(alist1);
            /*
             15
            Bonjour
            insertion
            False
            ArrayTest.Produit
            False
            5,256
            A
            Renault             
             */
            Console.WriteLine(alist1.Count);//9
            Console.WriteLine(alist1[0]);//15

            /*RemoveAt(Int32)
            Supprime l'élément IList au niveau de l'index spécifié.*/
            Console.WriteLine("\nRemoveAt");
            alist1.RemoveAt(4);
            AfficheCollection(alist1);
            /*
             15
            Bonjour
            insertion
            False
            False
            5,256
            A
            Renault
             */
            Console.WriteLine(alist1.Count);//8
            Console.WriteLine(alist1[0]);//15

            /*Clear()
            Supprime tous les éléments de IList.*/
            Console.WriteLine("\nClear");
            alist1.Clear();
            AfficheCollection(alist1);
            Console.WriteLine(alist1.Count);//0
            Console.WriteLine((alist1 == null) ? (true) : (false));//False

            //Tri il faut que les elements soient de meme type
            ArrayList alist2 = new ArrayList();
            alist2.Add("Bonjour");
            alist2.Add(15);
            alist2.Add("Bonjour");
            alist2.Add(false);
            alist2.Add(new Produit());
            alist2.Add(false);
            alist2.Add(5.256);
            alist2.Add('A');
            alist2.Add(Marque.Renault);

            //alist2.Sort();
            //AfficheCollection(alist2);
            /*
             System.InvalidOperationException: 
            Impossible de comparer deux éléments dans le tableau. 
            ---> System.ArgumentException: L'objet doit être de type String.
             */

            void AfficheCollection(ICollection array)
            {
                if (array is ICollection)
                {
                    foreach (var item in array)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine("Ce n'est pas une collection");
                }


            }


        }
    }

    class Produit { public int Prix = 100; }
    class Produit2 { public int Prix = 100; }
}
