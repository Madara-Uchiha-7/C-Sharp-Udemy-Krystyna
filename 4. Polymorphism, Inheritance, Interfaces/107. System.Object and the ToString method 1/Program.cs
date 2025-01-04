using System.Xml.Linq;

Pizza pizza = new Pizza();
pizza.AddIngredient(new Chedder());
pizza.AddIngredient(new Mozzarella());
pizza.AddIngredient(new TomatoSauce());
Console.WriteLine(pizza.Describe());
Console.WriteLine(pizza);
Console.ReadKey();
public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();
    public void AddIngredient(Ingredient ingredient) =>
        _ingredients.Add(ingredient);

    // The _ingredients was priting the object name when we called Describe(),
    // instead of name of the ingredients.
    // This should no longer be a case because when ingredient objects are joined into a single string
    // using Join(), the ToString() method called under the hood on each of them and result is
    // appended to the final string.
    // We have changed the implementation of ToString() for ingredients, so it should be different.
    public string Describe() => $"This is a pizza with " +
        $"{string.Join(", ", _ingredients)}";


    // Look at below code.
    // Programmers prefer this, i.e. use of ToString() instead of Describe()
    // Now simply using the pizza object in the Console.WriteLine() will do the work. 
    public override string ToString() => $"This is a pizza with " +
        $"{string.Join(", ", _ingredients)}";
}

public class Ingredient
{
   public virtual string Name { get; } = "Some ingredient";
   public override string ToString() => Name;
}

public class Chedder : Ingredient
{
    public override string Name => "Cheddar cheese";
    public int AgedForMonths { get; }
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