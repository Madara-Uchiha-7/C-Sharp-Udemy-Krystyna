// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// One of the fundamental principles of C#is that we must be able to treat anything as an instance
// of the System.Object type.
// It means C# has a unified type system where we can treat all objects in a uniform way.
// In our everyday programming, we usually know what types we deal with and we rarely use the System.Object
// But this is not always the case.
// There are many situations when we want to be able to treat all objects uniformly.
// For example, imagine we read data from some Excel files. 
// Each column may store different data types like integers, strings, decimals, date times etc.
// But we won't know what those types are exactly until we read the file.
// And the files may differ, each storing different types.
// When creating the program, we can't make any assumptions about what types a processed file will contain.
// Let's say we want to store all data for a given row in a list.
// This may only work if we use a type that can be assigned any value, no matter its type.
// The only type in C# which can represent any value is the System.Object type.
// 

List<object> variousObjects = new List<object>
{
    1,
    1.5m,
    new DateTime(2024, 6, 1),
    "Hello World",
    new Person{Name = "Chinmay", Age = 29}
};
// Above, by the way, should remind us of an ArrayList, the collection type meant to store anything inside
// which uses an array of objects as its internal data structure.
// Lists are more modern than ArrayLists, so let's keep using a list of objects here.
// A code like this can only work with a unified type system.
// Now, even without knowing what exactly is stored in this list, we can still operate its objects in some basic way.
// For example, we could iterate this list and print each of its items to the console.
foreach(object obj in variousObjects)
{
    Console.WriteLine(obj + " : " + obj.GetType().Name);
    // This works because the System.Object type exposes the ToString method, which is used by the Console.WriteLine
    // ToString is one of the few methods that are present in the object type.
    // Every type in C#, no matter if it is a simple number, a string, a date time or a custom class
    // will provide implementations of those basic methods.
    // If it doesn't implement them itself, it will still have the basic implementation inherited from the System.Object type.
    // For example, obj.GetType() is the GetType method we mentioned before.
    // It returns the Type object which describes the actual type of some value.
    // Let's print the names of the types of each of those objects to the console.
    // For above mentioned excel issue where we do not know the type
    // this GetType() is very helpful.
    // By the way, this shows us that the names of the types we use, for example, int, are sometimes aliases.
    // For example, int is actually named int32 because it is an integral numeric type stored on 32 bits.
    // Now, here is an interesting problem.
    // obj is of the System.Object type, which is a reference type.
    // Remember for reference types, the variable stores, the reference pointing to the object on the heap,
    // but only some of those objects are reference types.
    // Here we have an int, a decimal, and a datetime, which are all value types.
    // Let's consider what happens when the first iteration of the loop is executed.
    // The loop variable is of type System.Object.
    // So as a reference type it should store a reference to an object on the heap, but there is no reference
    // because int is a value type.
    // Well, this is indeed a problem.
    // To bypass this issue, the designers of C# decided that before a value type can be used as an instance
    // of the System.Object reference type, a process called boxing must happen.

}

Console.ReadKey();
class Person
{
    public string Name { get; init; }
    public int Age { get; init; }
}