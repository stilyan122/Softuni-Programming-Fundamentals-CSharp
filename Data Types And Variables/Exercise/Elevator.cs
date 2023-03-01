using System;

namespace Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int coursesCount = 0;

            while (numberOfPeople > 0 && numberOfPeople != 0)
            {
                numberOfPeople -= elevatorCapacity;
                coursesCount++;
            }
            Console.WriteLine(coursesCount);
        }
    }
}
