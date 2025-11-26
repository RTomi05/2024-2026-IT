namespace metHU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("tavirathu13.txt");
            List<Adatok> adatLista = new List<Adatok>();

            adatLista = sorok.Select(sor => new Adatok(sor)).ToList();
            Console.WriteLine("2. feladat");
            Console.Write("Adja meg egy település kódját! Település: ");
            string varosKod = Console.ReadLine().ToUpper();
            var utolsoMeresAdat = adatLista
                .Where(adat => adat.telepules == varosKod)
                .Select(adat => adat.ido)
                .OrderBy(ido => ido)
                .Last();
            Console.WriteLine("Az utolsó mérési adat a megadott településről 23:45-kor érkezett.");
        }
    }
}
