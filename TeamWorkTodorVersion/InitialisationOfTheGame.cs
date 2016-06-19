using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TeamWorkTodorVersion
{
    public static class InitialisationOfTheGame
    {
        
        public static void Initialisation()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorVisible = false;
            Console.Title = "Falling Rocks";
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth = 50;
            Game.scores = 0;        
        }

        public static void Sleep()
        {
            Thread.Sleep(150);
        }
    }
}
