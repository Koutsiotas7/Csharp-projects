using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(String[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player, computer, answer;

            while (playAgain)
            {
                player = "";
                computer = "";

                while (player != "ROCK" && player != "PAPER" & player != "SCISSORS")
                {
                    Console.WriteLine("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();

                }

                int randomNum = random.Next(1, 4);
                switch (randomNum)
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw.");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("YOU LOSE!!!");
                        }
                        else
                        {
                            Console.WriteLine("YOU WIN!!!!!!!!!!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("YOU WIN!!!!!!!!!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw.");
                        }
                        else
                        {
                            Console.WriteLine("YOU LOSE!!!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("YOU LOSE!!!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("YOU WIN!!!!!!!!!!");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw.");
                        }
                        break;
                }

                answer = "";
                do
                {
                    Console.WriteLine("Would you like to play again? (Y/N):");
                    answer = Console.ReadLine().Trim().ToUpper();

                    if (answer != "Y" && answer != "N")
                    {
                        Console.WriteLine("Invalid input. Please enter 'Y' or 'N'.");
                    }

                } while (answer != "Y" && answer != "N");

                if (answer == "Y")
                {
                playAgain = true;
                }
                else
                {
                playAgain = false;
                }

            }
            Console.WriteLine("Thanks for playing.");
        }
    }
}