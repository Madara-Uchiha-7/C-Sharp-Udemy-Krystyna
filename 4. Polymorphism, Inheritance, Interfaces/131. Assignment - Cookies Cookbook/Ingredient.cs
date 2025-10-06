namespace _131._Assignment___Cookies_Cookbook.Ingredient;

internal class Ingredient
{
    private int ID { get; }
    private string? Name { get; }

    private string? Method { get; }

    private static List<Ingredient> _ingredients = new List<Ingredient>()
    {
        new Ingredient(1, "Wheat flour", "Sieve. Add to other ingredients."),
        new Ingredient(2, "Coconut flour Sieve.", "Add to other ingredients."),
        new Ingredient(3, "Butter Melt on low heat.", "Add to other ingredients."),
        new Ingredient(4, "Chocolate Melt in a water bath.", "Add to other ingredients."),
        new Ingredient(5, "Sugar", "Add to other ingredients."),
        new Ingredient(6, "Cardamom", "Take half a teaspoon. Add to other ingredients."),
        new Ingredient(7, "Cinnamon", "Take half a teaspoon. Add to other ingredients."),
        new Ingredient(8, "Cocoa powder", "Add to other ingredients.")
    };

    public Ingredient(int id, string name, string method)
    {
        ID = id;
        Name = name;
        Method = method;
    }

    public static void PrintIngredients()
    {
        foreach (var ingredient in _ingredients)
        {
            Console.WriteLine($"{ingredient.ID}. {ingredient.Name} : {ingredient.Method}");
        }
    }
    public static int IngredientsSize()
    {
        return _ingredients.Count();
    }
}

