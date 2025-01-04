// We can solve problem in 100 using Inheritence
// Inheritence allows us to create new classes that reuse,
// extend, and modify the behaviour defined in other classes.
// The class whose members are inherited is called base class.
// The class the inherits those members is called the derived class.
// We will create the ingredient base class and all the specific
// ingredient will derive from it.


Pizza pizza = new Pizza();
pizza.AddIngredient(new Chedder());
pizza.AddIngredient(new Mozzarella());
pizza.AddIngredient(new TomatoSauce());
// This will print the name of the objects
// like Chedder, Mozzarella, ...
// Because our _ingredients holds the objs
Console.WriteLine(pizza.Describe());

Console.ReadKey();
public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();
    // This list is a very essence of Polymorphism
    // This above list stores the objects of the diff types
    // using the common interface to manipulate them
    
    public void AddIngredient(Ingredient ingredient) =>
        _ingredients.Add(ingredient);

    public string Describe() => $"This is a pizza with " +
        $"{string.Join(", ", _ingredients)}";
}

public class Ingredient
{

}

public class Chedder : Ingredient
{
    public string Name => "Cheddar cheese";
    public int AgedForMonths { get; }
}

public class TomatoSauce : Ingredient
{
    public string Name => "Tomato Sauce";
    public int TomatoIn100Grams { get; }
}

public class Mozzarella : Ingredient
{
    public string Name => "Mozarella";
    public bool IsLight { get; }
}

// This above code shows that inheritance is is-a kind of relationship
// TomatoSauce is a Ingredient
// Mozzarella is a Ingredient
// Chedder is a Ingredient
