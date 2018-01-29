using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farrr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(38, 38);
            FAR far = new FAR(@"D:\Call of Duty - Modern Warfare 2");

            bool quit = false;

            while (!quit)
            {
                far.Draw();
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.Escape:
                        quit = true;
                        break;
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.Backspace:
                    case ConsoleKey.Enter:
                        far.Process(pressedKey);
                        break;
                    default:
                        break;
                }
            }
        }
    }
    
}
