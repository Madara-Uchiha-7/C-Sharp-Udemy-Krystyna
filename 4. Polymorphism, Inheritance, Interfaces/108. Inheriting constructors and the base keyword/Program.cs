// From last examples of Ingredients class
// We know that Ingredients is the base class and Cheddar is the child class.
// So, when we create the object of the Cheddar class, which constructor is called.
// Of course the constrcutor we are talking on the above line is default constructor 
// i.e. parameter less one.
// To check this you can create the constructor in both classes and add writeline method in that.
// First parent default constructor will be called and then child's constructor will be called.
// This has to be right because base class default constructor may insitialize the values of some 
// fields which may be needed in the child classes.
// Note: Default constructore is generated only when no other constructor is defined.
// So if you define the parameterised constructor then while creating the obj you need to pass the argument
// or you need to manually define the default constructor.

// Scenario : We have the base class and it has a parameterised constructor and now we know that 
// When child class obj is created using "new" the base class constructor will be called first.
// If this Scenario comes then error will pop up.
// Because base class constructor is expecting the parameter which gets called first.
// To resolve this issue you need to create the same constructor as in the child class, Note: 
// It is okay if you add more than one parameter in child class constructor. 
// But atleast one parameter should match with the type of the base class constructor.
// Then using base(), you will pass it to the base class constructor.
// You need to use syntax given below for Test2


public class Test1
{
    public Test1(int number, string test) 
    {
        Price = number;
    }
    public int Price { get; }
}
public class Test2 :Test1
{
    public Test2 (int number, bool test, string testString) : base(number, testString) 
    {

    }
}
// This base keyword can also be used to access the base class members.
// base.memberName