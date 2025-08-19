Console.WriteLine("Main thread's ID " + Thread.CurrentThread.ManagedThreadId);
Task<int> taskWithResult = Task.Run(() => CalculateLength("Hello there"));
Console.WriteLine("taskWithResult Result is: " + taskWithResult.Result);

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
    Thread.Sleep(2000);

    return input.Length;
}
Console.ReadKey();
