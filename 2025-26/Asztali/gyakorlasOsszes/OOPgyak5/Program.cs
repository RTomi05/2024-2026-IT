namespace OOPgyak5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oktober23 okt23 = new Oktober23();
            okt23.Nev = "Október 23-i ünnepély";
            okt23.Rendezo = "Dergez-Mohari Katalin";
            okt23.Zajlik();
            okt23.Szereplok = new List<string> { "Hauptman Henrik", "Mészáros Róbert" };
            Console.WriteLine(okt23);
        }
    }
}
