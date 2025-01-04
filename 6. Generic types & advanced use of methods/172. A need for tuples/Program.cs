// Return more than one result from the method.

// There are two ways to convert the string to int. One is Parse() and
// other is :
// Eg.
///
/// int.TryParse("abc", out int result);
/// This method returns the bool and has the out parameter.
/// The out parameter is set within the method (by default not by our code).
/// So in a way it works as the second part of the result.
/// This out int result is the result of the method but not as the 
/// return type but as a parameter type.
/// Mam does not like it because, parameter should be the inputs 
/// not outputs. 
///

List<int> numbers = new List<int> { 5, 3, 2, 8, 16, 7 };
TwoInts minAndMax = GetMinAndMax(numbers);
Console.WriteLine("Smallest number is " + minAndMax.Int1);
Console.WriteLine("Largest number is " + minAndMax.Int2);
Console.ReadKey();
TwoInts GetMinAndMax (IEnumerable<int> input)
{
    if (!input.Any())
    {
        throw new InvalidOperationException($"The input collection can not be empty.");
    }
    // First method is the LINQ method which returns the first element
    int min = input.First (); 
    int max = input.First ();

    foreach (int number in input)
    {
        if (number < min)
        {
            min = number;
        }
        if (number > max)
        {
            max = number;
        }
    }
    return new TwoInts (min, max);
}
public class TwoInts
{
    public int Int1 { get; }
    public int Int2 { get; }

    public TwoInts (int int1, int int2) 
    {
        Int1 = int1;
        Int2 = int2;
    }
}

// This allowed us to return more than one result.
// But What if there are more than 2 items we want in result or other type
// then there is predefined collection called Tuple which can be used.