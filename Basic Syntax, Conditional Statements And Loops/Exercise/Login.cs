using System;
using System.Linq;
using System.Text;

namespace Login
{
    class Login
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            StringBuilder pass = new StringBuilder();
            int counter = 1;
            bool block = false;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                pass.Append(username[i]);
            }
            string password = pass.ToString();
            string tryPass = Console.ReadLine();
            while (tryPass != password)
            {
                Console.WriteLine("Incorrect password. Try again.");
                tryPass = Console.ReadLine();
                counter++;
                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    block = true;
                    break;
                }
            }
            if (block == false)
                Console.WriteLine($"User {username} logged in.");
        }
    }
}
