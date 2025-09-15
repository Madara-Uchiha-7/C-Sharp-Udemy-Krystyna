///
///
/// We're going to learn how we can assign methods to variables.
/// We will understand what Funcs and Actions are and what their purpose is.
/// We'll also see how they can help us reduce the code repetitions.
///
/// The problem is that IsAnyEvenNumber method is almost the same as the IsAnyLargerThan10.
/// The only place in which they differ is this.
/// (number > 10) and (number % 2 == 0)
/// So if I wanted to refactor those two methods into one, I would need to make this part a parameter.
/// But what is this part exactly?
/// At first glance you may think it's a boolean, but that's not correct.
/// I couldn't pass this boolean to those methods as it may differ for each of the elements of the numbers
/// collection.
/// So it's not a boolean. It's a function that takes a number and returns a boolean.
/// If I wanted to refactor those methods and make them a single method, it would need to take a function
/// as a parameter.
/// And for this we can use the Func type.
/// Check IsAny()
/// Func<int, bool> predicate can be assigned any function that is taking a number and returning a bool.
/// As you can see, Func is generic, and by type parameters we define what is the return type of the function
/// and what parameters it takes. 
/// Generic means Parameterized by type (using < > breackets)
/// The last type parameter is always the return type, and everything preceding it are the types of parameters.
/// So, bool will be the return type here.
/// For e.g.
Func<int, DateTime, string, decimal> someFunc;
///  this variable can be assigned any function that takes an int, DateTime and string parameters
///  and returns a decimal.
///  For void functions, we must use Action type.
Action<string, string, bool> someAction;
/// This variable can represent any void function taking two strings and a bool.
/// 
/// Now, we want to have a single IsAny method, taking a collection of numbers and a function that defines the predicate
/// that will be checked.
/// Now instead of using "number is larger than 10" or "number is even", we will simply use the predicate.
/// Check the if condition in IsAny()
/// i.e. if (predicate(number))
/// As you can see, we can call the Func object like another method.
/// Now, to make this method work, lets define the IsLargerThan10 and IsEven methods.
/// Now, we can use those methods as parameters of the IsAny method.
Func<int, bool> predicate1 = IsLargerThan10;
Func<int, bool> predicate2 = IsEven;
/// 
/// Lets call the IsAny()
var numbers = new[] { 1, 2, 3, 4, 5, 6, };
IsAny(numbers, predicate1);
IsAny(numbers, predicate2);
/// 
/// We can of course skip declaring variables and simply pass the methods as parameters.
/// E.g.
/// IsAny(numbers, IsLargerThan10); instead of IsAny(numbers, predicate1);
/// IsAny(numbers, IsEven); instead of IsAny(numbers, predicate2);
/// 
///

bool IsAnyLargerThan10(IEnumerable<int> numbers)
{
    foreach (var number in numbers)
    {
        if (number > 10)
        {
            return true;
        }
    }
    return false;
}
bool IsAnyEvenNumber(IEnumerable<int> numbers)
{
    foreach (var number in numbers)
    {
        if (number % 2 == 0)
        {
            return true;
        }
    }
    return false;
}


bool IsLargerThan10(int number)
{
    return number > 10;
}
bool IsEven(int number)
{
   return (number % 2 == 0);
}

bool IsAny(IEnumerable<int> numbers, Func<int, bool> predicate)
{
    foreach (var number in numbers)
    {
        if (predicate(number))
        {
            return true;
        }
    }
    return false;
}
