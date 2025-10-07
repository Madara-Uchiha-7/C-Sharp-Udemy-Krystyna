
///
/// We will learn how to parse a string to an int without the risk of a runtime error.
/// We will also see a handy keyboard shortcut for formatting the code.
/// 
/// Unlike Parse , TryPrase doesn't return an integer.
/// It returns a bool saying if the parsing was successful or not.
/// But if parsing was successful, it must also return the parsed integer.
/// As we learned before, a method cannot return two results.
/// That's why the creators of the TryParse method decided to return the second piece of result as the out
/// parameter.
/// Please notice that if the parsing is not successful, the number variable will be set to the default
/// value for integers, which is zero.
/// Let's see this in practice.
/// 
Console.WriteLine("Enter the number: ");
string userInputnumber = Console.ReadLine();

bool isInteger = int.TryParse(userInputnumber, out int number);

if (isInteger)
{
    Console.WriteLine(number);
}
/// 
///
/// 
/// If the formatting of your code gets a bit messed up, 
/// You can format it automatically by pressing the Ctrl+K+D shortcut.
///