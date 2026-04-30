using System;
using System.Collections.Generic;
// PÄÄOHJELMA
namespace KauppalistaApp
{
    class Program
    {
        static List<IKauppatuote> kauppalista = new List<IKauppatuote>();

        static void Main()
        {
            kauppalista = Tiedostonhallinta.Lataa();

            while (true)
            {
                Console.WriteLine("\n1. Lisää | 2. Poista | 3. Näytä | 4. Tallenna ja Poistu");
                string v = Console.ReadLine();

                if (v == "1")
                {
                    Console.Write("Tuote: ");
                    kauppalista.Add(new Tuote(Console.ReadLine(), "Yleinen"));
                    Tiedostonhallinta.Tallenna(kauppalista);
                }
                else if (v == "2")
                {
                    Console.Write("Poista: ");
                    string n = Console.ReadLine();
                    kauppalista.RemoveAll(t => t.Nimi.ToLower() == n.ToLower());
                    Tiedostonhallinta.Tallenna(kauppalista);
                }
                else if (v == "3")
                {
                    kauppalista.ForEach(t => Console.WriteLine("- " + t.HaeTiedot()));
                }
                else if (v == "4") break;
            }
        }
    }
}