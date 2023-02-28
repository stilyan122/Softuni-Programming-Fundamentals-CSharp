using System;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            var item = Console.ReadLine();
            var reverseItem = " ";

            for (int i = item.Length - 1; i >= 0; i--)
            {
                reverseItem += item[i];
            }
            Console.WriteLine(reverseItem);
        }
    }
}
