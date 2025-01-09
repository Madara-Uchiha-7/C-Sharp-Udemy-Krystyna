//yield statement - GetAllAfterLastNullReversed method
//Implement the GetAllAfterLastNullReversed as an iterator method.

//This method takes an IList of some objects.
//It should return all objects occurring after the last null in this list
//but in a reversed order.

//For example:

//For input {"a", "b", null, "d", "e", "f"}, the result shall be
//{"f", "e", "d"} because the strings after the last null are
//"d", "e", "f", and we want to return them in reversed order.

//For input {"a", "b", null, "d", "e", "f", null, "h", "i"},
//the result shall be {"i", "h"}, because the strings after the
//last null are "h", "i" and we want to return them in reversed order.

List<string> numbers = new List<string>();
numbers.Add("0");
numbers.Add("1");
numbers.Add(null);
numbers.Add("2");
numbers.Add("3");
numbers.Add(null);
numbers.Add("4");
numbers.Add("5");

foreach (string number in YieldExercise.GetAllAfterLastNullReversed(numbers))
{
    Console.WriteLine(number);
}
Console.ReadKey();

/// <summary>
/// Note that the GetAllAfterLastNullReversed() is the iterator method.
/// So only code inside foreach will be called each time because iterator method remembers 
/// the flow. Since foreach is a loop it will keep on executing till reverseInputList end
/// or else condition becomes true. 
/// reverseInputList will be created only one time.
/// </summary>
public class YieldExercise
{
    public static IEnumerable<T> GetAllAfterLastNullReversed<T>(IList<T> input)
    {
        IEnumerable<T> reverseInputList = input.Reverse();
        foreach (T item in reverseInputList)
        {
            if (item != null)
            {
                yield return item;
            }
            else
            {
                yield break;
            }
        }
    }
}

// Above code is my code.
// Teacher used better approch that instead of foreach she used for loop 
// and she set i = input.Count - 1 and started looping from opposite side.