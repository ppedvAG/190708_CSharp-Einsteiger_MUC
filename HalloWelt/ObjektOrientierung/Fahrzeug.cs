using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektOrientierung
{
    public class Fahrzeug
    {
        #region Felder
        // Felder
        private bool motorGestartet = false;
        private int maximaleGeschwindigkeit = 250;
        private Zustand aktuellerZustand = Zustand.Stehend;
        #endregion

        #region Eigenschaften

        //Eigenschaften
        enum Zustand { Stehend, Fahrend };
        public string Name { get; set; }
        public int MaximaleGeschwindigkeit { get => maximaleGeschwindigkeit; }
        public double Preis { get; set; }
        public int AktuelleGeschwindigkeit { get; private set; }
        #endregion

        #region Konstruktor
        // Konstruktor
        public Fahrzeug()
        {
            Console.WriteLine("Fahrzeug wurde instanziiert!");
            //BeschreibeMich();
            SetZustand();
        }
        #endregion

        #region Methoden
        // Methoden
        private void SetZustand()
        {
            while (AktuelleGeschwindigkeit > 0)
            {
                aktuellerZustand = Zustand.Fahrend;
            }
        }
        /// <summary>
        /// Funktion an der Klasse Fahrzeug -> Methode zum Beschleunigen des Fahrzeugs
        /// </summary>
        /// <param name="geschwindigkeitsSchritt">Datentyp des Parameters: int</param>
        public void Beschleunigen(int GeschwindigkeitsSchritt)
        {
            if (motorGestartet)
            {
                do
                {
                    AktuelleGeschwindigkeit += GeschwindigkeitsSchritt;
                    Console.WriteLine($"Das Auto beschleunigt um {GeschwindigkeitsSchritt} und fährt nun {AktuelleGeschwindigkeit} ");
                } while (AktuelleGeschwindigkeit < maximaleGeschwindigkeit);
                aktuellerZustand = Zustand.Fahrend;
            } else
            {
                Console.WriteLine("Motor wurde noch nicht gestartet!");
            }

        }
        public void StarteMotor()
        {
            motorGestartet = true;
            Console.WriteLine("Motor wurde gestartet!");
        }
        public void StoppeMotor()
        {
            motorGestartet = false;
            Console.WriteLine("Motor wurde gestoppt!");
        }
        public void BeschreibeMich()
        {
            Console.WriteLine($"Hersteller: {Name}");
            Console.WriteLine($"Maximale Geschwindigkeit: {MaximaleGeschwindigkeit}");
            Console.WriteLine($"Aktuelle Geschwindigkeit: {AktuelleGeschwindigkeit}");
            Console.WriteLine($"Aktueller Zustand: {aktuellerZustand}");
            Console.WriteLine($"Preis: {Preis}");
        }
        #endregion

    }
}
