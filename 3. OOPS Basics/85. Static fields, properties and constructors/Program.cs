// Lets say you want to keep the track of number of instance created
// You want to see the number on instances gets created outside the class
// but you do not want to make it updatable
// Only way to do is to make a Property static and 
// make setter private and increment the number in constructor
// To access the static property you have to use the ClassName.PropertyName
class Rectangle
{
    public static int CountOfInstances { get; private set; }

    public Rectangle()
    {
        ++CountOfInstances;
    }
    
}
// If we dont initialize static field or property then default value
// of that perticular type will be set to that field or property.


// Lets say you want to have a static field that will store the 
// date and time of the first usage of this class.
class Square
{
    // One way to solve above question is as below:
    // Assigning the value at the declaration of the variable
    // private static DateTime _firstUsed = DateTime.Now;
    
    // Another way is in the static constructor.
    // Static constructor does not have any access modifier ,
    // instead it will have a static modifer.
    private static DateTime _firstUsed;

    static Square()
    {
        _firstUsed = DateTime.Now;
    }

    // We saw two ways to solve the question
    // Both of them gets initialize before the first instance creation 
}

// Note: Having static fields and properties is a risky bussiness : From teacher