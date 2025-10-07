///
/// The break keyword immediately stops the execution of the loop, even if otherwise it should be continued.
/// 
/// --------------------
/// 52. Continue
/// It works a bit similarly to the break keyword, but instead of breaking the loop altogether, it breaks
/// the current iteration of the loop and goes straight to the next iteration.
/// e.g. of .All and char.IsDigit
/// We want to check if user has entered the digit or not.
Console.WriteLine("Enter the number: ");
string number = Console.ReadLine();

if (number.All(char.IsDigit))
{
    Console.WriteLine("Input given by user is number.");
}
/// 
/// All is a method called upon a string variable which checks if all the characters in the string meet
/// a certain condition.
/// In our case, we define this condition by using the IsDigit method from the char type.
/// Later in the course, we will learn more about LINQ, the library from which the All method comes from,
/// 
/// 
/// -------------------------------
/// 54. Loops performance
/// 
/// Firstly, what is the performance of a program?
/// It is a measure of how fast the program is executed and how much resources, for example, memory it
/// consumes.
/// 
/// We, the programmers, are responsible for the performance of the programs we write.
/// Achieving great performance is a complex task and there is no universal solution for it.
/// 
/// 
/// We should avoid nested loops in general, especially loops nested more than two times.
/// It's not always possible.
/// 
/// It's sometimes possible to break the execution of the loop early.
/// If, for example, we use the loop to find some element in a collection, then once we find it, we
/// can break the loop.
/// There is no point in checking the whole collection if we are lucky to find what we are looking for at
/// its beginning.
/// 
/// Another piece of advice regarding nested loops is to try to move the performance-heavy code outside
/// of them, or at least to the outer loops.
/// 
/// 
///