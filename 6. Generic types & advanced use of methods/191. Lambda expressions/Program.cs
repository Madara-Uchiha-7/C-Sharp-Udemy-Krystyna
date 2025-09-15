// 11:22



using System;

///
/// In last example we used IsLargerThan10 and IsEven.
/// We not likely to reuse them anywhere else.
/// 
/// Imagine you have a class that does plenty of very specific checks on collections, like checking if
/// any number is divisible by five, if any string is longer than ten letters or if any person is named
/// John.
/// 
/// We would clutter our class with tiny simple methods that check those things and are not used anywhere
/// That's not a good approach.
/// 
/// It would be better if we could have an easy short way of defining small, simple, and specific functions.
/// And that's exactly what lambda expressions are for.
/// 
/// Lambda expression is a special way of defining anonymous function.
/// param => expression 
/// This is the general pattern of any lambda expression: on the left side of the arrow
/// we declare a parameter or parameters of the function.
/// On the right side, we declare the expression whose result will be returned from this function.
/// 
/// We can also have lambda expressions with more than one parameter.
/// (p1, p2) => expression
/// In this case, we must put parameters in parentheses.
/// 
/// If there are no parameters at all, we can define the lambda like this.
/// () => expression
/// 
/// This is much shorter than the traditional way of declaring functions.
/// There is no return keyword, as it is simply assumed that the result calculated on the right side is returned.
/// 
/// The result type is not declared because it is inferred from what the expression evaluates to.
/// 
/// For example, in this lambda expression, it is obvious that the return type of this function is string.
/// param => "Hello"
/// 
/// If on the right side we have a statement, not an expression, then it is simply assumed that the function
/// defined with lambda is void.
/// e.g. 
/// () => statement
/// 
/// Remember, expression evaluates to a value, but a statement does not.
/// e.g. Here Console.WriteLine() is a statement.
/// () => Console.WriteLine()
/// 
/// The types of parameters are also not formally defined.
/// So how does the compiler know what they are?
/// Well, it also infers them from the context.
/// The IsAny method expects a very particular function as the parameter, a function that takes a number
/// and returns a bool.
/// Because we use the lambda expression as the parameter of the IsAny method, the compiler infers that
/// the parameter of the lambda expression must be an integer because there is a method expects such a function
/// as the parameter.
/// This is also the reason why we can't assign lambda expressions to implicitly typed variables.
/// e.g. Below will not work. Because there is no context from which the compiler can infer the
/// type of the parameter.
/// var someFunc = n => n % 2 == 0;
/// 
/// You may say that lambda expressions require a lot of assumptions and inferring, but see how little
/// code we needed to write to declare a function, checking if a number is even.
/// 
/// Lambda expressions are great when declaring short, specific functions that will most likely not be used
/// in any other context.
/// 
/// For example, they are extremely often used when working with LINQ.
/// Actually, the IsAny method we declared is almost identical to the Any method from LINQ.
/// 
/// Summary:
/// In C# we can treat functions like any other types, assign them to variables or pass them as parameters
/// to other functions.
/// The Func and Action types allow us to represent functions.
/// Lambda expressions are a special way of declaring anonymous functions.
/// They allow us to define functions in a concise way and are most useful when those functions will not
/// be used in a different context.
/// 
///


var numbers = new[] { 1, 2, 3, 4, 5, 6, };
IsAny(numbers, n => n > 10);
IsAny(numbers, n => n % 2 == 0);

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
