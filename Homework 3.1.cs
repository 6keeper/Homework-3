using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi = Math.PI;

            Console.WriteLine("Please insert radius");
            var Radius = int.Parse(Console.ReadLine());

            Console.WriteLine("Please insert heighth");
            var Heighth = int.Parse(Console.ReadLine());

            var Superf = Pi * Radius * (Radius + Heighth);
            Console.WriteLine($"Sector equals {Superf}");
        }
    }
}
