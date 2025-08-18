// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

List<int> ints = new List<int>() { 1, 2, 3 };

// We will create one extension method so that we can add 
// the value at the front of the list.
// Lets create the ListExtension class.
// Remember that extension methods can only be defined in static classes.

// The generic AddToFront() method :
// We don't have add <int> to specify that we are passing int value
// like ints.AddToFront<int>(10);. This is also valid if you specify it 
// but you don't need to.
// It understands it using the parameter type we are passing.
// If you pass string instead of int here like:
// ints.AddToFront("value");
// then you will see an
// error called type can not be inferred from the usage.
// Why this will fail because this 'List<T> list' will take the list of int
// but 'T item' will have type string.
// So compiler gets confuse to which type to assign to T, int or string.
// We can help compiler by explicitly writing like:
// ints.AddToFront<int>("value");
// Now error will be 'can not conver from string to int' instead of
// 'you can not be inferred from the usage'.
ints.AddToFront(10);
// For above line if you write : ints.AddToFront<int>(10);
// the <int> will be grayed out because here it is not needed for compiler
// to find the type.
Console.ReadKey();
static class ListExtension
{
    // Add <T> after the method name like we do for the classes.
    // then use that T in parameters if you want.
    public static void AddToFront<T>(this List<T> list, T item)
    {
        // item is a new element to be added.
        // Insert is a default method provided by List to add 
        // the value at specific index.
        list.Insert(0, item);

    }
}
