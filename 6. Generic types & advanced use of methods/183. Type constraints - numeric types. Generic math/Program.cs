// Type constraint that allows us to limit the type of argument to only numeric types.
// That is also known as the Generic Math in C#


using System.Numerics;

Console.WriteLine("Square of 2 is : " + Calculator.Square(2));

// Dpes not work if no seperate method for below numeric types like above
Console.WriteLine("Square of 4m is : " + Calculator.Square(4m));
Console.WriteLine("Square of 6d is : " + Calculator.Square(6d)); 


// --> But below lines will work due for Generic Calculator class.

Console.WriteLine("Square of 2 is : " + GenericCalculator.Square(2));
Console.WriteLine("Square of 4m is : " + GenericCalculator.Square(4m));
Console.WriteLine("Square of 6d is : " + GenericCalculator.Square(6d));
public static class Calculator
{
    public static int Square(int input) => input * input;
    
    public static decimal Square(decimal input) => input * input;

    public static double Square(double input) => input * input;

}



public static class GenericCalculator
{
    public static T Square<T>(T input) where T : INumber<T>
        => input * input;
}

// INumber interface comes from the System.Numerics namespace.
