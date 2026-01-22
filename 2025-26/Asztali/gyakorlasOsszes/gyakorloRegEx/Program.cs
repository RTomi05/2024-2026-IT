using System.Text.RegularExpressions;
namespace gyakorloRegEx

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string szoveg = "Lorem ipsum dolor sit amet," +
               "consectetur adipiscing elit." +
               "Ut dapibus orci id nulla accumsan lacinia." +
               "Phasellus suscipit eros quis malesuada porttitor." +
               "Sed porta nunc nec velit aliquet tempor.";
            Regex regex = new Regex(@".{2}met");
            var eredmeny = regex.Matches(szoveg);
            Console.WriteLine(eredmeny[0].Value);
            Console.WriteLine(eredmeny.Count);

            //hány négybetűs szó van a szövegben
            regex = new Regex(@"\w{4}");
            eredmeny = regex.Matches(szoveg);
            Console.WriteLine(eredmeny[0].Value);
            Console.WriteLine(eredmeny.Count);

        }
    }
}
