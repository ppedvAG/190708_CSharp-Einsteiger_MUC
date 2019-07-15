using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateiOperationen
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp\Textdatei.txt";
            Console.WriteLine(File.ReadAllText(path));

            List<string> liste = new List<string>();
            liste.Add("Erster Eintrag");
            liste.Add("Zweiter Eintrag");

            foreach(string aktuellerEintrag in liste)
            {
                File.AppendAllText(@"c:\temp\zurueckgeschrieben.txt", aktuellerEintrag);
            }            

            //File.WriteAllText(@"c:\temp\zurueckgeschrieben.txt", $"Uberschrieben {Environment.NewLine}Uberschreiben");
            //File.AppendAllText(@"c:\temp\zurueckgeschrieben.txt", $"Anhängen,{Environment.NewLine} Anhängen");

            Console.ReadLine();
        }
    }
}
