

using DiceRollGame.UserCommunication;

namespace DiceRollGame.Game;
public class GuessingGame
{
    private readonly Dice _dice;
    private const int InitialTies = 3;

    public GuessingGame(Dice dice)
    {
        _dice = dice;
    }
    public GameResult Play()
    {
        var diceRollResult = _dice.Roll();
        Console.WriteLine($"Dice Rolled. Guess what number it shows in {InitialTies} tries.");

        var triesLeft = InitialTies;
        while (triesLeft > 0)
        {
            var guess = ConsoleReader.ReadInteger("Enter a number: ");
            if (guess == diceRollResult)
            {
                return GameResult.Victory;
            }
            Console.WriteLine("Wrong Number.");
            --triesLeft;
        }
        return GameResult.Loss;
    }

    public static void PrintResult(GameResult gameResult)
    {
        // Sytax for Ternary conditional operator: 
        // condition
        // ? If true run this statement/expression
        // : If false run this statement/expression
        // Ternary because it has ==, ?, :

        string message =
            gameResult == GameResult.Victory
            ? message = "You Win!"
            : message = "You lose";

        Console.WriteLine(message);
    }
}
