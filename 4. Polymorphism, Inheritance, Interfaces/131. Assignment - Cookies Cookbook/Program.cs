using _131._Assignment___Cookies_Cookbook.Ingredient;

// APP started:
// Code to check if any reipe already exists or not.

// If yes Print them all.

// Give user all the ingredients. Till he want to quit.
CreateRecipe createRecipe = new CreateRecipe();

do
{
    // Print all ingredients and take user input:
    Console.WriteLine("Enter exit to stop adding the ingredients: ");
    CreateRecipe.PrintAllIngredients();
    string userSelectedIngredients = CreateRecipe.ReadValidateUserInput();

    // Check if user wants to quit the app:
    if (userSelectedIngredients.Equals("exit"))
    {
        break;
    }

    // Validate user's input.
    int ingredientId = CreateRecipe.ValidateUserInput(userSelectedIngredients);

    // If wrong number then execute the loop agian:
    if (ingredientId < 1 || ingredientId > Ingredient.IngredientsSize())
    {
        Console.WriteLine("Please enter the right number: ");
        continue;
    }

} while (true);

class Recipe
{
    private int _re
}

class CreateRecipe
{
    public static void PrintAllIngredients()
    {
        Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
        Ingredient.PrintIngredients();
    }
    public static string ReadValidateUserInput()
    {
        string? selectedIngredient = Console.ReadLine();
        return selectedIngredient!;
    }
    public static int ValidateUserInput(string selectedIngredient)
    {
        try
        {
            if (string.IsNullOrEmpty(selectedIngredient))
            {
                throw new NullReferenceException("Empty input given. Please select the number.");
            }
            return Int32.Parse(selectedIngredient);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidCastException ex)
        {
            Console.WriteLine("Please give the integer input in 1 and 8. " + ex.Message);
        }
        return 0;
    }
}
