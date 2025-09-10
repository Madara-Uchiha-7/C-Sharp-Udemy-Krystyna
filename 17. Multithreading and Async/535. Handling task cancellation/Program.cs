/// 
/// Let's now understand how to handle task cancellation.
/// Now when we understand how exceptions are managed in the task parallel library.
/// Let's revisit the topic of cancellations.
/// The task runs a method that will never end, but we want to give the user of this app the ability to
/// cancel this task.
/// 
/// That's why we pass the cancellation token to the Task Run method.
/// After the user enters "cancel" to the console, we call the Cancel method on the CancellationTokenSource.
/// 
/// Because the TPL uses the concept of cooperative cancellation, the method run within the task must also
/// be able to handle this cancellation.
/// 
/// In each iteration of this loop, we call the ThrowIfCancellationRequested method.
/// If the cancellation was requested, this method will throw the OperationCanceledException.
/// 
/// So NeverEndingMethod will throw the OperationCanceledException after the user entered "cancel" to the console.
/// 
/// But we learned that exceptions thrown within tasks make the whole task faulted.
/// If we wait for this task completion, those exceptions will be propagated to the thread that created
/// this Task.
/// And if unhandled on this thread, they will crash the application.
/// 
/// But what is important to understand is that the OperationCanceledException is handled behind the
/// scenes.
/// 
/// It doesn't make this task Faulted but Cancelled.
/// 
/// Because it is handled, it will not be propagated to the thread that created the task
/// even if we wait for the task completion.
/// 
/// But what if we want to perform some action if the task was canceled?
/// 
/// Well, it will be very simple if we remember about
/// the TaskContinuationOption enum.
/// 
/// You need to write:
/// Task task = Task.Run(() => NeverEndingMethod(cts), cts.Token).ContinueWith(canceledTask => 
/// Console.WriteLine($"Task with ID: {canceledTask.Id} has been canceled."), TaskContinuationOptions.OnlyOnCanceled);
/// instead of:
/// Task task = Task.Run(() => NeverEndingMethod(cts), cts.Token);
/// 

Console.WriteLine("Main thread ID: " + Thread.CurrentThread.ManagedThreadId);

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
            return;
        }
        Console.WriteLine("Working...");
        Thread.Sleep(1500);
    }
}
