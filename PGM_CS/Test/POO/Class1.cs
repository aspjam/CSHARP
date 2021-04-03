using System;

namespace POO
{

    public class Engin
    {
        public enum Carburants { GAZOIL, ESSENCE, FIOUL, ETHANOL }
        protected Carburants Carburant { get; set; }
        public string Marque { get; set; }

        public Engin()
        {
            this.Carburant = Carburants.GAZOIL;
        }

        public Engin(Carburants carb)
        {
            this.Carburant = carb;
        }

        public virtual void Rouler()
        {
            Console.WriteLine($"Vous roulez au {Carburant}");
        }

    }



    public class Camion : Engin
    {
        private int m_vitesse;
        public int Vitesse
        {
            get { return m_vitesse; }
            set { m_vitesse = value; }
        }

        public string Couleur { get; set; }



        public Camion() //: this(120)
        {
            Console.WriteLine("Constructeur par defaut et initilise Vitesse =120");
        }

        public Camion(int vitesse) : base(Carburants.ESSENCE)
        {
            this.Vitesse = vitesse;
        }

        public Camion(int vitesse, string couleur, Carburants carb) : base(carb)
        {
            this.Vitesse = vitesse;
            this.Couleur = couleur;
        }

        public override void Rouler()
        {
            Console.WriteLine($"Je suis un {this.ToString().Split('.')[1]}");
        }




    }

    public class Voiture : Engin
    {
        private int m_vitesse;
        public int Vitesse
        {
            get { return m_vitesse; }
            set { m_vitesse = value; }
        }

        public string Couleur { get; set; }



        public Voiture() //: this(120)
        {
            Console.WriteLine("Constructeur par defaut et initilise Vitesse =120" + Carburant);
        }

        public Voiture(int vitesse) : base(Carburants.ESSENCE)
        {
            this.Vitesse = vitesse;
        }

        public Voiture(int vitesse, string couleur, Carburants carb) : base(carb)
        {
            this.Vitesse = vitesse;
            this.Couleur = couleur;
        }

        public override void Rouler()
        {
            Console.WriteLine($"Je suis une {this.ToString().Split('.')[1]}");
        }



    }



}
