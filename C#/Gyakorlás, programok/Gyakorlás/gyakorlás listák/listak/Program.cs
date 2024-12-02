namespace listak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);

            list.Add(1);
            list.Add(2);
            list.Add(2);

            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);

            Console.WriteLine(list[2]);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            list.Insert(3, 456);
            Console.WriteLine();
            for (int i = 0;i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Ezen a helyen van a 456: " + list.IndexOf(456));
        }
    }
}
