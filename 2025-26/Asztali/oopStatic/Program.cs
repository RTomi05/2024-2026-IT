namespace oopStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //példányosítás nélkül is elérhető a statikus osztály

            Proba p1 = new Proba();
            p1.fv2();

            Proba.fv1();
            Console.WriteLine(Proba.egyik);
            Proba.egyik = "Másik";
            Console.WriteLine(Proba.egyik);

            //Új osztály, aminek van egy static függvénye -> a és b paraméter segítségével c oldalt számol
            ////majd visszaadja számként
            ///Másik függvény, ami 3 oldalt kap és visszaadja a kerületet
            ///Static függvény, ami kiszámolja a háromszög területét (3 oldalt kap meg)
            ///
            Console.WriteLine(Haromszoges.c(3, 4));
            Console.WriteLine(Haromszoges.Kerulet(3,5,6));
        }
    }
}
