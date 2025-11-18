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
                .Select(adat => adat.idoString())
                .OrderBy(ido => ido)
                .Last();
            //Console.WriteLine(utolsoMeresAdat);
            Console.WriteLine($"Az utolsó mérési adat a megadott településről {utolsoMeresAdat}-kor érkezett.");

            Console.WriteLine();
            Console.WriteLine("3. feladat");
            var legkisebb = adatLista.Where(a => a.homerseklet == adatLista.Min(x => x.homerseklet))
                .First();
            Console.WriteLine($"A legalacsonyabb hőmérséklet:{legkisebb.telepules} 23:45-kor: {legkisebb.homerseklet} fok.");
        }
    }
}