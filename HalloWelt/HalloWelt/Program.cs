using System;
using System.Windows;

namespace HalloWelt {
    class Program {
        static void Main(string[] args) {

            //int alter = 52;
            //string text = Convert.ToString(alter);
            // string text = "Hallo Welt";

            //int a = 1;
            int a = 1, b = 10, c = 15;

            Console.WriteLine("Hallo. Wie heißt Du?");

            string name = Console.ReadLine();

            Console.WriteLine("Wie alt bist Du?");
            //int alter = Convert.ToInt32(Console.ReadLine());

            //int alter = int.Parse(Console.ReadLine());
            try {
                if (Convert.ToBoolean(int.Parse(Console.ReadLine()))) {
                    Console.WriteLine("jup");
                } else {
                    Console.WriteLine("Leider nein");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }


            //Console.WriteLine("Aha, Du bist also {0} Jahre {1} {2} {3} als!",alter, alter, alter);
            //Console.WriteLine("Aha, du bist also " + alter + "Jahre alt!");

            Console.WriteLine($"Aha, Du heißt also {name}!");


            //Console.WriteLine(text);

            Console.ReadKey();
        }
    }
}
