using System.ComponentModel.Design;

namespace valtozok
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			int egeszSzam = 2;
			float lebegoPontos;
			double d1, d2;

			Console.WriteLine(egeszSzam + 10);
			egeszSzam += 10;
			egeszSzam /= 5;
			egeszSzam %= 5;
			Console.WriteLine(egeszSzam);



			lebegoPontos = 12;
			lebegoPontos /= 5;
			Console.WriteLine("lebegő: " + lebegoPontos);


			d1 = 1;
			d2 = 2;

			d1 += 1.1;
			Console.WriteLine(d1);



			decimal dec = 12;

			string szo = "ALMAFA ÁGA";

			char c = 'q';
			Console.WriteLine(c);
			c++;
			Console.WriteLine(c);

			Console.BackgroundColor = ConsoleColor.Red;













			//Elágazások


			int szamAmitKitalaltam = 11;
			Console.Write("Adj meg egy számot: ");
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.BackgroundColor = ConsoleColor.Blue;
			szamAmitKitalaltam = Convert.ToInt32(Console.ReadLine());
			Console.ResetColor();

			if (szamAmitKitalaltam > 10)
			{
				Console.WriteLine("Tíznél nagyobb.");
			}
			else if (szamAmitKitalaltam < 10)
			{
				Console.WriteLine("Tíznél kisebb.");
			}

			if (szamAmitKitalaltam % 2 == 0)
			{
				Console.WriteLine("Páros");
			}
			else
			{
				Console.WriteLine("Páratlan");
			}
			//4-5-6 osztható-e VAGY csak 4-6tal osztható, VAGY	5-6-tal

			if (szamAmitKitalaltam % 4 == 0 && szamAmitKitalaltam % 6 == 0)
			{
				Console.WriteLine("Osztható 4-gyel és 6-tal is.");
			}
			else if (szamAmitKitalaltam % 5 == 0 && szamAmitKitalaltam % 6 == 0)
			{
				Console.WriteLine("Osztható 5-tel és 6-tal is.");
			}
			else if (szamAmitKitalaltam % 4 == 0 && szamAmitKitalaltam % 5 == 0 && szamAmitKitalaltam % 6 == 0)
			{
				Console.WriteLine("Osztható 4-gyel, 5-tel, 6-tal is.");
			}
			else {
				Console.WriteLine("Nem osztható.");
				}
			
		}
	}
}
