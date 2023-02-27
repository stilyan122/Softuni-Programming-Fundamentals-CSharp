using System;

namespace Orders
{
    class Orders
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double total = 0.0;
            for (int i = 0; i < n; i++)
            {
                double price = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());
                double cost = price * days * capsules;
                total += cost;
                Console.WriteLine($"The price for the coffee is: ${cost:f2}");
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
