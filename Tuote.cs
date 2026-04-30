// OLIOLUOKKA
namespace KauppalistaApp
{
    public class Tuote : IKauppatuote
    {
        public string Nimi { get; set; }
        public string Kategoria { get; set; }

        public Tuote(string nimi, string kategoria)
        {
            Nimi = nimi;
            Kategoria = kategoria;
        }

        public string HaeTiedot() => $"{Nimi} ({Kategoria})";
    }
}