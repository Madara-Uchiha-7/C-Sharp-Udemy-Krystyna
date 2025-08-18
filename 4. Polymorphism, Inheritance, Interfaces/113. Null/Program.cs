// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// We can assign the null explicitly.
Ingredient nullIngredient = null;
// You can not use var keyword if you are assigning the null.
// null value is common for all the classes, that means variable does not store any instance.
// One of the most common errors in C# is using a member on an object while object is null.
// You will get NullReferenceException:Object reference is not set to an instance of an object.
// You can check if object is null or not
if (nullIngredient != null)
{

}
// OR 
if (nullIngredient is not null) // is not null operator
{

}
// Second solution is more certain because operators can be overloaded, which means a type may redefine
// what a given operator does.
// i.e. if someover overloads the != operators and changes is default way then it can cause problem.
// "is not null" operator can not be overloaded.
public class Pizza
{
    // We can use below fields even if we have not initialized them.
    // Default value will be used.
    public int number;
    public DateTime date;

    // What will be the default value of object
    // If you print it using pizzaObj.ingredient;
    // on console, you will see nothing. If you debug then you will see null in quick watch.
    public Ingredient ingredient;
    // null is the special value which means that the field or a variable does not hold any instance.
}

public class Ingredient
{
}

// Not all types can be assigned null.
// e.g.
// int can not.
// i.e. Numbers, Bools and DateTime does not allow null to be assigned to them.
// Thats why they have the default values.