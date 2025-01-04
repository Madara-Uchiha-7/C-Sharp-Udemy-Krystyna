// All the classes in the C# are derived from the System.Object class.
// That in last sections example, Ingredient class inherits the System.Object
// Since, Ingredient is derived from Object class, all of its child classes will also receive the access to the
// public and protected members of Object class.
// e.g. ToString(), GetType() are provided by the Object class.

// For eg.

Test1 test1 = new Test1();

// The Console's WriteLine method just accepted the class object test1.
// Does this mean there is a method in Console class
// with this definition : public static void WriteLine(Test1 test1)
// No
// It uses the parent Object class. So for example it will look like this.
// public static void WriteLine(object objectToBePrinted) { string text = objectToBePrinted.ToString(); }
// So, now objectToBePrinted will point out to the class Test1's test1.
// WriteLine(object : HERE object is in small case becase it is used as the alias for the System.Object
// This way we can pass anything to this WriteLine() method because every class is derived from the
// Object type. Since there is a method called ToString() in the Object class we can do:
// objectToBePrinted.ToString()
// And then result of the method will be printed to the console.
Console.WriteLine(test1); // OP : test1 : only name of object because it is in gloabal namespace
// Base implementation of ToString() i.e. if we do not override it in our class.
// Will print the objects.
// Lets try this with List object also
Console.WriteLine(new List<int>()); // OP : System.Collections.Generic.List`1[System.Int32]
// Int32 is the real name of int
// Console.WriteLine(test1); and Console.WriteLine(test1.ToString()); // Is same
// Lets override the ToString() for Test1
// Now if you print the test1 then hII will be returned instread of test1.
class Test1
{
    public override string ToString()
    {
        return "hII";
    }
}