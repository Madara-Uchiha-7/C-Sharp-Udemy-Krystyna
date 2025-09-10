/// Lets refactor the code in 540 using async and await.

// Old code:
/*
Task task = Task.Run(() => CalculateLength("Hello"))
    .ContinueWith(completedTask => Print(completedTask.Result))
    .ContinueWith(previousContinuation => Console.WriteLine("The process is complete."));


Console.WriteLine("Taking User input.");
string userInput;
do
{
    userInput = Console.ReadLine();
} while (userInput != "stop");
Console.WriteLine("Done taking the User input.");


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
*/
/// ---------------------------------------------------------------------------------------------------------------------------
/// Refactored code:
///
// We will move below to another method.
//Task task = Task.Run(() => CalculateLength("Hello"))
//    .ContinueWith(completedTask => Print(completedTask.Result))
//    .ContinueWith(previousContinuation => Console.WriteLine("The process is complete."));
// Also we will convert above into async and await after moving them into the method. 

// We will make CalculateLength() and Print() async.
// because if we try to await results of methods that do not produce tasks, we will get compilation error
// at the location from where we are calling them.
// Also we will change the return type of CalculateLength() to Task<int> instead of int.
// and PrintAsync() methods Task from void.

// It is conventional to add the async postfix to the names of async methods.

// The last change will be to use and await the Task.Delay method instead of using Thread.Sleep

var task = ProcessAsync("Hello");


static async Task ProcessAsync(string input)
{
    var length = await CalculateLengthAsync(input);
    await PrintAsync(length);
    Console.WriteLine("The process is complete.");
}


Console.WriteLine("Taking User input.");
string userInput;
do
{
    userInput = Console.ReadLine();
} while (userInput != "stop");
Console.WriteLine("Done taking the User input.");


Console.ReadKey();
static async Task<int> CalculateLengthAsync(string input)
{
    Console.WriteLine("Starting the calculation.");
    await Task.Delay(2000);
    return input.Length;
}

static async Task PrintAsync(int result)
{
    Console.WriteLine("Starting the Print Method.");
    await Task.Delay(2000);
    Console.WriteLine("The result is " + result);
}

///
/// We moved the code with the task and its continuations to the Process method.
/// Let's think what would happen if I didn't do it?
/// If we did not keep it in the method and keep it outside i.e. automatically in the Main method,
/// then it will compile fine, but it will not work as expected.
/// The reason for that : the code after await keyword will not be processed until the awaited task is completed.
/// And this is why we don't reach the loop processing the input sooner.
/// The easiest way around it is to have this code in a separate method which is not awaited.
/// 
/// Please not that we did not await the ProcessAsync("Hello");
/// So it starts executing, but when the first await keyword in the process method is reached, the flow goes back to the Main method
/// and we soon reach the loop processing the input.
///