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
        }
    }
}
