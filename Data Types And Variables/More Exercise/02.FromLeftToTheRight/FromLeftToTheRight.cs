using System;

namespace FromLeftToTheRight
{
    class FromLeftToTheRight
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberCount; i++)
            {
                string numbers = Console.ReadLine();
                char delimiter = ' ';

                string[] nums = numbers.Split(delimiter);

                long leftNums = long.Parse(nums[0]);
                long rightNums = long.Parse(nums[1]);

                long numberGreat = rightNums;

                if (leftNums > rightNums)
                {
                    numberGreat = leftNums;
                }

                long sum = 0;

                while (numberGreat != 0)
                {
                    sum += numberGreat % 10;
                    numberGreat /= 10;
                }
                Console.WriteLine(Math.Abs(sum));

            }
        }
    }
}
