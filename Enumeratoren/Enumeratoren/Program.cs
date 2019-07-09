using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeratoren
{
    class Program
    {
        enum Mahlzeiten
        {
            Frühstück, Mittagessen, Abendessen, Brotzeit
        };

        enum Tag { Montag=1, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag };
        enum Monat { Jan=1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Okt, Nov, Dez };

        enum MaschinenStatus
        {
            SaftAus = 0,
            Läuft = 5,
            StandBy = 10,
            Ruhemodus = StandBy + 5
        }


        static void Main(string[] args)
        {

            Tag heute = Tag.Dienstag;
            int tagesNummer = (int)heute;
            Console.WriteLine($"Der heutige Tag hat die Nummer {tagesNummer}");

            Monat aktuellerMonat = Monat.Jul;
            int monatsZahl = (int)aktuellerMonat;
            Console.WriteLine($"Der aktuelle Monat ist:{monatsZahl}");


            MaschinenStatus aktuellerStatus = MaschinenStatus.Läuft;
            Console.WriteLine($"{aktuellerStatus.ToString()}");

            Console konsole = new Console(); 




            //List<string> MahlzeitenArray = new List<string>();
            //MahlzeitenArray.Add("Frühstück");
            //MahlzeitenArray.Add("Montag");
            //MahlzeitenArray.Add("Dienstag");
            //MahlzeitenArray.Add("Montag");
            //MahlzeitenArray.Add("Montag");
            //MahlzeitenArray.Add("Montag");
            //Mahlzeiten Abendessen = Mahlzeiten.Abendessen;
            //Mahlzeiten Mittagessen = Mahlzeiten.Brotzeit;
            //foreach(string essen in MahlzeitenArray)
            //{
            //    Console.WriteLine($"{essen}");
            //}
            Console.ReadLine();
        }
    }
}

