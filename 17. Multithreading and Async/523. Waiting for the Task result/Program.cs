/// Lets say you want to wait becuase you want to use the integer which is in the
/// taskWithResult. 
/// We can do this by :- taskWithResult.Result 

Console.WriteLine("Main thread's ID " + Thread.CurrentThread.ManagedThreadId);
Task<int> taskWithResult = Task.Run(() => CalculateLength("Hello there"));
Console.WriteLine("taskWithResult Result is: " + taskWithResult.Result);
// As you can see program willl take some time to get the result due to our sleep.
// using this .Result we can get the value which is returned by the function.
// But the issue of this .Result is, it holds the running of the main thread.
// This means we lose the benifits of Async Programming.
// For e.g. 
// If you add below code, it will not work till .Result gets calculate :
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
