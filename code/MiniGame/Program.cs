public enum Things
{
    Rock,
    Paper,
    Scissors
}

public class Program
{
    // Добавляем цикл для повторной игры
    public static void PlayGame()
    {
        while (true)
        {
            Console.WriteLine("Choose your move: Rock, Paper, or Scissors");

            string userInput = Console.ReadLine();
            Things userChoice;

            if (Enum.TryParse(userInput, true, out userChoice))
            {
                Random random = new Random();
                Things computerChoice = (Things)random.Next(0, 3);

                Console.WriteLine($"You chose: {userChoice}");
                Console.WriteLine($"Computer chose: {computerChoice}");

                DetermineWinner(userChoice, computerChoice);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose Rock, Paper, or Scissors.");
            }

            Console.WriteLine("Play again? (y/n)");
            string playAgain = Console.ReadLine();
            if (!playAgain.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }
        }
    }

    public static void Main(string[] args)
    {
        PlayGame();
    }

    private static void DetermineWinner(Things userChoice, Things computerChoice)
    {
        if (userChoice == computerChoice)
        {
            Console.WriteLine("It's a tie!");
        }
        else if ((userChoice == Things.Rock && computerChoice == Things.Scissors) ||
                 (userChoice == Things.Paper && computerChoice == Things.Rock) ||
                 (userChoice == Things.Scissors && computerChoice == Things.Paper))
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("You lose!");
        }
    }
}