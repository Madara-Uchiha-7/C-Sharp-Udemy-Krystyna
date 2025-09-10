// Sometimes we need the ability to cancel a task that is running.

// Lets consider NeverEndingMethod() while loop. Since the condition is true, it will never stop running.
// Of course, this example is a bit artificial, but you can think of it as just a task that runs for
// a very, very long time.
// The Task Parallel Library utilizes the concept of cooperative cancellation.
// It means that the code that requests the cancellation and the code executed within the canceled task
// must both cooperate to cancel this task.
// It is very simple if we use cancellation tokens.
// A cancellation token is an object shared by the code that requests the cancellation and the canceled task.
// The class that can provide us with such a token is called CancellationTokenSource.
// After user enters the cencel, we will stop the task using the Cancel() method.

// Cooperative cancellation happens when both the code that triggers the task and the code running within
// the task are aware of the cancellation, and they cooperate to perform it.
// For now, The task is requested to be canceled from the main thread. i.e. cts.Cancel(); after the while()
// For this we will modify the NeverendingMethod to accept a CancellationTokenSource.
// We will add it in parameter and argument. And we will use if condition : cancellationTokenSource.IsCancellationRequested

// So, we are passing CancellationTokenSource cts to NeverEndingMethod.
// When user types cancel, cts.Cancel(); will be trigger, which will set IsCancellationRequested to true.
// Since we are passing same cts object to the method NeverEndingMethod, condition cancellationTokenSource.IsCancellationRequested
// will return true and code will stop its flow.

// It may sometimes happen that the task cancellation is requested before the scheduler even starts the task execution.
// If we don't pass the cancellation token i.e. cts.Token to Run() , the task will start executing anyway, even if it was
// requested to be cancelled. It is simply a waste of resources if it was requested to be cancelled.
// So generally it is recommended to always pass this token to the method responsible for triggering the task.
// 

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
    while(true)
    {
        if (cancellationTokenSource.IsCancellationRequested)
        {
            return;
        }
        Console.WriteLine("Working...");
        Thread.Sleep(1500);
    }
}

// But as it turns out, canceling this method by simply using the return keyword is not the best idea.
// But to understand why, we must first understand the task lifecycle.
// Let's do it in the following lecture.