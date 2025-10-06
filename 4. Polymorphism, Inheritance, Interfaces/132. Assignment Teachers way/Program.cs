using _132._Assignment_Teachers_way.IRecipesUserInteraction;

// Check 131. Teachers way code and comments then start here:
// We will learn about yet another SOLID principle: the Dependency Inversion Principle.
// We will also learn the dependency injection design pattern and make sure we understand the difference
// between those two.
// We will see what coupling is and additionally, how to shorten our code with target-typed new expressions.

var cookiesRecipesApp = new CookiesRecipesApp();
cookiesRecipesApp.Run();


public class CookiesRecipesApp
{
    // Why are we not creating the object of RecipesRepository and RecipesUserInteraction
    // below like instead of initializing them using CookiesRecipesApp constructor.: 
    // private readonly RecipesRepository _recipesRepository = new(); 
    // (Only using new() :  This feature is called target-typed new expressions and it has been available since C# 9.)
    // or
    // private readonly RecipesRepository _recipesRepository = new RecipesRepository(); 
    // Well, it's all about the flexibility of the code.
    // To understand it better, let's consider the following scenario.
    // We develop this app and it works great.
    // The CookiesRecipesApp uses those two classes as dependencies, so each class seems to have only one
    // responsibility, which is good.
    // Everything looks splendid, until one day we are told that this app will have to be adapted to use not
    // the console interface but a graphical user interface.
    // Well, this raises some problems.
    // The CookiesRecipesApp not only uses the RecipeConsoleUserInteraction, but it even creates it right
    // here(private readonly RecipesRepository _recipesRepository = new(); ).
    // To make the CookiesRecipesApp class communicate with the user through some graphical user interface
    // we will have to modify it.
    // First, we would need to change this line to create some RecipesGraphicalUserInteraction object.
    // We would also have to adjust all other places where we use this class because the new class can have
    // methods with different signatures.
    // This means two things.
    // Firstly, this class still breaks the SRP because it has more than one reason to change.
    // The first reason is if the workflow of the application will change and the other if the way of communicating
    // with the user will change.
    // Secondly, the CookiesRecipeApp and the RecipeConsoleUserInteraction are tightly coupled now.
    // Coupling is the degree of interdependence between classes.
    // A measure of how closely they are connected.
    // Coupling is an undesirable trait and it should be avoided.
    // Coupling of classes makes them less reusable because we can't use one class without involving the other.
    // It also makes the code more brittle as changing one class may make the other class stop.
    // Compiling all those things mean that this design breaks the Dependency Inversion Principle, which is
    // the D in the SOLID acronym.
    // The Dependency Inversion Principle states that high-level modules should not depend on low-level modules.
    // Both should depend on abstractions.
    // In other words, the dependencies of a type should not be concrete.
    // They should be abstractions, which in C# usually means interfaces.
    // Let's make this class depend on an abstraction, not on a concrete type.
    // We will chagnge RecipesUserInteraction to : IRecipesUserInteraction
    // This interface will expose a set of methods that we need to communicate with the user.
    // As you can see, the interface does not say anything about the console.
    // It only declares what methods are needed to communicate with a user.
    // RecipesUserInteraction class will of course implement this interface.
    // We obviously cannot create an instance of this interface.
    // We could assign a new object of the RecipesConsoleUserInteraction class here like this.
    // private readonly IRecipesUserInteraction _recipesUserInteraction = new RecipesUserInteraction();
    // I.e. use of GeneralType.
    // But it wouldn't solve the problems we had before.
    // If we needed to change the console interface to a graphical interface, we would still need to modify
    // new RecipesUserInteraction();
    // Also Also, RecipesUserInteraction and CookiesRecipesApp types are still tightly coupled.
    // For example, if the signature of the constructor of the RecipesConsoleUserInteraction class changes,
    // new RecipesUserInteraction(); line will no longer compile.
    // So if we can't create this dependency here, what should we do?
    // Well, we should inject it into this class.
    // So simply pass it via the constructor.
    // This practice is called the dependency injection.
    // So in our constructor we are using IRecipesUserInteraction as the parameter.
    // Don't confuse dependency inversion with dependency injection.
    // Dependency inversion is a principle saying that a type should depend on abstractions, not on concrete
    // 
    private readonly RecipesRepository _recipesRepository;
    private readonly IRecipesUserInteraction _recipesUserInteraction;

    public CookiesRecipesApp(RecipesRepository recipesRepository, IRecipesUserInteraction recipesUserInteraction)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesUserInteraction;
    }

    public void Run()
    {

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
