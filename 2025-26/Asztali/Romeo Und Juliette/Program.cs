using System.Text.RegularExpressions;

namespace Romeo_Und_Juliette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string forras = File.ReadAllText("RomeoAndJuliette.txt");

            Regex rg = new Regex(@"[A-ZÖÜÓŐÚŰÉÁÍ-]{2,} [A-ZÖÜÓŐÚŰÉÁÍ-]{2,}|[A-ZÖÜÓŐÚŰÉÁÍ-]{2,}\b");
            var eredmeny = rg.Matches(forras);
            //Console.WriteLine(eredmeny.Count);

            foreach (Match match in eredmeny)
            {
                Console.WriteLine(match.Value);
            }
            Console.WriteLine();

            //Romeo és Júlia nevek keresése

            Regex rgRomeo = new Regex(@"ROMEO", RegexOptions.IgnoreCase);
            var eredmeny2 = rgRomeo.Matches(forras);

            Console.Write("Romeo név előfordulása: ");
            Console.WriteLine(eredmeny2.Count + " db.");
            Console.WriteLine();

            Regex ragRomeo = new Regex(@"\bRomeo[A-ZÖÜÓŐÚÉÁŰÍ]", RegexOptions.IgnoreCase);

            Regex rgJulia = new Regex(@"JÚLIA", RegexOptions.IgnoreCase);
            var eredmeny3 = rgJulia.Matches(forras);

            Console.Write("Júlia név előfordulása: ");
            Console.WriteLine(eredmeny3.Count + " db.");
            Console.WriteLine();

            Regex ragJulia = new Regex(@"\bJúlia[A-ZÖÜÓŐÚÉÁŰÍ]", RegexOptions.IgnoreCase);

            Regex szam = new Regex(@"[0-9]{4}");
            var szamok = szam.Matches(forras);
            Console.WriteLine(szamok.Count);
            Console.WriteLine();

            //Első ŐR első szavai
            Regex elsoOr = new Regex(@"ELSŐ ŐR\t([A-ZÖÜÓŐÚŰÉÁÍ]+)\s([A-ZÖÜÓŐÚŰÉÁÍ]+)", RegexOptions.IgnoreCase);

            var elsoOrSzavai = elsoOr.Match(forras);
            var eredmeny6 = elsoOr.Match(forras);
            Console.WriteLine(eredmeny6.Groups[2]);
            Console.WriteLine();

            elsoOr = new Regex(@"ELSŐ ŐR\t(?<elso>[A-ZÖÜÓŐÚŰÉÁÍ]+)\s(?<masodik>[A-ZÖÜÓŐÚŰÉÁÍ]+)", RegexOptions.IgnoreCase);
            eredmeny6 = elsoOr.Match(forras);
            Console.WriteLine(eredmeny6.Groups[1]);
            Console.WriteLine();
        }
    }
}
