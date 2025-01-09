// Lets see the example, when params keyword will help.
// Lets create the calculator class containing the Add method, adding 2 numbers.
// 


Console.WriteLine(Calculator.Add(1, 2));


Console.ReadKey();
public static class Calculator
{
    public static int Add(int a, int b) => a + b;
}


// But what if we have a new requirement where we need to check the 
// addtion of 3 numbers ? We will increase the parameter right. If there are 
// more then we will simply make a parameter a collection right. 
// Like
public static class ConllectionCalculator
{
    public static int Add(IEnumerable<int> numbers) => numbers.Sum();
}
// But this wont work becuase while calling this Add()
// Line "Console.WriteLine(CollectionCalculator.Add(1, 2, 3));
// will not work. We need to to pass the IEnumerable. 
// We can pass : new List<int>{1, 2, 3} or new int[] {1, 2, 3} as a argument 
// to the Add method. 
// This will also break the backword compatibility. 
// For e.g. if we change the method parameter to "IEnumerable<int> numbers"
// then old calls like "Calculator.Add(1, 2)" this will not work.
// There is better alternative.

// So how to pass any number of parameters without wrapping them in the collection.
// We can use the params keyword.

public static class ParamCalculator
{
    public static int Add(params int[] numbers) => numbers.Sum();
}

///
/// This above will now work for below call:
/// Console.WriteLine(ParamCalculator.Add(1, 2, 3));
/// This works with single dimentional array type.
/// Under the hood the 1,2,3 will be wraped in the array and then will be passed to the
/// method.
/// This also maintains the backword compatibility because you do not need to change
/// the old function calls and also can add as many numbers you want to 
/// get the sum.
/// There are 2 limitations with this params keyword.
/// 1. There can only be one parameter with this modifier in a method.
/// So if you do params int[] num1, params int[] num2: How the compiler will know 
/// when the num2 array will begin in the argument section.
/// 2. It must be the last paramter.
/// 
/// It is okay if do not pass any arguments, in such cases the parameter array 
/// will be empty.
///
