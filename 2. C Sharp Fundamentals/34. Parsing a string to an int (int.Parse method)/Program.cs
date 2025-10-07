///
/// We will learn what parsing is.
/// 
/// We will also see how to convert a string to an int using the int.Parse method.
/// 
/// So far when we have been reading input from the console, we always assumed that the user provides a
/// string.
/// 
/// Let's now say that we want the user to provide an integer.
/// Console.ReadLine method return type is a string
/// So what we need to do is to somehow convert the string containing a number to an actual number.
/// 
/// In general a process of transforming a string into a different type,
/// a number, a boolean, a date, or anything else is called parsing.
/// 
/// To parse a string into an int, we can use the int.Parse method.
/// 
Console.WriteLine("Enter any number: ");
string input = Console.ReadLine();
int number = int.Parse(input);
/// 
/// This method takes a string as a parameter and passes it to an int.
/// 
/// 
/// 
///