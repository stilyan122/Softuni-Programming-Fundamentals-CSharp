using System;

namespace CharsToString
{
    class CharsToString
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirthChar = char.Parse(Console.ReadLine());

            Console.WriteLine($"{firstChar}{secondChar}{thirthChar}");
        }
    }
}
