Console.WriteLine("Main thread's ID " + Thread.CurrentThread.ManagedThreadId);

/// Instead of using the .Result we can use wait()
/// It is perticularly useful when working with tasks, that do not product result
/// as such tasks do not have the .Result property atall.
/// For e.g.
/// 
Task task = Task.Run(() =>
{
    Thread.Sleep(1000);
    Console.WriteLine("Task is finished.");
});
/// You will see this getting printed first before the above line:
/// Console.WriteLine("Task is finished.");
/// This means task runs on the different thread.
Console.WriteLine("After the task.");
/// But if you use the wait() which will pause the main thread.
/// Syntax: 
/// task.wait(); 
/// Add this above code to above line : Console.WriteLine("After the task.");
/// End of e.g.
/// We can use wait() for any task, not only non-generic.
/// Sometimes we want to wait till multiple tasks are finished.
/// In that case we can use task.WaitAll()
/// Syntax: Task.WaitAll(TaskObject1,TaskObject2,...,TaskObjectN);


Task<int> taskWithResult = Task.Run(() => CalculateLength("Hello there"));
Console.WriteLine("taskWithResult Result is: " + taskWithResult.Result);
Console.WriteLine("Program has ended.");
Console.ReadKey();

static int CalculateLength(string input)
{
    Console.WriteLine("CalculateLength thread's ID: " + Thread.CurrentThread.ManagedThreadId);
    Thread.Sleep(2000);

    return input.Length;
}
