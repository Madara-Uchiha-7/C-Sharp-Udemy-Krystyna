// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

int number = 5;

Person person = new Person { Name = "Chinmay", Age = 29 };

// Let's think about how above objects will be stored in memory.
// Since they are local variables in the Main method, the number variable, which is a value type, will be stored on the stack.
// On the other hand, person is a reference type, so only the reference will be stored on the stack and
// it will point to an object stored on the heap.
// Lets see one more line:
object boxedNumber = number;
// Object is a reference type, so its value is stored on the heap, and the reference pointing to this value
// is stored on the stack.
// But an integer is a value type, so it doesn't have a reference.
// This is what happens to solve this pickle: when we assign a value type to a variable of reference type,
// specifically an object
// the value type variable will be boxed.
// When the value is boxed, it is wrapped inside a new instance of the System.Object class and stored
// on the heap.
// Boxing happens implicitly each time we assign a value type to an instance of a reference type, most
// typically System.Object.
// But keep in mind that this is not the only case.
// For example, all interface types are reference types.
// So if we do something like this...
IComparable<int> intAsComparable = number;
//...boxing will also happen because this variable is of an interface type and, as such, is a reference type. 
// Still, we assign a value type to it, so boxing will be performed.

List<object> variousObjects = new List<object>
{
    1,
    1.5m,
    new DateTime(2024, 6, 1),
    "Hello World",
    new Person{Name = "Chinmay", Age = 29}
};
// Boxing also happens implicitly here(above line parameters) where we add some value types to the list of objects.
// Each of those value type variables has been boxed so wrapped in new instances of System.Object.

// Let's now consider the opposite process.
// The unboxing.
// Unboxing is converting the boxed value back to the value type.
// Unlike boxing, which has been done implicitly, so it didn't require an extra syntax,
// unboxing must be done explicitly.
int unboxedNumber = (int)boxedNumber;
// Unboxing would fail if the value wrapped in object would not exactly match the type we are assigning to.
// That's why it needs to be done explicitly.
// For e.g.
// short unboxedNumber = (short)boxedNumber; // This will give the error.
// Please be aware that boxing and unboxing come with a performance penalty.

Console.ReadKey();  
class Person
{
    public string Name { get; init; }
    public int Age { get; init; }
}