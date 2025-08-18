// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// Since some folder names are very long, I am facing the issue to run some projects.
// I will run those codes here.

Ingredient ingredient = new Chedder();

Console.WriteLine(ingredient.Name);

List<Ingredient> ingredients = new List<Ingredient>
{
    new Chedder(), // Same as Ingredient ingredient = new Chedder();  -- ingredients[0]
    new Mozzarella(), // Same as Ingredient ingredient = new TomatoSauce();  -- ingredients[1]
    new TomatoSauce() // Same as Ingredient ingredient = new Mozzarella();  -- ingredients[2]
}; 

foreach (Ingredient ingredient1 in ingredients)
{
    Console.WriteLine(ingredient1.Name);
}
Console.ReadKey();
public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient) =>
        _ingredients.Add(ingredient);

    public string Describe() => $"This is a pizza with " +
        $"{string.Join(", ", _ingredients)}";
}

public class Ingredient
{
    // Look how we are setting the value to the Property name and using only getter.
    // We also added the keyword virtual
    public virtual string Name { get; } = "Some Ingredient";
    public string publicMethod() =>
        "This method is public in the Ingredient class.";

    public int PublicField;
}

public class Chedder : Ingredient
{
    public override string Name => "Cheddar cheese";
    public int AgedForMonths { get; }

    public void useMethodFromBaseClass()
    {
        Console.WriteLine(publicMethod());
    }
}

public class TomatoSauce : Ingredient
{
    public override string Name => "Tomato Sauce";
    public int TomatoIn100Grams { get; }
}

public class Mozzarella : Ingredient
{
    public override string Name => "Mozarella";
    public bool IsLight { get; }
}
