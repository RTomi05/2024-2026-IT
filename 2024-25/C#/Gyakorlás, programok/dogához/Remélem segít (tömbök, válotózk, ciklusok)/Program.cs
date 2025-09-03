namespace Vanda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kiíratás úgy, hogy a következő kiírás új sorban kezdődjön
            Console.WriteLine("Szia, Vanda!");
            //Kiíratás úgy, hogy a következő kiírás mellette kezdődjön
            Console.Write("Szia, Vanda!");
            Console.Write("Szia, Vanda!");



            //Változók használata
            //int -> egész szám
            //float -> "lebegő" szám, igazából tizedesjegyű
            //double -> tizedesjegyű szám

            //Változó létrehozása: a típusa (pl int), a neve (pl egeszSzam) = érték (pl 2)
            //Az = jellel lehet neki értéket adni
            int egeszSzam = 2;

            //Nem muszáj egyből értéket adni neki, lehet úgy is csinálni változót, hogy nem adod meg egyből neki az értékét.
            //Ilyenkor csak a típusát (pl float) és a nevét (pl lebegoPontos) kell megadni.
            float lebegoPontos;
            double d1;

            //Apró műveletek
            //Kiiratja egy új sorba az egeszSzam új értékét: Hozzáad az egeszSzam változóhoz tizet. Az eredmény így 12.
            Console.WriteLine(egeszSzam + 10);

            //Hozzáadás
            egeszSzam += 10;
            //Osztás
            egeszSzam /= 5;
            //Maradék kiíratása
            egeszSzam %= 5;

            //Kiirathatunk egy szöveget, majd utána a változó értékét.
            Console.WriteLine("A szám: " + egeszSzam);




            //Konzol színezése
            //Betűszín
            Console.ForegroundColor = ConsoleColor.Green;
            //Háttérszín
            Console.BackgroundColor = ConsoleColor.Red;


            //Elágazások

            //Kérjünk be egy számot. A Convert.ToInt32() jelzi a programnak, hogy számot fogunk bekérni.
            Console.Write("Adj meg egy számot: ");
            int szamAmitKitalaltam = Convert.ToInt32(Console.ReadLine());

           //Szín visszállítása
            Console.ResetColor();
            Console.WriteLine("Visszaállítjuk a színt eredetire, hogy ne vakuljunk meg.");

            //HA (if) parancs használata
            //Ha a szamAmitKitalaltam nagyobb mint 10, akkor írja ki, hogy a szám tíznél nagyobb.
            if (szamAmitKitalaltam > 10)
            {
                Console.WriteLine("Tíznél nagyobb.");
            }


            //Ha egy if ciklus továbbmegy, nem jó az első ágában, akkor az "else if" parancsot kell használnunk.
            //Ha teljesen új ciklust generálunk, akkor természetesen lehet if-fel kezdeni ismét.
            //Ha ez nem teljesül, és a szám kisebb, mint 10, akkor írja ki, hogy a szám tíznél kisebb.

            else if (szamAmitKitalaltam < 10)
            {
                Console.WriteLine("Tíznél kisebb.");
            }

            //Ha a szám osztható kettővel (itt a szamAmitKitalaltam % 2 == 0 azt jelenti, hogyha a megadott számot (szamAmitKitalaltam) kettővel osztjuk, és nulla a maradéka (%) akkor a ciklusnak ezen része fusson le.

            if (szamAmitKitalaltam % 2 == 0)
            {
                Console.WriteLine("Páros");
            }

            //Ha a szám nem páros, akkor nyilván csak pératlan lehet :)
            else
            {
                Console.WriteLine("Páratlan");
            }


            //Az & egy operátor, ami az "és" kulcsszót fejezi ki. A ciklus akkor fut le, ha mindkét feltétel igaz.
            //Ha a szám osztható néggyel maradék nélkül ÉS hattal is, akkor írja ki, hogy a szám osztható 4-gyel és 6-tal is.
            if (szamAmitKitalaltam % 4 == 0 && szamAmitKitalaltam % 6 == 0)
            {
                Console.WriteLine("Osztható 4-gyel és 6-tal is.");
            }






            //Tömbök és ciklusok használata

            //Az int[]-tel jelezzük, hogy egy számokat tartalmazó tömböt fogunk készíteni, a new int[] pedig jelzi, hogy 6 eleme lesz.
            int[] szamok = new int[6];

            //Ez az alap for ciklus, ami egy bejárós ciklus, jelen estben annyiszior fut le, ahány számra szükségünk van.
            //Csinál egy ideiglenes változót (int i = 0), azt utána megvizsgálja, hogy a szamok tömbnek egyezik-e az elemszámával az i változó
            //Majd amíg az i nem egyezik az elemszámmal, addig mindig plusz egyet adjon az i-hez.
            //Ez azt eredményezi, hogy a ciklus addig fut, amíg az i nem lesz egyenlő a szamok tömb elemszámával.
          
            for (int i = 0; i < szamok.Length; i++)
            {
                //Ez itt egy szimpla bekérés. A write-tal kiiírjuk, hogy mit kérünk be, majd a szamok[i] = blabla résszel tesszük bele a tömbbe a bekért számot.
                Console.Write("Írj be egy számot: ");
                szamok[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Ez egy kiíratás, ha a szamok tömb elemeit szeretnénk kiírni, a foreach ide nagyon hasznos.
            Console.WriteLine();
            foreach (int i in szamok)
            {
                // A , azt jelzi csak, hogy a számok közt az lesz az elválasztó karakter.
                Console.Write(i + ", ");
            }

            Console.WriteLine();




            //Valami egyszerűvel kezdjünk :D
            //Legyen az, hogy addig íratjuk ki a k változót, amíg az el nem éri a 10-et.
            //Létrehozunk egy int (egész szám) típusú k nevű változót, amit egyenlővé teszünk eggyel.
            int k = 1;
            //while -> amíg valami érvényes
            //Jelen esetben, amíg a k nem nagyobb vagy egyenlő (<=) tízzel, írja ki a k számot.
            while (k <= 10)
            {
                Console.WriteLine(k);
                //A k++ mindig egyet ad hozzá az addigi értékhez. Ha eddig 1 volt, most 2 lesz.
                k++;
            }




            //Nézzük meg mi van akkor, ha ki akarok iratni minden számot pl ezerig.
            //Csinálunk ugye egy változót
            int egyeloreSzam = 0;
            
            //while -> amíg valami érvényes
            //Jelen esetben: amíg az egyeloreSzam NEM egyenlő (!=) 1000-rel, írja ki az egyeloreSzamot.
            //Az egyeloreSzam++ mindig egyet ad hozzá az addigi értékhez. Ha eddig 4 volt, most 5 lesz.
            while (egyeloreSzam != 100)
            {
                egyeloreSzam++;
                //A ToString() egy konvertáló parancs, ideiglenesen szövegként (stringként) írja ki a számot.
                Console.Write(egyeloreSzam.ToString() + ";");
            }


            //Mi van akkor, ha én kitalálok egy számot, és azt mondom, hogy amíg nem az a szám van beírva, fusson a program?
            //Újra egy változó
            Console.WriteLine();
            int bekert = 0;
            //Újra az amíg ciklus
            while (bekert != 10)
            {
                //Újabb bekérés
                Console.Write("Adj meg egy egész számot: ");
                bekert = Convert.ToInt32(Console.ReadLine());
                if (bekert == 10)
                {
                    //Ha eltalálod a számot, hagyja abba a futását a ciklusnak. (ez a break)
                    break;
                }
            }
        }
    }
}
