using System.Numerics;

namespace _22szamjegy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generálj 22 számjegyű számokat, 12 ezer db-ot.


            Random rnd = new Random();
            List<string> szamok = new List<string>();
            string szamjegy = "";
            File.WriteAllText("22szamjegy.txt", "");
            for (int j = 0; j < 50; j++)
            {
                szamjegy = "";
                szamjegy += rnd.Next(1, 9).ToString();
                for (int i = 0; i < 22; i++)
                {
                    szamjegy += rnd.Next(0, 10).ToString();
                }
                szamok.Add(szamjegy);
                File.AppendAllText("22szamjegy.txt", szamjegy + "\n");
                Console.WriteLine(szamjegy.ToString());
            }

            //a fájlból találjuk meg a legnagyobb és legkisebb számot
            var sorok = File.ReadAllLines("22szamjegy.txt");
            string max = sorok[0];
            string min = sorok[0];

            foreach (var s in sorok)
            {
                if (s.CompareTo(max) > 0) max = s;
                if (s.CompareTo(min) < 0) min = s;
            }

            Console.WriteLine($"Legnagyobb: {max}");
            Console.WriteLine($"Legkisebb:  {min}");
            //a legnagyobb és legkisebb szám átlagától nézzük meg, hány szám nagyobb és kisebb

        }
    }
}
