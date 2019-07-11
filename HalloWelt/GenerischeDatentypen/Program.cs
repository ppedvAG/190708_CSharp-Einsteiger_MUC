using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerischeDatentypen
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dictionary<string, int> meinDictionary = new Dictionary<string, int>();
            //meinDictionary.Add("Kontostand", 3000);
            //List<string> StringListe = new List<string>();
            //StringListe.Add("Item 1-Liste1");
            //StringListe.Add("Item 2-Liste1");
            //StringListe.Add("Item 3-Liste1");
            //StringListe.Add("Item 4-Liste1");

            //List<string> StringListe2 = new List<string>();
            //StringListe2.Add("Item 1-Liste2");
            //StringListe2.Add("Item 2-Liste2");
            //StringListe2.Add("Item 3-Liste2");
            //StringListe2.Add("Item 4-Liste2");

            //Dictionary< string, List<string> > meinDictionary2 = new Dictionary<string, List<string>>();
            //meinDictionary2.Add("Liste1", StringListe);
            //meinDictionary2.Add("Liste2", StringListe2);

            //foreach (KeyValuePair<string, List<string>> eintrag in meinDictionary2)
            //{
            //    foreach(string key in meinDictionary2.Keys)
            //    {
            //        Console.WriteLine(meinDictionary2[key][0]);
            //        //Console.WriteLine(key);

            //    }
            //    //Console.WriteLine(eintrag.Key);
            //}
            List<string> einfacheStringListe = new List<string>();
            einfacheStringListe.Add("Listen-Element 1");
            //Predicate<int> match = new Predicate<int>()



            List<int> einfacheZahlenListe = new List<int>();
            einfacheZahlenListe.Add(1);
            einfacheZahlenListe.Add(2);
            einfacheZahlenListe.Add(3);
            einfacheZahlenListe.Add(3);
            einfacheZahlenListe.Add(3);
            einfacheZahlenListe.Add(3);
            //einfacheZahlenListe.Remove(3);
            List<int> Ergebnis = einfacheZahlenListe.FindAll(NurDreier);
            //einfacheZahlenListe.RemoveAll(NurDreier);
            foreach (int zahl in einfacheZahlenListe)
            {
                Console.WriteLine($"Aktuelles Element: {zahl}");
            }

            Queue<string> einfacheSchlange = new Queue<string>();
            einfacheSchlange.Enqueue("Schlangen-Element 1");
            einfacheSchlange.Enqueue("Schlangen-Element 2");

            Stack<string> einfacherStapel = new Stack<string>();
            einfacherStapel.Push("Stapel-Element 1");
            einfacherStapel.Push("Stapel-Element 2");


            Console.ReadLine();
        }
        static bool NurDreier(int i)
        {
            return i == 3;
        }
    }
}
