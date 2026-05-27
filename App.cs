using System;
using CountdownTwo;

namespace ConsoleGameTools
{
    public class App
    {
        public void Run()
        {
            var countdown = new AsciiCountdown();

            Console.WriteLine("Press any key to start countdown...");
            Console.ReadKey(true);

            countdown.Start(10);

            if (countdown.Cancelled)
            {
                Console.WriteLine("Countdown cancelled.");
            }
            else
            {
                Console.WriteLine("Countdown finished.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}