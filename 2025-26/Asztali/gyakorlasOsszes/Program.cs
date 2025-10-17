using OOPgyak6;

namespace majdElnevezem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KapucnisPulover kp = new KapucnisPulover("Pamut");
            kp.Meret = "L";
            Console.WriteLine(kp);
            kp.mosas();
            //ruha interface anyag tulajdonsággal, ami csak lekérdezhető, abstract class Pulover néven konstruktorral, osztaly kapucnis pulóver néven
        }
    }
}
