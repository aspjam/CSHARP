using System;
using System.Collections;

namespace Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack Représente une simple collection non générique
            //d’objets de type dernier entré, premier sorti (LIFO).

            /*
             Implémente : ICollection  IEnumerable  ICloneable
             
             CONSTRUCTEURS
                Stack()	
                Stack(ICollection)	
                Stack(Int32)

            Propriété Count

           
            MÉTHODES
            Clear()	
            Supprime tous les objets du Stack.

            Clone()	
            Crée une copie superficielle de Stack.

            Contains(Object)	
            Détermine si le Stack contient un élément.

            Pop()	
            Supprime et retourne l’objet en haut de Stack.

            Push(Object)	
            Insère un objet en haut de Stack.  
            
            ToArray()	
            Copie les éléments Queue vers un nouveau tableau.
             */

            //Stack()
            int i = 50;
            Produit p = new Produit(120);
            string[] mot = { "pomme", "poire" };
            bool t = true;

            Stack s1 = new Stack();
            s1.Push(i);
            Show(s1);//50
            s1.Push(t);
            Show(s1);//true 50
            s1.Push(p);
            Show(s1);//Stack_Queue.Produit True 50

            ArrayList l = new ArrayList();

            var t3 = s1.ToArray();
            Console.WriteLine();
            Show(t3);
            Console.WriteLine(t3[2]);//50
            Console.WriteLine(((Produit)t3[0]).Prix);//120

            s1.Pop();
            Console.WriteLine();
            Show(s1);//True 50

            /*
             Le Premier Element du stack est en fait le dernier entrer
            Les elements sont insérer par le debut de la collection
             */

            var f = s1.Peek();
            Console.WriteLine();
            Console.WriteLine(f);//True retourne le dernier element rentrer en haut de la pile
                                 //Sans rien supprimer
            Console.WriteLine();
            Show(s1);//True 50

            Console.WriteLine(/****Stack****/);
            Stack s3 = new Stack();
            for (int i1 = 1; i1 <= 3; i1++)
            {
                s3.Push(i1);
            }


            Console.WriteLine();
            Console.WriteLine(/****Queue****/);
            Show(s3);//1 2 3
                     //Premier entrer a indice 0
                     //Deuxieme a indice 1
                     //Ici pas de decallage




            //Queue Représente une collection d’objets premier entré, premier sorti.
            //FiFO First input first output
            /*
             //Constructeur comme stack

            //Count

            //Methodes idem que Stack sauf

            Dequeue()	
            Supprime et renvoie l'objet au début de la Queue.

            Enqueue(Object)	
            Ajoute un objet à la fin de la Queue.
             
             */

            Queue q = new Queue();
            for (int i1 = 1; i1 <= 3; i1++)
            {
                q.Enqueue(i1);
            }
            Console.WriteLine();
            Console.WriteLine(/****Queue****/);
            Show(q);//1 2 3

            Console.WriteLine();
            q.Dequeue();
            Show(q);//2 3

            Console.WriteLine();
            var g = q.Peek();
            Console.WriteLine(g);//2

            Console.WriteLine();
            Show(q);//2 3

            void Show(ICollection collection)
            {
                foreach (var item in collection)
                {
                    Console.WriteLine(item);
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


    }


}
