/// Sometimes we want to schedule a continuation for multiple tasks.
/// It will only be executed once all of those tasks will complete.
/// 

/// How to define the chain of continuations, that will all be executed one after another.
///
Console.WriteLine("Main thread's ID " + Thread.CurrentThread.ManagedThreadId);

Task<int>[] tasks = new[]
{
    Task.Run(() => CalculateLength("Hello there.")),
    Task.Run(() => CalculateLength("Hii.")),
    Task.Run(() => CalculateLength("Holaa")),
};


/// 1st parameter is the Array of Tasks that needs to be completed. (This has to be the Array, collection is not allowed.)
/// As a second parameter we pass a lambda, which takes the same collection of Tasks.
/// But when this lambda is triggered, those tasks will already be completed.
/// In this case, we join the result of all those tasks to a single string and print it to the console.
/// 
var continuationTask = Task.Factory.ContinueWhenAll(
    tasks,
    completedTasks => 
        Console.WriteLine(
            string.Join(
                ",", 
                completedTasks.Select(task => task.Result)
            )
        )
    );

string userInput;
do
{
    Console.WriteLine("Enter a command: ");
    userInput = Console.ReadLine();
} while (userInput != "exit");

Console.WriteLine("Program has ended.");
Console.ReadKey();


static int CalculateLength(string input)
{
    Console.WriteLine("CalculateLength thread's ID: " + Thread.CurrentThread.ManagedThreadId);
    Thread.Sleep(3000);

    return input.Length;
}
