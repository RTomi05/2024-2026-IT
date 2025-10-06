namespace szoKer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kérjünk be szavakat, amiben csak betűk lehetnek
            //a jó szavakat tegyük bele egy listába mindaddig, amíg be nem írja valaki, hogy "vége!"
            string szo = "";
            List<string> szavak = new List<string>();
            do
            {
                Console.Write("Kérek egy szót: ");
                szo = Console.ReadLine();
                if (szo != "vége" && szo.All(char.IsLetter) && szo.Length != 0)
                {
                    szavak.Add(szo);
                }
                else if (szo != "vége" || szo == "\n")
                {
                    Console.WriteLine("Csak betűket tartalmazó szavakat fogadok el.");
                }
            }
            while (szo != "vége");
            //hosszúság szerint állítsuk be, majd hosszúságon belül állítsuk be ABC sorrendbe
            szavak.Sort();

            for (int i = 0; i+1 < szavak.Count; i++)
            {
                int szama = i;
                for (int j = i + 1; j < szavak.Count; j++)
                {
                    if (szavak[i].Length > szavak[j].Length)
                    {
                        i = j;
                    }
                        
                }
                string legrovidebb = szavak[i];
                szavak[i] = szavak[szama];
                szavak[szama] = legrovidebb;

            }
            //írjuk ki a listát

            for (int i = 0; i < szavak.Count; i++)
            {
                Console.WriteLine(szavak[i]);
            }

            //Console.Write("Rendezett lista: " + szavak);

            //Írjuk ki a listát egy fájlba
            File.WriteAllLines("rendezett.txt", szavak);

        }
    }
}
