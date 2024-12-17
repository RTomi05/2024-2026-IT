using utca;

string[] sorok = File.ReadAllLines("kerites.txt");

List<Telek> telkek = new List<Telek>();

int parosDb = 0;


for (int i = 0; i < sorok.Length; i++)
{
    telkek.Add(new Telek(sorok[i]));
    if (telkek[telkek.Count - 1].paros)
    {
        parosDb++;
        telkek[telkek.Count - 1].hazSzam = parosDb * 2;
    }
    else
    {
        telkek[telkek.Count - 1].hazSzam = (telkek.Count - parosDb)*2-1;
    }
        
}

Console.WriteLine("2. feladat\nAz eladott telkek száma: {0}",telkek.Count);

Console.WriteLine("3. feladat\nA páros oldalon adták el ");
Console.WriteLine(telkek[telkek.Count - 1].paros?"Páros:")