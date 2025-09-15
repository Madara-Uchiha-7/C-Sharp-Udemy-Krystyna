
List<int> numbers = new List<int> { 1, 2, 3, 10, -100, 55, 17 };

Console.WriteLine(@"Select Filter:
Even
Odd
Positive:");

var userInput = Console.ReadLine();

var filteringStrategy = new FilteringStrategySelector().Select(userInput);

List<int> result = new NumbersFilter().FilterBy(filteringStrategy, numbers);

Print(result);
Console.ReadKey();

void Print(IEnumerable<int> numbers)
{
    Console.WriteLine(string.Join(", ", numbers));
}

public class NumbersFilter
{
    public List<int> FilterBy(Func<int, bool> predicate, List<int> numbers)
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

public class FilteringStrategySelector
{

    private readonly Dictionary<string, Func<int, bool>> _filteringStrategies =
        new Dictionary<string, Func<int, bool>>
        {
            { "Even", number => number % 2 == 0 },
            { "Odd", number => number % 2 == 1 },
            { "Positive", number => number > 0 },
        };
    public Func<int, bool> Select(string filteringType)
    {
        if (!_filteringStrategies.ContainsKey(filteringType))
        {
            throw new NotSupportedException($"{filteringType} is not a valid filter.");
        }
        return _filteringStrategies[filteringType];

        // Not how if-else is not used and instead only using if we have solved this.
    }
}


// They are still some improvements we can make, but let's do it in the next lecture.


/*
What is happening in the code:

We take the user input.

Then we called the FilteringStrategySelector's Select()
and we passed the user input to it.
We kept its result in the filteringStrategy.

FilteringStrategySelector's Select():
    It returns the Func which takes the integer as the parameter and returns the bool.
    So, it is returning the dictionary's _filteringStrategies value using the key.
    Which has key which is of a type Func which takes the integer as the parameter and returns the bool.

Now the variable filteringStrategy contains:
The Func which takes the integer as the parameter and returns the bool.
And that function is a lambda expression in our case.


Then we pass that Func to the 
NumbersFilter's FilterBy method.
Which takes the Func which takes the integer as the parameter and returns the bool
and numbers list.

NumbersFilter's FilterBy():
It will take the number one by one from the 2nd parameter and 
pass it to our Func which is the lambda function in our case which we got from the dictionary's key.

And then according to the logoc written in the lambda, we return the new list. 
*/