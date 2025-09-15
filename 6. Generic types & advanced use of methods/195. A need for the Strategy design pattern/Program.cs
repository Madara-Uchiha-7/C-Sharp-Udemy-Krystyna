
/// In the next couple of lectures, we will practice using both dictionaries and Funcs.
/// We will also learn what the Strategy design pattern is.
/// But first, let's see an example of code that can benefit from using this pattern.
/// 
/// Let's say we want to allow the user to choose how those numbers are filtered.
/// For example, when the user enters the words "event" or "odd" or "positive" to the console, only such numbers should be
/// printed.

List<int> numbers = new List<int> { 1, 2, 3, 10, -100, 55, 17 };

Console.WriteLine(@"Select Filter:
Even
Odd
Positive:");

var userInput = Console.ReadLine();

List<int> result;

switch (userInput)
{
    case "Even": 
        result = SelectEven(numbers);
        break;

    case "Odd":
        result = SelectOdd(numbers);
        break;

    case "Positive":
        result = SelectPositive(numbers);
        break;

    default:
        throw new NotSupportedException($"{userInput} is not a valid filter.");
}



Print(result);
Console.ReadKey();

void Print(IEnumerable<int> numbers)
{
    Console.WriteLine(string.Join(", ", numbers));
}

List<int> SelectEven(List<int> numbers)
{
    List<int> result = new List<int>();
    foreach (int number in numbers)
    {
        if (number % 2 == 1)
        {
            result.Add(number);
        }
    }
    return result;
}
List<int> SelectOdd(List<int> numbers)
{
    List<int> result = new List<int>();
    foreach (int number in numbers)
    {
        if (number % 2 != 0)
        {
            result.Add(number);
        }
    }
    return result;
}
List<int> SelectPositive(List<int> numbers)
{
    List<int> result = new List<int>();
    foreach (int number in numbers)
    {
        if (number > 0)
        {
            result.Add(number);
        }
    }
    return result;
}


// Lets refactor the code in next lecture.