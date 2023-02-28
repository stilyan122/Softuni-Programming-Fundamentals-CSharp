using System;

namespace LowerOrUpper
{
    class LowerOrUpper
    {
        static void Main(string[] args)
        {
            char someChar = char.Parse(Console.ReadLine());


            if (Char.IsLower(someChar))
            {
                Console.WriteLine("lower-case");
            }
            else if (Char.IsUpper(someChar))
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
