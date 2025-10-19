// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// Base type has data and methods which can be used by the derived classes.
// Derived class can have their seperate own methods and fields etc which will be availbale 
// for only that perticualr derived class. 


Pizza pizza = new Pizza();
pizza.AddIngredient(new Chedder());
pizza.AddIngredient(new Mozzarella());
pizza.AddIngredient(new TomatoSauce());
Console.WriteLine(pizza.Describe());

// Create the obj of Chedder and call the base class method using this obj
Chedder chedder = new Chedder();
Console.WriteLine(chedder.publicMethod());
// We can also us this method directly in the Chedder class.

// Lets use the pulbic field
Ingredient ingredient = new Ingredient();
ingredient.PublicField = 10;
// Let also use Chedder class obj to use this field
chedder.PublicField = 20;
Console.WriteLine(ingredient.PublicField); // this will print 10
Console.WriteLine(chedder.PublicField); // this will print 20
// Even thought the Chedder is using the public field of the base calss, the diff memory is used for 
// both of them bcz the object is different even thought Derived class is accessing the Base class obj.
// Remember that classes are like blueprints and field declaration is a part of this blueprint.
// Inheriting the base class by the derived type means each of its public fields is also 
// declared in the derived types.

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
    // Adding public method to this class.
    public public string publicMethod() =>
        "This method is public in the Ingredient class.";
    // protected access modfier. The method which have the protected access modifier will
    // be available to the derived classes, but they can not be used outside.

    // pulbic modifier to the feilds works same as for methods.
    // Lets say Ingredient has public field name and Chedder class also uses this field.
    // using Chedder class object.thisParentPublicFieldName.
    // Look at this below line and check fromline 17.
    public int PublicField;
}

public class Chedder : Ingredient
{
    public string Name => "Cheddar cheese";
    public int AgedForMonths { get; }

    public void useMethodFromBaseClass()
    {
        // Calling methods of base class from this class. Possible because this method is public in the 
        // base class. You can not use the private base class method in or using child classes.
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

// This above code shows that inheritance is is-a kind of relationship
// TomatoSauce is a Ingredient
// Mozzarella is a Ingredient
// Chedder is a Ingredient
