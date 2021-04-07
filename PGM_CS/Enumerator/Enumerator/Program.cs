using System;

namespace Enumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] peopleArray = new Person[3]
         {
            new Person("John", "Smith"),
            new Person("Jim", "Johnson"),
            new Person("Sue", "Rabon"),
         };

            People peopleList = new People(peopleArray);

            foreach (Person p in peopleList)
            {
                Console.WriteLine(p.firstName + " " + p.lastName);
            }

        }

    }
}