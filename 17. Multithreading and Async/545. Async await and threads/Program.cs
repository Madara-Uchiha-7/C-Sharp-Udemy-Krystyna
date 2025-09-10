///
///
/// The line above the await keyword printed ID 1 which is the ID of the main thread.
/// The line after await printed ID which is not 1.
/// 
/// The .NET documentation clearly says the async and await keywords don't cause additional
/// threads to be created. But some other thread is used here,
/// so what is going on?
/// The explanation for that lies deep within the implementation
/// details of async and await.
/// 
/// Remember when we said that we can think of the code with the await keyword as a task and its continuation.
/// The thing we await is the task, and the code below is the continuation, which will only be triggered
/// once the task is completed.
/// for e.g. 
/// await Task.Delay(2000);   :: Is the task 
/// Console.WriteLine("HeavyCalculation thread ID: " + Thread.CurrentThread.ManagedThreadId); :: Is the continuation.
/// 
/// But the thing about continuations is that they don't necessarily execute on the same thread as the task
/// that precedes them. When a continuation is scheduled to be run, a thread pool is involved, and in simple terms, we ask
/// it to give us any thread that can run this continuation.
/// 
/// So remember, the async and await mechanism does not create any new threads.
/// It does utilize the thread pool though, which may decide to use more threads than one.
/// If we want to use more worker threads in our app, we must still create them explicitly.
/// For example, by using the Task.Run method.
/// 
///
///

Console.WriteLine("Main thread ID: " + Thread.CurrentThread.ManagedThreadId);

Task task = RunHeavyProcess();

Console.WriteLine("Doing other work!!");
Console.WriteLine("Done doing other work!!");

Console.ReadKey();

static async Task RunHeavyProcess()
{
    Console.WriteLine("RunHeavyProcess thread ID: " + Thread.CurrentThread.ManagedThreadId);
    Console.WriteLine();
    string result = await HeavyCalculation();
    Console.WriteLine(result);
}

static async Task<string> HeavyCalculation()
{
    Console.WriteLine("HeavyCalculation thread ID: " + Thread.CurrentThread.ManagedThreadId);
    Console.WriteLine("Starting heavy calculation.");
    // Thread.Sleep(2000);
    await Task.Delay(2000);
    Console.WriteLine("HeavyCalculation thread ID: " + Thread.CurrentThread.ManagedThreadId);
    return "Done!";
}



/// Note:
/// Writing imp things from next lecture here.
/// Most often we use the await keyword with async methods, which return tasks as results, but we can
/// also apply it to the task created with Task.Run method or in any other way.
/// For e.g.
/// int result = await Task.Run(() => 5);
/// In this example, we clearly see that even though Task.R creates a task of int, applying
/// the await keyword extracts this int result from the task. That's why the result variable is of int type.
/// 
/// Don't get tricked by the deceptive similarity of using the await keyword and the Wait method.
/// int result = await someTask() 
/// and 
/// task.Wait()
/// int result = tas.Result;
/// 
/// Calling the Wait method, as well as using the Result property are blocking operations, and they will
/// stop the program while waiting for the result to be ready.
/// 
/// They will not perform the same magic as await does,
/// so going back to the caller method and returning only after the result is ready.
/// 
/// If method is asynchronous, they must always return a task.
/// Except for rare situations when they return void. But this is used only with specific .NET frameworks.
/// 
/// For async methods not returning anything, non-generic tasks will be created and returned.
/// 
/// 
/// We can also easily use the asynchronous methods in a synchronous way.
/// We must simply call the Wait method on them or access the Result property.
/// static void Main()
/// {
///     SomeAsyncMethod().Wait();
/// }
/// 
/// Usign Async and await will not cause any operations to run in parallel.
/// If we want parallel execution, we must write such code explicitly.
/// For example, by starting multiple tasks with the Task.Run method.
/// 
/// 
///