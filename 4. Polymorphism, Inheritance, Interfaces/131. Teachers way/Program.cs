// We will write below 2 lines at the start
// Start writing your code using classes and methods that do not yet exist.
// Teacher really recommend this approach.
// It allows us to write how we want to use classes first and only then worry about the implementation
// details.  Designing a good interface for a class is much harder, but also much more important than making all
// the implementation details right.
// And by the interface, I mean the signatures of public methods and properties, not necessarily the
// interface type from C#.
// The implementation details are something we can always change later,
// and if a class is designed well, it should not affect other parts of the program.
// On the other hand, if we change the signature of a public method, we may have hundreds of places where
// the code needs to be adjusted to match it.
// Moreover, a well-designed public interface makes the type simpler to use, and the code that relies on
// it easier to understand.
var cookiesRecipesApp = new CookiesRecipesApp();
cookiesRecipesApp.Run();

// Let now create the above class
// This class will define the main logic of this program.
public class cookiesRecipesApp
{

    private readonly RecipesRepository _recipesRepository;
    private readonly RecipesUserInteraction _recipesUserInteraction;

    public cookiesRecipesApp(RecipesRepository recipesRepository, RecipesUserInteraction recipesUserInteraction)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesUserInteraction;
    }

    public void Run()
    {
        // Steps:
        // We must load all recipes from the text file, assuming it already exists, and print them to the console.

        // Then we must prompt the user to create a new recipe which involves printing all the ingredients.

        // Then the user must select the ingredients they want to be included in the recipe.

        // The next step depends on whether the user selected an ingredients or not.
        // If not, we print a simple message to the console, and if so, we show the recipe on the screen and
        // save it to the text file.

        // Finally, we exit the application.

        // The CookiesRecipesApp should not actually implement any of those steps.
        // Remember the single responsibility principle?
        // The responsibility of this class is to manage the workflow of this application.
        // If we implement things like reading from and writing to a text file, we would add the second responsibility
        // to this class.
        // The only reason to change this class should have is if the main workflow defined in the requirements
        // would change.
        // This means that even using Console.WriteLineor Console.ReadLinehere would be breaking the SRP because
        // it would mean this class has another reason to change.
        // For example, one day it could need to be adapted to use not a console interface but a graphical interface
        // with buttons, text fields, etcetera.
        // In this case, we would need to modify this class significantly because the way of the communicating
        // with the user has changed.
        // So it would have not one but two reasons to change and thus would be breaking the SRP.
        // The fact that this class will not implement those steps means it will depend on some other classes that do.
        // Looking at those steps, we see they fall into two categories.
        // Those two steps are related to reading and writing recipes to a file.
        // We would imagine a class called RecipesRepository would be responsible for that.
        // The rest of them is the interaction with the user.
        // Lets name that class : RecipesUserInteraction
        // Since those two types will be dependencies of this class, they should be declared here as private
        // readonly fields and initialized from the constructor.
        // Check property : _recipesRepository and _recipesUserInteraction and constructor for them
        // We declared these property and constructor before creating the these classes.
        // It will help us to come up with a good interface.

        // Step one : Read all the recipes:
        // I imagine we'll need to pass the path to the file as a parameter.
        var allRecipes = _recipesRepository.Read(filePath);

        // Step two: Printing the existing recipes.
        // Showing things on screen is a way of interacting with the user.
        // So we will ask the _recipesUserInteraction type to do it.
        _recipesUserInteraction.PrintExistingRecipes(allRecipes);

        // Step three: prompting the user to create a recipe.
        _recipesUserInteraction.PromptToCreateRecipe();

        // Step four: Reading the ingredients from the user.
        var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

        // Now let's check if the user selected any ingredients.
        if (ingredients.Count < 0)
        {
            var recipe = new Recipe(ingredients);
            allRecipes.Add(recipe);
            _recipesRepository.Write(filePath, allRecipes);
            _recipesUserInteraction.ShowMessage("Recipe Added: ");
            _recipesUserInteraction.ShowMessage(recipe.ToString());
        }
        else
        {
            _recipesUserInteraction.ShowMessage("No ingredients are selected. Recipe will not be saved.");
        }
        _recipesUserInteraction.Exit();
    }
}
// All the step 1 to step 4
// are written before creating any other class or interface.
// So,  Even if someone did not read the requirements, but they read this code, they
// can have a high-level idea of what this application is doing.