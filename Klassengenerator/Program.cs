using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> NamenListe = (new string[20] { "Aaron", "Christopher", "Mathias", "Theodor", "Paul G.", "Lucas", "Michael", "Stas", "Ezequiel", "Hannes", "Jessica", "Felix", "Alexander", "Paul R.", "Johannes", "Ekhard", "Till", "Jakob", "Peter", "Stefan" }).ToList();
            int größe;
            int gruppe = 1;

            Console.WriteLine("In wieviele Leute sollen in einer Gruppe sein?");
            größe = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            do
            {
                Console.WriteLine("Gruppe: {0}", gruppe++);
                Random r = new Random();

                for (int i = 0; i < größe && NamenListe.Count > 0; i++)
                {
                    int index = r.Next(0, NamenListe.Count - 1);
                    Console.WriteLine(NamenListe[index]);
                    NamenListe.RemoveAt(index);
                }

                Console.WriteLine(" ");


            } while (NamenListe.Count > 0);


            Console.ReadKey();




        }

    }
}
