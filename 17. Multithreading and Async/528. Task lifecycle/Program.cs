// Let's now understand the life cycle of a task and how we can check the task's current status.
// We will also see what child tasks are.
// Finally, we will learn about the Task.FromResult method.

// Place a breakpoint right after we create and start a task and rerun the app.
// I.e. on the line of do while.
// Place it at do. 
// Select and right click the task and check the properties.
// First, we see that each task has an ID that uniquely identifies it.
// Please notice that it is not the same as the thread ID.
// And here Currently the status of this task is Running.
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

// The first status for most tasks is Created.
// It will not be updated until the task is scheduled.
// The next one is WaitingForActivation.
// This is the starting status for tasks created through methods like ContinueWith.
// It means the task waits to be scheduled after some other operation is completed.
// Once a task is scheduled, whether because it's a continuation of an operation that is already finished,
// or simply because the Start method has been called on it, its status changes to WaitingToRun.
// The task is ready to be started, and it's waiting for the scheduler to pick it up and run it.
// After this happens, the status of the task changes to Running.
// This state lasts until the task is completed.

// To understand the next status, we must grasp the concept of child tasks.
// A child's task or nested task is a task that is created in the code executed by another task, which
// is known as the parent task.
// for e.g.

Task parent = Task.Run(() =>
{
    Console.WriteLine("Parent task is executing.");

    Task child = Task.Run(() =>
    {
        Console.WriteLine("Child task is executing");
    });
});

// Child tasks are associated with their parent task in terms of execution,
// lifetime, and error propagation.
// They inherit certain properties or behaviors from the parent task.
// I mentioned this to make yet another task status clear.
// WaitingForChildrenToComplete.
// If a task has child tasks, it may need to wait till all of them are completed and this is when its
// status is WaitingForChildrenToComplete.
// 
// Finally, the task life cycle ends and it can end in one of three states.
// If everything goes well, the task status will be RanToCompletion.
// If the task has been cancelled before it can be completed, its status will be set to Cancelled.
// Lastly, if there was some error during the task execution, its status will be set to Faulted.

// There is one exceptional kind of task.
// Sometimes we create a task from a result like this.
Task<int> taskFromResult = Task.FromResult(10);
// Such a task has no code to execute, and from the very moment we create it, its status is already set
// to RanToCompletion and it carries the result we gave it.
// Creating tasks this way seems to not make much sense, but it is useful sometimes, especially in unit
// testing.
// For testing purposes, we may need a task object carrying a result, but we don't want to set up its calculation.
// This is what we can use the Task.FromResult method.