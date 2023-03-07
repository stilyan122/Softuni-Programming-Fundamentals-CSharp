using System;

namespace DecryptingMessage
{
    class DecryptingMessage
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string decryptedMessage = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char characters = char.Parse(Console.ReadLine());

                int sum = key + characters;
                char message = (char)sum;

                decryptedMessage += message;
            }
            Console.WriteLine(decryptedMessage);
        }
    }
}
