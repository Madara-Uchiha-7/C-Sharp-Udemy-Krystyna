///
/// We will learn the most basic C# operators.
/// We will also discuss the operators precedence.
/// 
/// C# provides many built-in operators that allow us to perform basic operations on values.
/// So here, we have four basic arithmetic operators: 
/// + addition, - subtraction, * multiplication, and / division.
/// 
/// Interestingly, an operator can have a different behavior when used with different types.
/// For example, we can use the addition operator not only to add two numbers, but also to concatenate
/// strings.
/// 
int a = 10;
int b = 11;
Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b);
Console.WriteLine(a % b); // % is modulo operator. This gives us the remainder.
Console.WriteLine("jOHN" + "---" + "WOOO");


/// 
/// We can use the addition operator to concatenate a string with an int.
/// In this case, the result will be a string.
/// 
/// Operator - can not be applied with sting and int together.
/// 
/// In C# 
/// each operator has its precedence. In an expression with multiple operators
/// the operators with higher precedence are evaluated before the operators with lower precedence.
/// Operator precedence:
/// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/#operator-precedence
/// 
/// 
/// For now, it's enough to know that multiplication and division have higher precedence than addition
/// and subtraction.
/// 
/// It means in those expressions, those parts will be evaluated first.
/// The default he chain of operations is evaluated from left to right.
/// 
/// We can take control of the order of evaluation by adding parentheses where we need them.
/// 
/// Before we move on, let's mention that in C#, some operators require only one operand.
/// An example of such unary operators could be ++ and --operators which increment or
/// decrement a number by one.
/// ++variable/value;
/// --variable/value;
/// 
///