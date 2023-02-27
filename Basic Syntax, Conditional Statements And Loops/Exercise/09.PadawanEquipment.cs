using System;

namespace PadawanEquipment
{
    class PadawanEquipment
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaber = double.Parse(Console.ReadLine());
            double robe = double.Parse(Console.ReadLine());
            double belt = double.Parse(Console.ReadLine());
            int freeBelts = 0;
            for (int i = 1; i <= students; i++)
            {
                if (i%6==0)
                {
                    freeBelts++;
                }
            }
            double price = lightsaber * (students + Math.Ceiling(0.10 * students))+robe*students+belt*(students-freeBelts);
            if (price<=money)
            {
                Console.WriteLine($"The money is enough - it would cost {price:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(price-money):f2}lv more.");
            }
        }
    }
}
