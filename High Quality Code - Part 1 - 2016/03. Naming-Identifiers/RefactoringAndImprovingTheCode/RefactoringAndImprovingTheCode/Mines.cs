namespace MineSweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using RefactoringAndImprovingTheCode;

    public class Mines
    {
        public static void Main()
        {
            string command = string.Empty;
            char[,] initialField = CreatingInitialFieldWithQuestionMarks();
            char[,] finalField = FillingRandomPlayingField();
            int counterOfScore = 0;
            bool hitByMine = false;
            List<PlayerInformation> highscores = new List<PlayerInformation>(6);
            int row = 0;
            int column = 0;
            bool flagForInitializeOfTheGame = true;
            bool flagForEndOfTheGameWhenMazimumScoreIsAchieved = false;
            const int MaximumFieldOpenCells = 35;

            do
            {
                if (flagForInitializeOfTheGame)
                {
                    Console.WriteLine("Let's play “MineSweeper”. Try to find all of the mines in the given field.\n" +
                    " Command 'top' shows highscore of all players,\n         'restart' begins new game,\n         'exit' is exiting from the game !");
                    PrintingBordersOfTheField(initialField);
                    flagForInitializeOfTheGame = false;
                }

                Console.Write("Please enter row and column : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out column) &&
                        row <= initialField.GetLength(0) && column <= initialField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PrintingHighscores(highscores);
                        break;
                    case "restart":
                        initialField = CreatingInitialFieldWithQuestionMarks();
                        finalField = FillingRandomPlayingField();
                        PrintingBordersOfTheField(initialField);
                        hitByMine = false;
                        flagForInitializeOfTheGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye, bye!");
                        break;
                    case "turn":
                        if (finalField[row, column] != '*')
                        {
                            if (finalField[row, column] == '-')
                            {
                                FillNumberInFieldCell(initialField, finalField, row, column);
                                counterOfScore++;
                            }

                            if (MaximumFieldOpenCells == counterOfScore)
                            {
                                flagForEndOfTheGameWhenMazimumScoreIsAchieved = true;
                            }
                            else
                            {
                                PrintingBordersOfTheField(initialField);
                            }
                        }
                        else
                        {
                            hitByMine = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalid command!\n");
                        break;
                }

                if (hitByMine)
                {
                    PrintingBordersOfTheField(finalField);
                    Console.Write("\nGame over!!! Your score is: {0}. " + "Please enter username: ", counterOfScore);
                    string username = Console.ReadLine();
                    PlayerInformation informationForCurrentPlayer = new PlayerInformation(username, counterOfScore);
                    if (highscores.Count < 5)
                    {
                        highscores.Add(informationForCurrentPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < highscores.Count; i++)
                        {
                            if (highscores[i].CollectedPoints < informationForCurrentPlayer.CollectedPoints)
                            {
                                highscores.Insert(i, informationForCurrentPlayer);
                                highscores.RemoveAt(highscores.Count - 1);
                                break;
                            }
                        }
                    }

                    highscores.Sort((PlayerInformation r1, PlayerInformation r2) => r2.Name.CompareTo(r1.Name));
                    highscores.Sort((PlayerInformation r1, PlayerInformation r2) => r2.CollectedPoints.CompareTo(r1.CollectedPoints));
                    PrintingHighscores(highscores);

                    initialField = CreatingInitialFieldWithQuestionMarks();
                    finalField = FillingRandomPlayingField();
                    counterOfScore = 0;
                    hitByMine = false;
                    flagForInitializeOfTheGame = true;
                }

                if (flagForEndOfTheGameWhenMazimumScoreIsAchieved)
                {
                    Console.WriteLine("\nWell done!!! You beat all of the mines!!!");
                    PrintingBordersOfTheField(finalField);
                    Console.WriteLine("Please enter your username: ");
                    string winnerUsername = Console.ReadLine();
                    PlayerInformation informationForCurrentWinnerPlayer = new PlayerInformation(winnerUsername, counterOfScore);
                    highscores.Add(informationForCurrentWinnerPlayer);
                    PrintingHighscores(highscores);
                    initialField = CreatingInitialFieldWithQuestionMarks();
                    finalField = FillingRandomPlayingField();
                    counterOfScore = 0;
                    flagForEndOfTheGameWhenMazimumScoreIsAchieved = false;
                    flagForInitializeOfTheGame = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria!");
        }

        private static void PrintingHighscores(List<PlayerInformation> player)
        {
            Console.WriteLine("\nList of highscores:");
            if (player.Count > 0)
            {
                for (int i = 0; i < player.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, player[i].Name, player[i].CollectedPoints);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The highscore list is empty!\n");
            }
        }

        private static void FillNumberInFieldCell(char[,] initialField, char[,] finalField, int row, int column)
        {
            char countOfMinesAroundTheNumber = CountOfMinesAroundTheNumberInTheField(finalField, row, column);
            finalField[row, column] = countOfMinesAroundTheNumber;
            initialField[row, column] = countOfMinesAroundTheNumber;
        }

        private static void PrintingBordersOfTheField(char[,] field)
        {
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0} ", field[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatingInitialFieldWithQuestionMarks()
        {
            int rows = 5;
            int columns = 10;
            char[,] field = new char[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    field[i, j] = '?';
                }
            }

            return field;
        }

        private static char[,] FillingRandomPlayingField()
        {
            int rows = 5;
            int columns = 10;
            char[,] playingField = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    playingField[i, j] = '-';
                }
            }

            List<int> numbers = new List<int>();
            while (numbers.Count < 15)
            {
                Random random = new Random();
                int randomNumberToAdd = random.Next(50);
                if (!numbers.Contains(randomNumberToAdd))
                {
                    numbers.Add(randomNumberToAdd);
                }
            }

            foreach (int number in numbers)
            {
                int column = number / columns;
                int row = number % columns;
                if (row == 0 && number != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                playingField[column, row - 1] = '*';
            }

            return playingField;
        }

        private static void FillingNumberInTheField(char[,] field)
        {
            int columns = field.GetLength(0);
            int rows = field.GetLength(1);

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char numberInCurrentField = CountOfMinesAroundTheNumberInTheField(field, i, j);
                        field[i, j] = numberInCurrentField;
                    }
                }
            }
        }

        private static char CountOfMinesAroundTheNumberInTheField(char[,] matrix, int i, int j)
        {
            int count = 0;
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            if (i - 1 >= 0)
            {
                if (matrix[i - 1, j] == '*')
                {
                    count++;
                }
            }

            if (i + 1 < rows)
            {
                if (matrix[i + 1, j] == '*')
                {
                    count++;
                }
            }

            if (j - 1 >= 0)
            {
                if (matrix[i, j - 1] == '*')
                {
                    count++;
                }
            }

            if (j + 1 < columns)
            {
                if (matrix[i, j + 1] == '*')
                {
                    count++;
                }
            }

            if ((i - 1 >= 0) && (j - 1 >= 0))
            {
                if (matrix[i - 1, j - 1] == '*')
                {
                    count++;
                }
            }

            if ((i - 1 >= 0) && (j + 1 < columns))
            {
                if (matrix[i - 1, j + 1] == '*')
                {
                    count++;
                }
            }

            if ((i + 1 < rows) && (j - 1 >= 0))
            {
                if (matrix[i + 1, j - 1] == '*')
                {
                    count++;
                }
            }

            if ((i + 1 < rows) && (j + 1 < columns))
            {
                if (matrix[i + 1, j + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}