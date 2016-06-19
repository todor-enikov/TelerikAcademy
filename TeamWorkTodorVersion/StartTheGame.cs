using System;
using System.Collections.Generic;
using System.Threading;

namespace TeamWorkTodorVersion
{
    public class Game
    {     
        static Random rand = new Random();
        static int playGroundWidth = 30;
        static List<Letters> letters;
        public static long scores;
        
        static void Main()
        {
            InitialisationOfTheGame.Initialisation();
            letters = new List<Letters>();
            int livesCount = 3;
            Player player = Player.GetInstance();
            List<Letters> removeObsoletes;
            bool hit = false;
            ConsoleKeyInfo pressedKey;
            while (true)
            {
                // adding new letters
                for (int i = 0, count = rand.Next(playGroundWidth / (scores > 100 ? 7 : 10)); i < count; i++)
                {
                    letters.Add(new Letters());
                }
                // moving our player
                while (Console.KeyAvailable)
                {
                    pressedKey = Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.LeftArrow || pressedKey.Key == ConsoleKey.A) // <--
                    {
                        player.MoveLeft();
                    }
                    if (pressedKey.Key == ConsoleKey.RightArrow || pressedKey.Key == ConsoleKey.D) // -->
                    {
                        player.MoveRight();
                    }
                    if (pressedKey.Key == ConsoleKey.Escape) // Esc
                    {
                        Environment.Exit(0); // leave game
                    }
                }
                removeObsoletes = new List<Letters>(); // letters, which are to leave the screen
                hit = false;
                foreach (Letters rock in letters)
                {
                    if (!rock.MoveDown())
                    {
                        removeObsoletes.Add(rock);
                    }
                    if (player.Overlap(rock)) // if hit
                    {
                        livesCount--;
                        hit = true;
                        Console.Beep();
                        if (livesCount == 0) // game over
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Out.WriteLine("GAME OVER !!!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Environment.Exit(0);
                        }
                    }
                }
                Console.Clear();
                foreach (Letters old in removeObsoletes) // removing letters, which are to leave the screen
                {
                    letters.Remove(old);
                    scores++;
                }
                if (hit)
                {
                    letters.Clear();
                    scores -= 10;
                }
                // printing
                foreach (Letters rock in letters)
                {
                    rock.Print();
                }
                player.Print(hit);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(playGroundWidth + 5, 5);
                Console.Out.WriteLine("Lives: {0}", livesCount);
                Console.SetCursorPosition(playGroundWidth + 5, 7);
                Console.Out.WriteLine("Scores: {0}", scores);
                InitialisationOfTheGame.Sleep();
            }
        }
    }
}