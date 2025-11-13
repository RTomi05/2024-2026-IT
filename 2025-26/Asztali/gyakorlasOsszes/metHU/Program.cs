namespace metHU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("tavirathu13.txt");
            List<Adatok> adatLista = new List<Adatok>();

            adatLista = sorok.Select(sor => new Adatok(sor)).ToList();
        }
    }
}
