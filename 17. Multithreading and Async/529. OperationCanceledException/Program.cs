
using System;

/// We will learn the typical way of concealing tasks as well as the role of
/// the OperationCancelledException.
/// 
/// Set up a breakpoint here after the task cancellation.
/// That is, Console.WriteLine("Program is finished.");
/// Type cancel, to stop the task.
/// But it says the task is running if you check using debug mode, but this is actually a bit misleading.
/// Most likely the status of the task did not have enough time to be updated.
/// If you add Thread.Sleep command one line above to give this task a bit more time.
/// I.e. if you add Thread.Sleep(2000); above the:
/// Console.WriteLine("Program is finished.");
/// And then if you check the status then we see that the status of this task is updated and it is RanToCompletion.
/// 
/// But as we learned before, if a task is cancelled, its status should be set to Cancelled.
/// That's why instead of simply ending the method using the retun statement 
/// like we did in NeverEndingMethod(), we should throw a special exception here.
/// The OperationCancelledException.
/// 
///

Console.WriteLine("Main thread ID: " + Thread.CurrentThread.ManagedThreadId);

// Below is cancellation token.
// We need to pass it to Task.Run()
CancellationTokenSource cts = new CancellationTokenSource();

Task task = Task.Run(() => NeverEndingMethod(cts), cts.Token);

string userInput = Console.ReadLine();
do
{
    userInput = Console.ReadLine();
}
while (userInput != "cancel");
cts.Cancel();

Console.WriteLine("Program is finished.");
Console.ReadKey();

static void NeverEndingMethod(CancellationTokenSource cancellationTokenSource)
{
    while (true)
    {
        if (cancellationTokenSource.IsCancellationRequested)
        {
            // You should write below line instead of writing the return.
            // Uncomment below line and then after writing the cancel, the error will come
            // on this line since we are throwing the error. Press continue and then 
            // code will stop at the : Console.WriteLine("Program is finished.");
            // Check the status of task, the task status is properly changed to Cancelled.
            // throw new OperationCanceledException(cancellationTokenSource.Token);

            return;
        }


        // Instead of above if, we can do the same thing using:
        // cancellationTokenSource.Token.ThrowIfCancellationRequested();
 


        Console.WriteLine("Working...");
        Thread.Sleep(1500);
    }
}

// By the way, please notice an interesting thing.
// Even though this method has thrown an exception,
// Because of  : throw new OperationCanceledException(cancellationTokenSource.Token);  
// or
// cancellationTokenSource.Token.ThrowIfCancellationRequested();
// the program flow was not interrupted.

// Lets check next lecture to find out why?