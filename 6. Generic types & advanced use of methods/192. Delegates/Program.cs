///
/// We will also understand the difference between delegates and Funcs or Actions.
/// Additionally, we will see an example of a multicast delegate. In C#,
/// 
string TrimTo5Letters(string input)
{
    return input.Substring(0, 5);
}
string ToUpper(string input)
{
    return input.ToUpper();
}

ProcessString processStringTrim = TrimTo5Letters;
ProcessString processStringUpper = ToUpper;

Console.WriteLine(processStringUpper("hellowww"));
Console.WriteLine(processStringTrim("hiiiiiiihihihih"));

Print print1 = text => Console.WriteLine(text.ToUpper());
Print print2 = text => Console.WriteLine(text.ToLower());
Print multicast = print1 + print2;
multicast("Crocodile");

Print print4 = text => Console.WriteLine(text.Substring(0, 3));
multicast += print4;
multicast("Crocodile");

Console.ReadKey();

/// In C# we can declare several kinds of types.
/// We can declare a class or a struct to represent data and methods.
/// We can declare enums to represent some predefined discrete values, and we can also declare delegates.
/// 
/// 
/// A delegate is a type whose instances hold a reference to a method with particular parameters and return
/// type.
/// 
delegate string ProcessString(string input);
/// 
/// We declare delegates with the delegate keyword.
/// Besides the delegate keyword, a delegate declaration looks the same as a method declaration.
/// First the return type, then the name, and finally the list of parameters.
/// We defined a delegate type, and any variable of this type can be assigned a method that takes a string
/// as parameter and also returns a string.
/// For e.g. TrimTo5Letters and ToUpper functions can be assigned to the variable of the ProcessString delegate type.
/// Check line:
/// ProcessString processStringTrim = TrimTo5Letters;
/// ProcessString processStringUpper = ToUpper;
/// 
/// We can now call the delegates and as a result, execute the functions that are stored in them.
/// Check:
/// Console.WriteLine(processStringUpper("hellowww"));
/// Console.WriteLine(processStringTrim("hiiiiiiihihihih"));
/// 
/// The interesting feature of delegates is that we can store more than one function in one variable of
/// delegate type.
/// Check code:
/// Print print1 = text => Console.WriteLine(text.ToUpper());
/// Print print2 = text => Console.WriteLine(text.ToLower());
/// Print multicast = print1 + print2;
/// multicast("Crocodile");
/// As you can see, the multicast variable holds references to two functions, not one.
/// 
/// 
delegate void Print(string input);
///
///
/// We can also use the plus equals operator to chain another method to a delegate variable.
/// Check:
/// Print print4 = text => Console.WriteLine(text.Substring(0, 3));
/// multicast += print4;
/// multicast("Crocodile");
/// 
/// A delegate variable that holds references to more than one function is called a multicast delegate.
/// 
/// In the previous lecture we learned about Func and Action types.
/// What is interesting, both are simply generic delegates:
/// Func<string, string, int> sumLetters = (text1, text2) => text1.Length + text2.Length; 
/// Of course, instead of a lambda expression, we can also assign a pre-existing function to a variable
/// of Func type as we can do with any delegate.
/// 
/// So we know that Funcs and Actions are generic delegates.
/// 
/// We don't really need to define ProcessString delegate.
/// i.e. instead of:
/// ProcessString processStringTrim = TrimTo5Letters;
/// we can do:
/// Func<string, string> processStringTrim = TrimTo5Letters;
/// 
/// So why bother declaring delegates if we can use Funcs instead?
/// Well, first of all, delegates existed in C# before Funcs, Actions and lambda expressions.
/// There was a time when they were simply the only way to represent functions as objects.
/// So you can still see some old code full of custom delegates instead of Funcs and Actions for the simple
/// reason that it was created a long time ago.
/// Nowadays, from my practice, I would say that in 99% of the cases there is no point in declaring custom
/// delegates and Funcs can be used instead.
/// 
/// 
///
