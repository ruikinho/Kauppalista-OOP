using System.Collections.Generic;
using System.IO;
// TALLENNUS JA LATAUS!
namespace KauppalistaApp
{
    public static class Tiedostonhallinta
    {
        private static string tiedosto = "kauppalista.txt";

        public static void Tallenna(List<IKauppatuote> lista)
        {
            using (StreamWriter sw = new StreamWriter(tiedosto))
            {
                foreach (var t in lista)
                {
                    sw.WriteLine($"{t.Nimi};Yleinen");
                }
            }
        }

        public static List<IKauppatuote> Lataa()
        {
            List<IKauppatuote> ladatut = new List<IKauppatuote>();
            if (File.Exists(tiedosto))
            {
                foreach (string rivi in File.ReadAllLines(tiedosto))
                {
                    string[] osat = rivi.Split(';');
                    if (osat.Length == 2) ladatut.Add(new Tuote(osat[0], osat[1]));
                }
            }
            return ladatut;
        }
    }
}