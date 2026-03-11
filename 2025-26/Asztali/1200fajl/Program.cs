namespace _1200fajl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1200 fájl létrehozása
            for (int i = 1; i <= 1200; i++)
            {
                string fileName = $"a_{i}.txt";
                File.WriteAllText(fileName, "a");
            }
        }
    }
}
