// Class Ingredient can hold the object of class Chedder.
// This works because Chedder is an Ingredient after all.
// That is, the base class object can point to the child class object.
Ingredient ingredient = new Chedder();
// Now, you can not access the properties which are in child class but are not in base class, using
// above object. If the same name property is present in the base class and you use above object to access that
// property then the base class property will be use even when base class object is pointing to the child
// class object. This above line 4 object of Ingredient class is called GeneralType in such cases and
// ingredient is a varibale of that general type.
// This goes for methods also. 
// In backend C# checks if the method which is being called is virtual or not 
// if not then it calls the method of General Type object.
// If the method is of General Type then it checks if the actual type of the object stored 
// in the variable. In this case the type of object stored in this variable is SpecificType
// derived from the GeneralType. The C# will then call the SomeMethod defined in this SpecificType
// if it overrides the base type method. If not then implementation of the base class will be used.

// Virtual methods or property means they may be overridden by the inheriting types.
// So lets say you add a property called Name in the base class and you want to call the 
// Chedder class (child class) property Name using the General Class variable (Ingredient class obj.)
// So, two keywords you need to use in the child class
// 1. override keyword in the child class property.
// 2. virtual keyword to base class property.
// Only adding virtual means, I think that property or method is available to the be overriden but
// it is not compulsory to override it.
// We will do those changes to the Name property now.

Console.WriteLine(ingredient.Name);

// Now, we can also create the list of Ingredient which can hold the diff types (child classes)
List<Ingredient> ingredients = new List<Ingredient>
{
    new Chedder(), // Same as Ingredient ingredient = new Chedder();  -- ingredients[0]
    new Mozzarella(), // Same as Ingredient ingredient = new TomatoSauce();  -- ingredients[1]
    new TomatoSauce() // Same as Ingredient ingredient = new Mozzarella();  -- ingredients[2]
};
// Having such list, we can handle those different objects in a uniform way because they expose a common
// interface. Each of them has the name property. Since name property is public in the Ingredient class,
// every type we have that is an Ingredient also exposes this property as of its interface.
// The interface of an object is the collection of all the members of this object its users can access,
// including methods, properties and fields.
foreach (Ingredient ingredient in ingredients)
{
    Console.WriteLine(ingredient.Name);
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
    public string Name => "Tomato Sauce";
    public int TomatoIn100Grams { get; }
}

public class Mozzarella : Ingredient
{
    public string Name => "Mozarella";
    public bool IsLight { get; }
}
