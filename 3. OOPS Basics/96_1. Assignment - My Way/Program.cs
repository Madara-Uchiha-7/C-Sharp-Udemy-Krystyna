/*
1. When the application starts, it shall generate a number from 1 to 6 and then print:

2. Dice rolled. Guess what number it shows in 3 tries.

3. If the number equals the generated number, “You win” is printed to the console.

4. If not, “Wrong number” is printed, and the user has another chance

5. The user has 3 chances. If they all are unsuccessful, “You lose” is printed to the console, 
   and the program closes after any key is pressed.

6. User does not enter any valid number (for example, enters “abc”).

7. “Incorrect input” is printed to the console. “Enter number:” is printed to the console. No chance is being used.


------------------------------
Now lets see what I need all for this:
***********
1. I need to create the random number. 
2. I need to show that random number to user.

I can use RandomNumberGenerator class for this.
and can add 2 method in it called
Generate() and show() in this class.

This can become a stateless class because user will not be updating the random generated number by system.

***********
1. I need to get the user input.
2. I need to check that input.

This can be done in GuessTheNumber Class or DiceRoll Class.
Lets try...


*/

Game.Run();

class Game
{
    public static void Run()
    {
        RandomNumber randomNumber = new RandomNumber();
        randomNumber.Generate(DiceRoll.Sides);

        DiceRoll diceRoll = new DiceRoll();
        DiceRoll.PrintStartUpMessage(diceRoll.TotalChances);

        while (true)
        {
            string userInput = User.GetInput();

            if (!DiceRoll.ValidateUserInput(userInput))
            {
                DiceRoll.PrintError();
            }

            int guessedNumber = DiceRoll.GetUserInputInInteger(userInput);

            if (DiceRoll.DidUserWin(guessedNumber, randomNumber.Number))
            {
                DiceRoll.PrintSuccess();
                break;
            }
            else
            {
                diceRoll.TotalChances -= 1;
                int totalChances = diceRoll.TotalChances;

                if (totalChances == 0)
                {
                    DiceRoll.PrintLoseGame();
                    break;
                }
                else
                {
                    DiceRoll.PrintTryAgain();
                }
            }
        }
    }
}


class RandomNumber
{
    Random random = new Random();

    public int TotalTry {  get; }
    public int Number { get; private set; }

    public RandomNumber()
    {
        TotalTry++;
    }
    public void Generate(int range)
    {
        Number = random.Next(range + 1);
    }
}

class DiceRoll
{
    public const int Sides = 6;
    public int TotalChances { get; set; } = 3;

    public static void PrintStartUpMessage(int chances)
    {
        Console.WriteLine($"Dice rolled. Guess what number it shows in {chances} tries.");
        Console.WriteLine("Enter the number: ");
    }

    public static bool ValidateUserInput(string input)
    {

        if (string.IsNullOrEmpty(input))
        {
            return false;
        }

        // _ :  means if you don't need the number you can discard the out parameter
        bool isNumber = int.TryParse(input, out _);
        if (!isNumber)
        {
            return false;
        }

        return true;
    }
    public static void PrintError()
    {
        Console.WriteLine("Incorrect input");
        Console.WriteLine("Enter number:");
    }

    public static int GetUserInputInInteger(string number)
    {
        return int.Parse(number);
    }
    public static bool DidUserWin(int gussedNumber, int winNumber)
    {
        if (winNumber == gussedNumber)
        {
            return true;
        }
        return false;
    }
    public static void PrintSuccess()
    {
        Console.WriteLine("You win");
    }
    public static void PrintLoseGame()
    {
        Console.WriteLine("Wrong number");
        Console.WriteLine("You lose");
    }
    public static void PrintTryAgain()
    {
        Console.WriteLine();
        Console.WriteLine("Wrong number");
        Console.WriteLine("Enter number:");
    }
}

class User
{   
    public static string GetInput()
    {
        return Console.ReadLine()!;
    }
}