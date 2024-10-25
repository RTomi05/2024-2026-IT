namespace gyakorlas2
{
	internal class Program
	{
		static Random rand = new Random();
		static int Generalas()
		{
			int szam = rand.Next(100, 1000);
			return szam;
		}

		/*
		 012 058 098 007
		 100 189 157
		 254 221 223
		 */

		static int[,] matrix()
		{
			int[,] vissza = new int[10, 10];
			for (int i = 0; i < vissza.GetLength(0); i++)
			{
				for (int k = 0; k < vissza.GetLength(1); k++)
				{
					vissza[i, k] = rand.Next();
				}
			}

			return vissza;
		}



		static void Main(string[] args)
		{
			//Háromjegyű véletlenszám generálás

			Random rand = new Random();
			int szam = rand.Next(100, 1000);
			Console.WriteLine(szam);


			//Függvénnyel

			int[] szamok = new int[100];

			for (int i = 0; i < 100; i++)
			{
				szamok[i] = Generalas();
			}

			for (int i = 0;i < szamok.Length;i++)
			{
				Console.WriteLine(szamok[i]);
			}
			
		}
	}
}
