using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnes p1 = new Personnes("COURQUIN", "Pierre", 21, "courquin.pierre62@gmail.com");

            Console.WriteLine("Le nom de p1 est : " + p1.GetNom());
        }
    }
}
