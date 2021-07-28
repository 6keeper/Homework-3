using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 14, y = 1, z = 5;
            x += y - x++ * z;
            Console.WriteLine($"X = {x},Y = {y},Z = {z}");
            z = --x - y * 5;
            Console.WriteLine($"X = {x},Y = {y},Z = {z}");
            y /= x + 5 % z;
            Console.WriteLine($"X = {x},Y = {y},Z = {z}");
            z = x++ + y * 5;
            Console.WriteLine($"X = {x},Y = {y},Z = {z}");
            x = y - x++ * z;
            Console.WriteLine($"X = {x},Y = {y},Z = {z}");
        }
    }
}
