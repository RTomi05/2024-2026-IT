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
                .FirstOrDefault(new Adatok("   0"));
            var legnagyobb = adatLista.Where(a => a.homerseklet == adatLista.Max(x => x.homerseklet))
                .FirstOrDefault(new Adatok("   0"));
            //Console.WriteLine($"A legalacsonyabb hőmérséklet: {legkisebb.telepules} {legkisebb.idoString()}-kor: {legkisebb.homerseklet} fok. \r\n");
            //Console.WriteLine($"A legmagasabb hőmérséklet: {legnagyobb.telepules} {legnagyobb.idoString()}-kor: {legnagyobb.homerseklet} fok. \r\n");

            var rendezett = adatLista.OrderBy(adat => adat.homerseklet);
            Console.WriteLine("A legalacsonyabb hőmérséklet: {0} {1}-kor: {2} fok. \r\nA legmagasabb hőmérséklet: {3} {4}-kor: {5} fok.",
                rendezett.First().telepules,
                rendezett.First().idoString(),
                rendezett.First().homerseklet,
                rendezett.Last().telepules,
                rendezett.Last().idoString(),
                rendezett.Last().homerseklet
                );

            Console.WriteLine();
            Console.WriteLine("4. feladat");
            var csendesek = string.Join("\n", adatLista.Where(adat => adat.szelcsend()).Select(adat => adat.telepules + " " + adat.idoString()));
            Console.WriteLine(csendesek);

            Console.WriteLine();
            Console.WriteLine("5. feladat");
            var kozepek = adatLista
                .Where(adat => new int[] { 1, 7, 13, 19 }.Contains(adat.ora))
                .GroupBy(adat => adat.telepules)
                .Select(adat => new { telepules = adat.Key,
                                      atlag = adat.Average(x => x.homerseklet)});
            Console.WriteLine(kozepek);
        }
    }
}