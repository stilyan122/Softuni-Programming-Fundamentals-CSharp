using System;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0.0;
            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16.00;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price = 15.00;
                            break;
                        case "Saturday":
                            price = 20.00;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            double cost = price * count;
            if (type == "Students" && count >= 30)
            {
                cost -= 0.15 * cost;
            }
            else if (type == "Business" && count >= 100)
            {
                cost = (count - 10) * price;
            }
            else if (type == "Regular" && count >= 10 && count <= 20)
            {
                cost -= 0.05 * cost;
            }
            Console.WriteLine($"Total price: {cost:f2}");
        }
    }
}
