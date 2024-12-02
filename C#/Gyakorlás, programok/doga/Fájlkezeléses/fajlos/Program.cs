namespace fajlos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] adatok = File.ReadAllLines("kod_B.txt");

            string beolvasott = File.ReadLines("kod_B.txt").First();
            Console.WriteLine(beolvasott);

            //string kulcs = "\n\r";

            //File.AppendText(kulcs);

            //StreamReader sr = new StreamReader("kod_B.txt");
            //string talanezjo = sr.ReadToEnd();

            //sr.Close();
            //Console.WriteLine(talanezjo);


            //StreamWriter sw = new StreamWriter("kod_B.txt");
            //sw.WriteLine(talanezjo);

            //sw.Close();

            /*
            using (StreamReader inputFile = new StreamReader("kod_B.txt"))
            {
                int sorszam = 1;

                
                for (int i = 1; i < sorszam; i++)
                {
                    string elsoSor = inputFile.ReadLine();

                if(sorszam == 1)
                {
                    sw.WriteLine(elsoSor);
                }
                }

                Console.WriteLine(inputFile.ReadLine());
                Console.WriteLine(sorszam);
              */
            
        }
    }
}
