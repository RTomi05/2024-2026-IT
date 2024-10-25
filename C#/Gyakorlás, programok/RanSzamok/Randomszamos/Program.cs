namespace ezmostrandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] szamok = new int[10];


            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rand.Next(0, 2000);
            }

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i] + ", ");
            }
            Console.WriteLine();

            Console.Write("Kérem az első számot: ");
            int elsoSzam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem az első számot: ");
            int masodikSzam = Convert.ToInt32(Console.ReadLine());


            int[,] thisList = new int[elsoSzam, masodikSzam];


            for (int i = 0; i < thisList.GetLength(0); i++)
            {
                for (int j = 0; j < thisList.GetLength(1); j++)
                {

                    thisList[i, j] = rand.Next(100, 1000);
                }

            }

            foreach (int k in thisList)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine();

            Console.Write("Mennyi legyen a lista elemszáma? ");
            int darabszam = Convert.ToInt32(Console.ReadLine());

            int[] masodikLista= new int[darabszam];

            for (int i = 0; i < masodikLista.Length; i++)
            {
                masodikLista[i] = rand.Next(-300, 300);
            }
            foreach (int i in masodikLista)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();




        }
    }
}