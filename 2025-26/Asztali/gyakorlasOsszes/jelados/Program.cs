namespace jelados

internal class Program
{
    static void Main(string[] args)
    {
        string[] sorok = File.ReadAllLines("jel.txt");
        List<Adat> adatok = new List<Adat>();
        
        sorok
            .ToList()
            .ForEach(x => {
                adatok.Add(new Adat(x));
            });
        adatok = sorok.ToList().Select(x => new Adat(x)).ToList();
    }
}
