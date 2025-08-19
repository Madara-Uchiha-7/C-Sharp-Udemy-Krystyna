/// We know that we can wait till the task is completed.
/// We can also saw .Result property.
/// This works in synchronous way which blocks the main thread.
/// But we want to do other operations if Task is busy with its own implementation.
/// Continuation:
/// It is a function that will be executed after a task is completed.
/// 

Console.WriteLine("Main thread's ID " + Thread.CurrentThread.ManagedThreadId);

Task taskWithResult = Task.Run(() => CalculateLength("Hello there"))
    .ContinueWith(taskWithResult => 
    Console.WriteLine("Length is " + taskWithResult.Result));
/// Do not write 
/// Task<int> taskWithResult = ...
/// This will give the error. Because we are now printing the value using ContinueWith(),
/// not returning anything from it which we can do if we want to. 
/// Here, Task.Run() will create the task of int.
/// On the Task object we call ContinueWith().
/// To ContinueWith, as paramter we pass the lambda that describes what should 
/// happen once this task is completed.
/// This lambda takes this completed task i.e. taskWithResult, as a parameter.
/// ContinueWith() also returns the Task. Since our code in ContinueWith(), does not 
/// produce any result, it is the basic non-generic task and not the task of int.
/// So, we changed the Task<int> taskWithResult ... to Task taskWithResult ...
/// 

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
