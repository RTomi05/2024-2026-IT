namespace dictionary_gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("--------------Dictionary--------------");
            //Példányosítás
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Ádám", "Fortnite izé");
            dict.Add("Zoli", "Wrum-wrum");
            dict.Add("Balázs", "PHP SQL király");

            Console.WriteLine(dict["Ádám"]);
            Console.WriteLine(dict["ádám"]);

        }
    }
}
