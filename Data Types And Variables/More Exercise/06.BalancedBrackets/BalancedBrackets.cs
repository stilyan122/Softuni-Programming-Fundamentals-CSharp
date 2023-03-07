using System;

namespace BalancedBrackets
{
    class BalancedBrackets
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int openingBracket = 0;
            int closingBracket = 0;

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    openingBracket++;
                }
                if (input == ")")
                {
                    closingBracket++;
                }
                if (closingBracket > openingBracket)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }
            if (closingBracket == openingBracket)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
