/// How to define the chain of continuations, that will all be executed one after another.
///
Console.WriteLine("Main thread's ID " + Thread.CurrentThread.ManagedThreadId);

Task taskWithResult = Task.Run(() => CalculateLength("Hello there"))
    .ContinueWith(taskWithResult =>
    Console.WriteLine("Length is " + taskWithResult.Result))
    .ContinueWith(taskWithResult =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("The second continuation.");
    });


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
