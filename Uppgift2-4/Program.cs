using System;

namespace Uppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lön 1");
            string Person1 = Console.ReadLine();
            Console.WriteLine("Lön 2");
            string Person2 = Console.ReadLine();
            Console.WriteLine("Lön 3");
            string Person3 = Console.ReadLine();
            int Lön1 = int.Parse(Person1);
            int Lön2 = int.Parse(Person2);
            int Lön3 = int.Parse(Person3);
            int Totallön = Lön1 + Lön2 + Lön3;
            int Medellön = Totallön / 3;
            Console.WriteLine("Medellönen är " + Medellön);
        }
    }
}