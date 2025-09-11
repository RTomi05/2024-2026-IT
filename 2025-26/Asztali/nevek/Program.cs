namespace nevek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 fájl fiúnevekkel
            //1 fájl lánynevekkel
            //1 fájl vezetéknevekkel
            //1 fájl, amelybe az összekevert neveket írjuk (kraftoljuk :D)
            Random rnd = new Random();

            //Olvassuk be a neveket egy listába
            List<string> fiuk = new List<string>();
            List<string> lanyok = new List<string>();
            List<string> vezeteknevek = new List<string>();
            fiuk = File.ReadAllLines("fiunevek.txt").ToList();
            lanyok = File.ReadAllLines("lanynevek.txt").ToList();
            vezeteknevek = File.ReadAllLines("vezeteknevek.txt").ToList();

            string teljesNev = "";
            //Ürítsük ki a nevek.txt fájlt
            File.WriteAllText("nevek.txt", "", System.Text.Encoding.UTF8);
            for (int i = 0; i < 100; i++)
            {
                int nem = rnd.Next(0, 2);
                int megEgy = rnd.Next(0, 2);
                if (nem == 0)
                {
                    teljesNev = vezeteknevek[rnd.Next(0, vezeteknevek.Count)] + " " + fiuk[rnd.Next(0, fiuk.Count)];

                    if (megEgy == 0)
                    {
                        teljesNev += " " + fiuk[rnd.Next(0, fiuk.Count)];
                    }
                }
                else
                {
                    teljesNev = vezeteknevek[rnd.Next(0, vezeteknevek.Count)] + " " + lanyok[rnd.Next(0, lanyok.Count)];
                    
                    if (megEgy == 1)
                    {
                        teljesNev += " " + lanyok[rnd.Next(0, lanyok.Count)];
                    }
                }
                Console.WriteLine(teljesNev);
                File.AppendAllText("nevek.txt", teljesNev + Environment.NewLine, System.Text.Encoding.UTF8);
            }
        }
    }
}
