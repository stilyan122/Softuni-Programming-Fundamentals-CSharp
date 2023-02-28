using System;

namespace Messages
{
    class Messages
    {
        static void Main(string[] args)
        {
            int clickCount = int.Parse(Console.ReadLine());
            string mesage = string.Empty;

            for (int i = 0; i < clickCount; i++)
            {
                string digits = Console.ReadLine();
                int digitLenght = digits.Length;
                int digit = digits[0] - '0';
                int offset = (digit - 2) * 3;

                if (digit == 0)
                {
                    mesage += (char)(digit + 32);
                    continue;
                }
                if (digit == 8 || digit == 9)
                {
                    offset++;
                }
                int letter = offset + digitLenght - 1;
                mesage += (char)(letter + 97);
            }
            Console.WriteLine(mesage);
        }
    }
}
