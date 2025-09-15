///
/// Lets define the class NumbersFilter
/// which will contain a method FilterBy and this method will take a string representing a filter,
/// so for example, a word like "even" or "odd" or "positive" and a collection of numbers.
/// We will move the switch in this method and change that switch.
/// We will remove the brake keywords since they are not needed if we return from a case.
///
/// Without the access modifier specified methods in a class are private by default. But it
/// is more expressive to make them private explicitly.
///


List<int> numbers = new List<int> { 1, 2, 3, 10, -100, 55, 17 };

Console.WriteLine(@"Select Filter:
Even
Odd
Positive:");

var userInput = Console.ReadLine();

List<int> result = new NumbersFilter().FilterBy(userInput, numbers);

Print(result);
Console.ReadKey();

void Print(IEnumerable<int> numbers)
{
    Console.WriteLine(string.Join(", ", numbers));
}


/// When using top-level statements i.e like Print(), the class declarations must be at the bottom.


public class NumbersFilter
{ 
    public List<int> FilterBy(string filterType, List<int> numbers)
    {
        switch (filterType)
        {
            case "Even":
                return Select(numbers, number => number % 2 == 0);

            case "Odd":
                return Select(numbers, number => number % 2 == 1);

            case "Positive":
                return Select(numbers, number => number > 0);

            default:
                throw new NotSupportedException($"{filterType} is not a valid filter.");
        }
    }
    private List<int> Select(List<int> numbers, Func<int, bool> predicate)
    {
        List<int> result = new List<int>();
        foreach (int number in numbers)
        {
            if (predicate(number))
            {
                result.Add(number);
            }
        }
        return result;
    }
}


// We can improve this code also. Lets do that in the following lecture.