///
/// We will learn what the Strategy design pattern is and how it can help us improve our
/// code.
/// 
/// We will also learn about yet another of the SOLID principles, the Open-Closed Principle.
/// 
/// Finally, we will practice using Funcs and dictionaries as well as defining generic methods.
/// 
/// In Last code, we will need to modify it each time we add a new way of filtering.
/// This is against yet another SOLID principle, the Open-Closed Principle.
/// 
/// Remember, SOLID is a set of five principles that should be met by well-designed software.
/// The O in solid stands for the Open-Closed principle, which states that modules, classes and functions
/// should be open for extension but closed for modification.
/// 
/// In other words, we should create our code in such a way that its behavior can be changed by adding
/// new code, not modifying the existing one.
/// 
/// Lets see why in general, it would be better not to modify the code we have.
/// 
/// When you have a class, and you don't touch it, you most likely have a class that works. In real-life
/// projects it would not only be tested manually by the developers and perhaps dedicated testers, but it would
/// also be covered by unit tests.
/// Unit tests are the special methods that automatically verify if a class behaves as expected.
/// 
/// Secondly, if other developers rely on some code and we suddenly change it, they might get surprised.
/// Maybe they liked the old implementation and the new one will not work for them.
/// 
/// Also, if the class belongs to a shared library and other programmers reference it, as long as it's
/// not modified, we don't need to release the new version of this library.
/// 
/// Now, if we modify a class in any way, we should test it again manually and ask the testers to do it too.
/// Also, we will need to update the unit tests.
/// And remember, no tests, whether manual or automatic, are perfect, so each change always brings a risk
/// of creating a bug.
/// 
/// The change in one class may affect many other parts of the project, and sometimes it is not obvious which ones.
/// 
/// Changes must be introduced, but it's best to do it by extending the code, not changing it.
/// Of course it is not always possible.
/// Or sometimes, it is just practical to simply modify the code, for example, to fix a bug.
/// 
/// Still, if we can design our code in such a way that its behavior can be changed without modifying it,
/// but by extending it, we should definitely do it.
/// 
/// In our NumbersFilter class case, we will have to add a new case to the switch and define a new lambda expression. To make
/// this class independent of such changes
/// we should rather pass the function defining the way of filtering to this method as a parameter instead
/// of creating it right here.
/// 
/// Which, by the way, will fix another issue in the code: the breaking of the Single Responsibility Principle.
/// Now, this class has two responsibilities.
/// It knows how to filter collections, which is implemented in this method i.e. Select() method.
/// And it also knows how to translate the string i.e. FilterBy.
/// 
/// So instead of passing a string in FilterBy as string filterType, we will pass a function, taking an int and returning a bool
/// which we will pass it in Select().
/// 
/// Let's now create the class that will take the responsibility of translating the string
/// the user entered to a way of filtering.
/// We will name it FilteringStrategySelector.
/// 
/// FilteringStrategySelector's Select method simply takes the filtering type name and returns a proper Func.
/// 
/// What we just did was use the Strategy design pattern.
/// This pattern allows us to define a family of algorithms that perform some tasks.
/// The concrete strategy can be chosen at runtime, and this is exactly what happens here.
/// 
/// We defined a family of simple algorithms, each meant to decide whether a number should be included
/// in the result or not. i.e. FilteringStrategySelector's switch.
/// 
/// Then we choose which one of them should be used at runtime based on the user input. Thanks to using this pattern:
/// var filteringStrategy = new FilteringStrategySelector().Select(userInput);
/// 
/// NumbersFilter class is now completely independent on the concrete way of numbers filtering.
/// It is not aware what algorithms exactly we have available now.
/// All it knows is that it is given the strategy of filtering numbers i.e.Func<int, bool> predicate
/// and it doesn't ask questions how exactly those functions work as long as they take an int as a parameter and return a bool.
/// 
/// It is in line with the Open-Closed Principle because this class will not be modified when a new strategy
/// must be added. 
/// Only FilteringStrategySelector class will be.
/// This class is now only focused on providing a mapping from the algorithm name to the algorithm implementation.
/// So the impact of this change should be low.
/// 
/// Speaking of mappings, there is one more thing we can do to improve this code.
/// We could get rid of the switch statement and replace it with the use of a dictionary.
/// This switch exists to map a name of the filter given by the user to the filtering predicate.
/// We can store this mapping in a dictionary where the key will be the string with the filter name and
/// the value will be a func that implements this way of filtering.
/// This is done in 197_1. Open-Closed Principle. Strategy design pattern
/// 
///

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
    public Func<int, bool> Select(string filteringType)
    {
        switch (filteringType)
        {
            case "Even":
                return number => number % 2 == 0;

            case "Odd":
                return number => number % 2 == 1;

            case "Positive":
                return number => number > 0;

            default:
                throw new NotSupportedException($"{filteringType} is not a valid filter.");
        }
    }
}

