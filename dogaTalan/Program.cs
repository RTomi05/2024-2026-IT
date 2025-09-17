namespace dogaTalan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Szavak bevitele.
            Legyen lehetőség szavakat bevinni a programba, csak akkor fogadja el, ha 1 szó, tehát nincs benne szóköz, se speciális karakter.
            Ha mégis belekerül, akkor hibaüzenet mutatásával ne engedje a bevitelt.
            A bevitt szavak egy listába kerüljenek.
            Rendezd a listát csökkenő abc rendbe!
            Írd ki egy file-ba!
            Olvasd be a file adatait, és írd ki a képernyőre a lista középső elemét, vagy a középsőtől kisebbet nagybetűsítve!
            */
            List<string> szavak = new List<string>();
            string szo = "e";
            while (szo != "")
            {
                Console.Write("Kérek egy szót: ");
                szo = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(szo) && szo.All(char.IsLetter))
                {
                    szavak.Add(szo);
                }
                else
                {
                    Console.WriteLine("Csak betű fogadható el.");
                }
            }
            /*
            for (int i = 0; i < szavak.Count; i++)
            {
                Console.WriteLine(szavak[i]);
            }
            */

            szavak.Sort();
            szavak.Reverse();

            Console.WriteLine("A lista megfordítva:");

            for (int i = 0; i < szavak.Count; i++)
            {
                Console.WriteLine(szavak[i]);
            }

            File.WriteAllLines("szavak.txt", szavak);
            List<string> szavakUjra = File.ReadAllLines("szavak.txt").ToList();
            /*
            for (int i = 0; i < szavak.Count; i++)
            {
                Console.WriteLine(szavakUjra[i]);
            }
            */
            int kozepso = szavakUjra.Count / 2;
            if(szavakUjra.Count % 2 == 0)
            {
                Console.WriteLine("A középső elemnél eggyel kisebb: " + szavakUjra[kozepso - 1].ToUpper());
            }
            else
                Console.WriteLine("A középső elem: " + szavakUjra[kozepso]);
        }
    }
}
