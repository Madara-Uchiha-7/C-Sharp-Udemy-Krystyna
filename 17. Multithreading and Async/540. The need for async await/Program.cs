/// The topic of async and await is crucial but often considered challenging.
/// 
/// Let's say we want to write a program whose job will be to do the following.
/// First, it will call a method that typically takes a lot of time.
/// Then we want to process the result of this method, which can also take some time.
/// Finally, we want to print a message saying that this flow is finished.
///
///

/// Synchronous approach:
/// Commented below code so that Async code can run.
/*int result = CalculateLength("Chinmay");
Print(result);
Console.WriteLine("The process is complete.");
*/
/// However, this synchronous approach may be undesired.
/// The method calls in this program are blocking operations and while they execute, the main thread can't continue.
/// For example, if we want to allow the user to interact with this app by entering some commands to the console:
///
/*Console.WriteLine("Taking User input.");
string userInput;
do
{
    userInput = Console.ReadLine();
} while (userInput != "stop");
Console.WriteLine("Done taking the User input.");
*/
/// The problem is, with the current synchronous approach will not reach this loop until the code above is
/// finished.
/// The reason is that the processing of user input is done on the main thread, and it is blocked by other
/// operations.
/// When we think about it, it is not only inconvenient, but it also doesn't make sense.
/// This code with the loop has nothing to do with the code calculating and printing the result.
/// We need to use asynchronous programming. 
/// To achieve it
/// we will create a task running the calculation.
/// We will also use continuations to schedule what should happen after the calculation is finished.
///
///
Task task = Task.Run(() => CalculateLength("Hello"))
    .ContinueWith(completedTask => Print(completedTask.Result))
    .ContinueWith(previousContinuation => Console.WriteLine("The process is complete."));

/// Now below code will work parallay with above code.
/// 
Console.WriteLine("Taking User input.");
string userInput;
do
{
    userInput = Console.ReadLine();
} while (userInput != "stop");
Console.WriteLine("Done taking the User input.");

///
/// But here is the problem.
/// This code is just awkward.
/// We have a chain of calls of ContinueWith methods.
/// We have a lot of lambdas.
/// It looks nothing like the nice, clear synchronous code we had before.
/// This ideally shouldn't be the case.
/// It would be much better if we could write asynchronous code, but in a way that makes it similar to
/// the synchronous one.
/// Also, it would be great to easily switch between synchronous and asynchronous ways of executing.
/// .NET creators noticed this need too.
/// They wanted to introduce a simple mechanism that would allow us to write asynchronous code that looks
/// almost the same as the plain, simple synchronous code we are used to.
/// They came up with the async/await pattern, which revolutionized how we write asynchronous code.
///



Console.ReadKey();
static int CalculateLength(string input)
{
    Console.WriteLine("Starting the calculation.");
    Thread.Sleep(2000);
    return input.Length;
}

static void Print(int result)
{
    Console.WriteLine("Starting the Print Method.");
    Thread.Sleep(2000);
    Console.WriteLine("The result is " + result);
}
