///
/// We will also learn what the fields of a class are and what their default values are.
/// Finally, we will see what a default constructor is.
/// 

// Constructor is a method used to instantiate objects of a class.
// i.e. Rectangle()
// We did not define any constructor, so the only constructor we can use is the default parameterless
// constructor that is automatically created for us if we don't create our own.
var rectangle = new Rectangle();

// We will not be able to access the fields(A field is a variable that belongs to an object of a class.)
// width and height of Rectangle class using rectangle object.
// Why not? we will see that in next lecture.

Console.ReadKey();
// By convention, we should start the class name with a capital letter.
class Rectangle
{
    // A field is a variable that belongs to an object of a class.
    // Each instance of the rectangle class can have different values of those fields.
    // So, for example, we can have one rectangle instance of width ten and height two, and another of width
    // five and height six.
    int width;
    int height;
}

// As you remember from the C# fundamentals section, when we declare a variable and do not initialize
// it, it is simply uninitialized.
// If we try to use it, we will get a compilation error because in C# we cannot use uninitialized
// variables.
// With fields it is different.
// If we don't initialize a field ourselves, it is automatically set to the default value for its type.
// For integers it is zero.
// So for this rectangle object, the values of fields width and height are zero if we do not assign them
// while creating the object or after creating the object.

