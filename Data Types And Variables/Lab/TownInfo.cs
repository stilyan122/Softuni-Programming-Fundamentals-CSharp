using System;

namespace TownInfo
{
    class TownInfo
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            uint population = uint.Parse(Console.ReadLine());
            uint area = uint.Parse(Console.ReadLine());
            Console.WriteLine($"Town {name} has population of {population} and area {area} square km.");
        }
    }
}
