///
/// We will learn what switch expressions are, as well as what pattern matching is.
/// Switch expressions were introduced with C# 8 and they are alternatives to plain old
/// switch statements.
/// 
/// Switch expressions allow us to simplify our code, making it more readable, shorter and more expressive
/// compared to traditional switch statements.
/// 
string OldSwitch(int points)
{
    // No need of breaks because we are returning, so next code will not be executed.
    switch(points)
    {
        case 10:
        case 9:
            return "A";
        case 8:
        case 7:
        case 6:
            return "B";
        case 5:
        case 4:
        case 3:
            return "C";
        case 2:
        case 1:
            return "D";
        case 0:
            return "E";
        default:
            return "!";
    }
}
///
/// 
///
char NewSwitchExpression(int points)
{
    return points switch
    {
        10 or 9 => 'A',
        8 or 7 or 6 => 'B',
        5 or 4 or 3 => 'C',
        2 or 1 => 'D',
        0 => 'E',
        _ => '!'
    };
}

///
/// First, the entire switch statement has been transformed into a single expression, making it more concise.
/// We start by writing the variable that determines the logic i.e. points in 
/// this case, followed by the switch keyword.
/// 
/// Then comes the body of the switch expression where we define how different values map to specific outputs.
/// Each input value appears on the left, followed by the arrow operator which specifies the corresponding
/// output.
/// 
/// Multiple cases are separated by commas.
/// Finally, we have the wildcard, which acts like the default case in a traditional switch statement,
/// catching any unmatched values.
/// We have no case or break keywords.
/// Instead, we use simple mappings using the arrow operator.
/// We have multiple values in a single condition.
/// We can use the "or" keyword instead of repeating case statements.
/// Lastly, the wildcard acts like default in a traditional switch.
/// But switch expressions aren't just about reducing lines of code.
/// They also work great with pattern matching.
/// Pattern matching is a powerful feature in C# that allows us to check a value against specific patterns,
/// rather than just exact matches.
/// With switch expressions, we can use different types of patterns like constant patterns, for example
/// 9 or 10.
/// Relational patterns, for example larger than 90, and even type patterns,
/// checking if a value is of a specific type.
/// e.g. obj is string txt
/// 
/// This makes our code more expressive and flexible, because instead of writing multiple if statements,
/// we can describe our logic in a clear, concise way.
/// 
/// 
/// 
char NewSwitchExpression_1(int points)
{
    return points switch
    {
        >= 90 => 'A',
        >= 80 => 'B',
        >= 50 => 'C',
        _ => 'D'
    };
}


///
/// These features allow us to test values in even more advanced ways.
/// However, some of the more complex cases go beyond what we know at this stage of the course.
/// To know more about this:
///
/*
Switch Expressions and Pattern Matching in C#
Switch expressions in C# are a concise and readable way to handle multiple conditions. They work seamlessly with pattern matching, allowing us to write expressive and maintainable code.

1. Constant Pattern Matching
Matching specific values, similar to traditional case statements:

string GetCategory(int number) => number switch
{
    1 => "One",
    2 => "Two",
    3 => "Three",
    _ => "Other" // Default case
};

Console.WriteLine(GetCategory(2)); // Output: Two


2. Relational Pattern Matching (>=, <=)
Using ranges instead of listing out every possible value:
string GetGrade(int score) => score switch
{
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    >= 60 => "D",
    _ => "F"
};

Console.WriteLine(GetGrade(85)); // Output: B


3. Type Pattern Matching
Handling different types dynamically:
string DescribeObject(object obj) => obj switch
{
    int n => $"It's an integer: {n}",
    string s => $"It's a string: {s}",
    bool b => $"It's a boolean: {b}",
    _ => "Unknown type"
};

Console.WriteLine(DescribeObject(42));        // Output: It's an integer: 42
Console.WriteLine(DescribeObject("Hello"));   // Output: It's a string: Hello
Console.WriteLine(DescribeObject(true));      // Output: It's a boolean: True


4. Positional Pattern Matching (with Tuples)
Matching multiple values at once using tuples:

string WeatherAdvice(string weather, bool isWeekend) => (weather, isWeekend) switch
{
    ("Sunny", true) => "Go to the beach!",
    ("Sunny", false) => "Enjoy a walk after work.",
    ("Rainy", _) => "Stay inside and read a book.",
    _ => "Just another day."
};

Console.WriteLine(WeatherAdvice("Sunny", true)); // Output: Go to the beach!


5. Property Pattern Matching (Matching Object Properties)
Extracting and matching specific properties inside an object:
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

string GetDiscount(Person person) => person switch
{
    { Age: < 12 } => "Child discount",
    { Age: >= 65 } => "Senior discount",
    _ => "Regular price"
};

Console.WriteLine(GetDiscount(new Person { Name = "Alice", Age = 10 })); // Output: Child discount
Console.WriteLine(GetDiscount(new Person { Name = "Bob", Age = 70 }));   // Output: Senior discount


Summary
 ✅ Constant patterns – Match exact values.
 ✅ Relational patterns – Use comparisons like >=, <=.
 ✅ Type patterns – Match and handle different types.
 ✅ Tuple patterns – Match multiple values at once.
 ✅ Property patterns – Match object properties.
Switch expressions + pattern matching = cleaner, more readable, and powerful C# code! 🚀
*/