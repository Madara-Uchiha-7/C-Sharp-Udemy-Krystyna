///
/// we will see how to access the collection of keys of a Dictionary.
/// We will also practice defining generic methods.
/// We will change the last lecture code.
/// Lets change the way we take the input from the user.
/// Let's add a property to FilteringStrategySelector class that will expose a collection of the dictionary keys.
/// So that we can use same dictionary for user taking the input and same in 
/// FilteringStrategySelector's Select method.
/// So that if we need to add one more filter then we can change only dictionary and it will automatically reflect
/// the user input options and FilteringStrategySelector's Select method.
/// 
/// FilteringStrategiesNames property of a dictionary simply exposes the collection of its keys.
/// So in this case, it will be a collection of strings with words "even", "odd" and "positive" inside.
/// If we wanted to access the collection of values, we could do it like : _filteringStrategies.Values;
/// 
/// We can now use this new property to print the list of available ways of filtering to the console.
/// Now, if we want to allow the user to filter negative numbers only, we will just need to add:
/// { "Negative", number => number < 0 }
/// in FilteringStrategySelector's _filteringStrategies.
/// 
/// The last thing that we can improve is NumbersFilter's FilterBy method.
/// Last lecture ones works great, but only for integers.
/// If we wanted to use it for strings or date times, we couldn't.
/// It would be better to make it generic so it can filter a collection of any type.
/// We will also change the name of this class.
/// Also instead of List, we can make it more general if it operates on an IEnumerable of T.
/// This way we will be able to use, for example, an array as an input.
/// 
/// For. e.g check the code:
/// var words = new[] { "Zebra", " Ostrich", "Otter" };
/// var oWords = new Filter().FilterBy(
/// words => words.StartsWith("O"),
/// words);
/// 
/// FilterBy() is now very similar to the Where method from LINQ.
///

List<int> numbers = new List<int> { 1, 2, 3, 10, -100, 55, 17 };

var filteringStrategySelector = new FilteringStrategySelector();

Console.WriteLine("Select Filter:");
Console.WriteLine(
    string.Join(
        Environment.NewLine, 
        filteringStrategySelector.FilteringStrategiesNames
    )
);

var words = new[] { "Zebra", " Ostrich", "Otter" };
var oWords = new Filter().FilterBy(
    words => words.StartsWith("O"),
    words);


var userInput = Console.ReadLine();

var filteringStrategy = new FilteringStrategySelector().Select(userInput);

// IEnumerable<int> result = new Filter().FilterBy(filteringStrategy, numbers);
// Instead of above line use below :
var result = new Filter().FilterBy(filteringStrategy, numbers);
// Using a var is a good thing because if some does the changes in the return type like we did in 
// filter class in which we replaced List with IEnumberable, then code will not break.


Print(result);
Console.ReadKey();

void Print(IEnumerable<int> numbers)
{
    Console.WriteLine(string.Join(", ", numbers));
}

public class Filter
{
    public IEnumerable<T> FilterBy<T>(Func<T, bool> predicate, IEnumerable<T> numbers)
    {
        var result = new List<T>();
        foreach (T number in numbers)
        {
            if (predicate(number))
            {
                result.Add(number);
            }
        }
        return result;

    }
}

public class FilteringStrategySelector
{

    private readonly Dictionary<string, Func<int, bool>> _filteringStrategies =
        new Dictionary<string, Func<int, bool>>
        {
            { "Even", number => number % 2 == 0 },
            { "Odd", number => number % 2 == 1 },
            { "Positive", number => number > 0 },
        };

    public IEnumerable<string> FilteringStrategiesNames =>
        _filteringStrategies.Keys;

    public Func<int, bool> Select(string filteringType)
    {
        if (!_filteringStrategies.ContainsKey(filteringType))
        {
            throw new NotSupportedException($"{filteringType} is not a valid filter.");
        }
        return _filteringStrategies[filteringType];

    }
}

