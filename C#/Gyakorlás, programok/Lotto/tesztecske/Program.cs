using System;
class LottoSorsolo
{
    static void Main()
    {
        // Lottó számok generálása
        List<int> lottoszamok = GenerálLottóSzámokat(6, 1, 90);

        // Kiírás
        Console.WriteLine("A húzott lottószámok:");
        foreach (int szam in lottoszamok)
        {
            Console.WriteLine(szam);
        }
    }

    // Metódus, ami véletlenszerű lottószámokat generál, ismétlés nélkül
    static List<int> GenerálLottóSzámokat(int darab, int min, int max)
    {
        Random random = new Random();

        // Az összes lehetséges számot betesszük egy listába
        List<int> lehetségesSzámok = new List<int>();
        for (int i = min; i <= max; i++)
        {
            lehetségesSzámok.Add(i);
        }

        List<int> kiválasztottSzámok = new List<int>();

        // Kiválasztjuk a szükséges számokat
        for (int i = 0; i < darab; i++)
        {
            // Véletlenszerű szám kiválasztása a listából
            int index = random.Next(lehetségesSzámok.Count);
            int kiválasztottSzám = lehetségesSzámok[index];

            // A kiválasztott számot eltávolítjuk a listából, hogy ne választhassuk újra
            lehetségesSzámok.RemoveAt(index);

            // A kiválasztott számot hozzáadjuk az eredményhez
            kiválasztottSzámok.Add(kiválasztottSzám);
        }

        // A számokat rendezzük növekvő sorrendbe
        kiválasztottSzámok.Sort();
        return kiválasztottSzámok;
    }
}
