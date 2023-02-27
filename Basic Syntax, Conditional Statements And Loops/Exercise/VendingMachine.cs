using System;

namespace VendingMachine
{
    class VendingMachine
    {
        static void Main(string[] args)
        {
            string coin = Console.ReadLine();
            double money = 0.0;
            while (coin != "Start")
            {
                double value = double.Parse(coin);
                if (value != 0.1 && value != 0.2 && value != 0.5 && value != 1 && value != 2)
                {
                    Console.WriteLine($"Cannot accept {value}");
                }
                else
                {
                    money += value;
                }
                coin = Console.ReadLine();
            }
            string product = Console.ReadLine();
            double price = 0.0;
            while (product != "End")
            {
                bool invalid = false;
                switch (product)
                {
                    case "Nuts":
                        price = 2.0;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1.0;
                        break;
                    default:
                        invalid = true;
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (price > money)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else if (price <= money && invalid == false)
                {
                    money -= price;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {money:f2}");
        }
    }
}
