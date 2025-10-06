// Check 131. Teachers way code and comments then start here:

using _132._Assignment_Teachers_way.IRecipesUserInteraction;
internal class RecipesUserInteraction : IRecipesUserInteraction
{
    public void Exit()
    {
        Console.WriteLine("Press any key to exit: ");
        Console.ReadKey();
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}