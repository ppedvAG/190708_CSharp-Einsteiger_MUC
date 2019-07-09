using System;
using System.Windows;

namespace HalloWelt
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Eingabe/Ausgabe - Variablen
            //double ergebnis;

            //Console.WriteLine("Eine Zahl eingeben");
            //int eingabe1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Weitere Zahl");
            //double eingabe2 = Convert.ToDouble(Console.ReadLine());

            //int intSumme = eingabe1 + Convert.ToInt32(eingabe2);
            //double dblSumme = eingabe1 + eingabe2;
            //Console.WriteLine($"Int-Summe: {intSumme}, Double-Summe: {dblSumme}");
            //Console.WriteLine(Environment.NewLine);

            //if (eingabe1 > eingabe2)
            //{
            //    ergebnis = eingabe1 / eingabe2;
            //} else
            //{
            //    ergebnis = eingabe2 / eingabe1;
            //}

            //Console.WriteLine($"Ergebnis der Division: {ergebnis}");



            //int alter = 52;
            //string text = Convert.ToString(alter);
            // string text = "Hallo Welt";

            //int a = 1;
            //int a = 1, b = 10, c = 15;

            //Console.WriteLine("Hallo. Wie heißt Du?");

            //string name = Console.ReadLine();

            //Console.WriteLine("Wie alt bist Du?");
            ////int alter = Convert.ToInt32(Console.ReadLine());

            ////int alter = int.Parse(Console.ReadLine());
            //try {
            //    if (Convert.ToBoolean(int.Parse(Console.ReadLine()))) {
            //        Console.WriteLine("jup");
            //    } else {
            //        Console.WriteLine("Leider nein");
            //    }
            //} catch (Exception ex) {
            //    MessageBox.Show(ex.Message);
            //}


            //Console.WriteLine("Aha, Du bist also {0} Jahre {1} {2} {3} als!",alter, alter, alter);
            //Console.WriteLine("Aha, du bist also " + alter + "Jahre alt!");

            //Console.WriteLine($"Aha, Du heißt also {name}!");


            //Console.WriteLine(text);
            #endregion Eingabe/Ausgabe - Variablen

            #region Kontrollstrukturen
            //int a = 5, b = 10, c = 15, d = 20, e = 5;

            //if (a + b == c)
            //{
            //    Console.WriteLine("Wert der Variablen a entspricht Wert der Variablen b");
            //} else
            //{
            //    Console.WriteLine("Nichts trifft zu!");
            //}
            #endregion Kontrollstrukturen

            #region Zufallszahl 
            //Random generator = new Random();
            //int zufallszahl = generator.Next(1, 5);
            //Console.WriteLine("Bitte eine Zahl eingeben: ");
            //int benutzerEingabe = Convert.ToInt32(Console.ReadLine());
            //if (benutzerEingabe < zufallszahl)
            //{
            //    Console.WriteLine("Deine Eingabe war kleiner als die generierte Zufallszahl");
            //} else
            //{
            //    Console.WriteLine("Deine Eingabe war größer als die generierte Zufallszahl");
            //}
            //// MessageBox.Show(Convert.ToString(zufallszahl));
            #endregion Zufallszahl 

            #region Schleifen

            //bool ja = true;

            //while(ja)
            //{
            //    Console.WriteLine("Ja");

            //    for(int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine($"{i+1}ter Durchlauf.");
            //    }

            //    ja = false;

            //}

            // Alle geraden Zahlen von 1  bis 10
            // Modulo
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion Schleifen

            #region Arrays
            int[] zahlenListe = new int[]
            {
                1,2,3,4,5,6,7
            };


            for(int i = 1; i < zahlenListe.Length; i++)
            {
                Console.WriteLine($"{i}ter Durchlauf");
            }
            Console.WriteLine(zahlenListe.Length);
            Console.ReadKey();
            #endregion


            Console.WriteLine("--- ENDE ---");
            Console.ReadKey();
        }
    }
}
