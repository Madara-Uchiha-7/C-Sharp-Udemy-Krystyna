// .NET history.
// 2002 was 1.0 Initial release. 
// Generic types were added in .NET Framework 2.0 released in 2005.
// In the same release the new group of collections, including List of T
// was defined, and today we can find it in System.Collections.Generic namespace.
// This namespace is imported globally in console application, so we don't need to add
// it using the 'using' keyword.
// The Devs was not using List  from 2002 to 2005 because it was not released.
// So how to create a data structure similar to list that can store any type of item but without
// using the generic types? 
// Using System.Object type.
// Since all the types in C# are derived from System.Object, we can put anything into a collection
// of objects.
// The collection that works this way, so storing elements of the System.Object was added to 
// .Net with its initial release.
// It was called ArrayList.
// It works similary as the list we know, but it wasn't parameterized by the type of elements
// it store.

using System.Collections;

ArrayList ints = new ArrayList
{
    2, 3, 4, 5
};

ArrayList strings = new ArrayList
{
    "a", "b", "c", "d"
};

// Issue:
// Since ArrayList stores any type of object
// it allows us to perform the operations which List will never allow us to do.
// e.g. We can store diff types in one collection.
ArrayList variousItems = new ArrayList
{
    1,
    "Hello",
    new DateTime(),
    false
};
// Internally above will look like this:
object[] variousObjects = new object[]
{
    1,
    "Hello",
    new DateTime(),
    false
};


// Now we can have issue in case like below
int sum = 0;
foreach (object intValue in ints)
{
    // sum += intValue; // <-- Here will be the issue since intValue is object and sum is int.
    // This above issue is there because the ArrayList can hold diff types of object.
    // So you will have to use the cast here to make it work.
    sum += (int)intValue;
    // But this is risky since Array List may have different types.
    // Also case are performance heavy. It is both way like line 60 and while defining the ArrayList 
    // with same or different types.
    // When we define the ArrayList with some types
    // then for e.g. if there is integer 2 in the ArrayList while defining then
    // This process of assigning simple data types to objects is called boxing, and it is 
    // more complex than it may seem.
}

Console.ReadKey();

// So basically ArrayList performance is poor and it is better to not use it.