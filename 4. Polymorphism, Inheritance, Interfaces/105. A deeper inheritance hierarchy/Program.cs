// In old code we had a child classes called Chedder, TomatoSauce and Mozzarella
// which were inheriting Ingredient. 
// Lets say there is one more class called Cheese which is also an Ingredient 
// But Chedder and Mozzarella are also the part of the cheese. So,
// We can make Chedder and Mozzarella, child of Cheese and the Cheese class will be the child of the 
// Ingredient. The code will still work and will compile.

Pizza pizza = new Pizza();
pizza.AddIngredient(new Chedder());
pizza.AddIngredient(new Mozzarella());
pizza.AddIngredient(new TomatoSauce());


Console.WriteLine(pizza.Describe());

Console.ReadKey();
public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    // With this new structor we can change below method declaration to
    // public void AddIngredient(Cheese ingredient) =>
    // The the line 11 will fail because the TomatoSauce does not inherit the 
    // Cheese. Ingredient is general class for TomatoSauce but Cheese is not.
    public void AddIngredient(Ingredient ingredient) =>
        _ingredients.Add(ingredient);

    public string Describe() => $"This is a pizza with " +
        $"{string.Join(", ", _ingredients)}";
}

public class Ingredient
{

}

public class Cheese : Ingredient
{

}

public class Chedder : Cheese
{
    public string Name => "Cheddar cheese";
    public int AgedForMonths { get; }
}

public class TomatoSauce : Cheese
{
    public string Name => "Tomato Sauce";
    public int TomatoIn100Grams { get; }
}

public class Mozzarella : Ingredient
{
    public string Name => "Mozarella";
    public bool IsLight { get; }
}