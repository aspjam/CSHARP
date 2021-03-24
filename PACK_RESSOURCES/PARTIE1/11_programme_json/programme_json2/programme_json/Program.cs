using Newtonsoft.Json;
using System;

namespace programme_json
{
    class Personne
    {
        public string nom { get; private set; }
        public int age { get; private set; }
        public bool majeur { get; private set; }

        public Personne(string nom, int age, bool majeur)
        {
            this.nom = nom;
            this.age = age;
            this.majeur = majeur;
        }

        public void Afficher()
        {
            Console.WriteLine("Nom: " + nom + " - age: " + age + " ans");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var personne1 = new Personne("Toto", 20, true);
            personne1.Afficher();

            string json = JsonConvert.SerializeObject(personne1);
            Console.WriteLine(json);

            string jsonTiti = "{\"nom\":\"Titi\",\"age\":15,\"majeur\":false}";
            Personne titi = JsonConvert.DeserializeObject<Personne>(jsonTiti);
            titi.Afficher();
        }
    }
}
