using System;

namespace PigDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int totalScore = 0;
            int turn = 1;

            Console.WriteLine("PIG DICE GAME");

            while (totalScore < 20)
            {
                int turnScore = 0;
                Console.WriteLine($"TURN {turn}");

                while (true)
                {
                    Console.WriteLine("Roll or hold?(r/h) : ");
                    string choice = (Console.ReadLine() ?? "h").ToLower();



                    if (choice == "r")
                    {
                        int dice = random.Next(1, 7);
                        Console.WriteLine($"Die: {dice}");

                        if (dice == 1)
                        {
                            Console.WriteLine("No Score. \n");
                            turnScore = 0;
                            break;

                        }
                        else
                        {
                            turnScore += dice;
                        }

                    }
                    else if (choice == "h")
                    {
                        totalScore += turnScore;
                        Console.WriteLine($"Score for turn : {turnScore}");
                        Console.WriteLine($"Total score : {totalScore}");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Enter 'r' to roll and 'h' to hold");
                    }
                }
                turn++;
            }
            Console.WriteLine($"You reached 20 in {turn - 1} turns");
        }
    }
}
