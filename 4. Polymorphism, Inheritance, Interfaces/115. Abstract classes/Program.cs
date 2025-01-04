// In older lectures we were able to create Ingredient object outside the class.
// But Ingredient is the abstract concept made concrete by its subtype.
// You can not go the Restaurant and ask for Pizza With Chadder and Tomato Sauce.
// Ingredient class is useful for us to have it as it defines things common for any
// kind of ingredient.
// So, basically you should not be able to create the object of Ingredient itself.
// So it is better to make that class abstract.
///
/// Abstract classes can not be instantiated. They only serve as the base classes for 
/// other, more concrete types. You can define it using "abstract" keyword.
///
// Ingredient ingredient1 = new Ingredient();/*This line wont work now*/
Pizza pizza = new Pizza();
pizza.AddIngredient(new Chedder());
pizza.AddIngredient(new Mozzarella());
pizza.AddIngredient(new TomatoSauce());
public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();
    public void AddIngredient(Ingredient ingredient) =>
        _ingredients.Add(ingredient);

    public string Describe() => $"This is a pizza with " +
        $"{string.Join(", ", _ingredients)}";
    public override string ToString() => $"This is a pizza with " +
        $"{string.Join(", ", _ingredients)}";
}

public abstract class Ingredient
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