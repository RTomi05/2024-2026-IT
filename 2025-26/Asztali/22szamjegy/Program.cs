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
            for (int j = 0; j < 12000; j++)
            {
                szamjegy = "";
                for (int i = 0; i < 22; i++)
                {
                    szamjegy += rnd.Next(0, 10).ToString();
                }
                szamok.Add(szamjegy);
                File.AppendAllText("22szamjegy.txt", szamjegy + "\n");
                Console.WriteLine(szamjegy.ToString());
            }

            //a fájlból találjuk meg a legnagyobb és legkisebb számot

            long legnagyobb = 0;
            long legkisebb = 0;
            for (int i = 0; i < szamok.Count; i++)
            {
                
            }
            //a legnagyobb és legkisebb szám átlagától nézzük meg, hány szám nagyobb és kisebb
        }
    }
}
