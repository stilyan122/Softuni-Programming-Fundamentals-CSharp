using System;

namespace RageExpenses
{
    class RageExpenses
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headSet = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int headLost = 0;
            int mouseLost = 0;
            int keyboardLost = 0;
            int displayLost = 0;
            int counterForLostKeyboard = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                bool lostHead = false;
                bool lostMouse = false;
                if (i%2==0)
                {
                    headLost++;
                    lostHead = true;
                }
                if (i%3==0)
                {
                    mouseLost++;
                    lostMouse = true;
                }
                if (lostHead && lostMouse)
                {
                    keyboardLost++;
                    counterForLostKeyboard++;
                }
                if (counterForLostKeyboard%2==0&&counterForLostKeyboard!=0)
                {
                    displayLost++;
                    counterForLostKeyboard = 0;
                }
            }

            double total = headSet * headLost + keyboardLost * keyboardPrice + mousePrice * mouseLost + displayLost * displayPrice;
            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
