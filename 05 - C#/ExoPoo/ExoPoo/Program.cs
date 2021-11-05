using System;

namespace ExoPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Voitures v1 = new Voitures("Noir","Citroen", "C4" , 10000, "essence");
            Voitures v2 = new Voitures("Rouge", "Renault", "Kadjar", 845, "Diesel");
            v1.Rouler(50);
            Console.WriteLine(v1);
            Console.WriteLine(v2);
        }
    }
}
