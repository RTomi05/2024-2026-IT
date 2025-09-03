using System;

class LottoSorsolas
{
    static void Main()
    {
        Random rand = new Random();
        int[] lottoSzamok = new int[5];
        int szamIndex = 0;

        // A sorsolás
        while (szamIndex < 5)
        {
            int ujSzam = rand.Next(1, 91);  // Véletlenszerű szám 1 és 90 között
            bool isUnique = true;

            // Ellenőrizzük, hogy az új szám már szerepel-e a tömbben
            for (int i = 0; i < szamIndex; i++)
            {
                if (lottoSzamok[i] == ujSzam)
                {
                    isUnique = false;
                    break;  // Ha ismétlődik, kilépünk az ellenőrzésből
                }
            }

            // Ha egyedi számot találtunk, hozzáadjuk a tömbhöz
            if (isUnique)
            {
                lottoSzamok[szamIndex] = ujSzam;
                szamIndex++;
            }
        }

        // A sorsolt számok kiírása
        Console.WriteLine("Sorsolt számok:");
        foreach (int szam in lottoSzamok)
        {
            Console.Write(szam + ", ");
        }

        Console.WriteLine();  // Új sor a végén
    }
}
