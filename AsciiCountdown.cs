using System;
using System.Threading;

namespace ConsoleGameTools
{
    public class AsciiCountdown
    {
        public bool Cancelled { get; private set; }

        public void Start(int seconds)
        {
            Cancelled = false;

            if (seconds <= 0)
                return;

            Console.CursorVisible = false;

            for (int i = seconds; i >= 0; i--)
            {
                if (Console.KeyAvailable &&
                    Console.ReadKey(true).Key == ConsoleKey.Q)
                {
                    Cancelled = true;
                    break;
                }

                RenderBar(i, seconds);
                Thread.Sleep(1000);
            }

            Console.WriteLine();
            Console.CursorVisible = true;
        }

        private void RenderBar(int current, int total)
        {
            int width = 20;

            float progress = current / (float)total;
            int filled = (int)(progress * width);
            int empty = width - filled;

            string bar =
                "" +
                new string('█', filled) +
                new string('░', empty) +
                $" {current}s (Q to cancel)";

            Console.Write($"\r{bar.PadRight(60)}");
        }
    }
}