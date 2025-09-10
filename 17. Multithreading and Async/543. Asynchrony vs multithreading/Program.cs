/// In this lecture, we will revisit the topic of the difference between asynchrony and multithreading.
/// 
/// We will also learn the purpose of the Task.Delay method.
/// 
/// Remember when we discussed how the await keyword changes the program flow?
/// We said that once this keyword is reached, the flow goes back to the caller method and only continues
/// the code after the await keyword once the task is completed.
/// 
/// So it seems that using the await keyword does not necessarily mean that more than one thread will be
/// involved.
/// 
/// The flow jumps between different places in the code, but still only one thing happens at the time.
/// Nothing needs to be executed in parallel.
/// 
/// Of course, the calculation itself may spawn a new thread, but this is not obligatory.
/// 
/// It may, for example, only wait for a given time.
/// This doesn't need a new thread.
/// 
/// We will get a notification from the operation system once the given time has passed.
/// A similar case is waiting for some server's response.
/// This also doesn't need a new thread.
/// It's just a matter of receiving a notification that the response is ready.
/// 
/// To see what threads are created in our program, we will add printing of thread IDs.
/// You will see the program is using only one thread: 
/// Output when I ran this code:
/// Main thread ID: 1
/// RunHeavyProcess thread ID: 1
/// HeavyCalculation thread ID: 1
///
/// We said earlier in the course that asynchrony and multithreading are not necessarily used together.
/// Threading is about having multiple workers.
/// Asynchrony is about having tasks that may be processed independently of the main program flow.
/// 
/// And this can explain why this program doesn't behave as we wanted it to.
/// Notice this suspicious little line:
/// Thread.Sleep(2000);
/// The Thread.Sleep method stops the current thread for a given number of milliseconds.
/// But there is only one thread here and it will be stopped.
/// This only thread is the main thread.
/// The fix is quite simple.
/// Instead of calling Thread.Sleep, we will call Task.Delay.
/// But this caused a warning:
/// Because this call is not awaited execution of the current method continues before the call is completed.
/// We saw this warning before, but in this case it's more appropriate.
/// The Task.Delay method creates and starts a task that will be completed after a given time.
/// But remember, creating and starting the task does not mean waiting for it.
/// Here we only started this task, but then we move on to the next line.
/// So there is not really any waiting as there was with the Thread.Sleep method.
/// Luckily, we already know the keyword that allows us to wait for task completion.
/// The await keyword.
/// And this is just the keyword that the warning suggested us to use.
/// So, we will make
/// "Task.Delay(2000)" to "await Task.Delay(2000)" 
/// and will use this instead of Thread.Sleep(2000);
/// 
/// Now, once we reached Task.Delay's await keyword, the execution will go back to the caller, which is
/// the RunHeavyProcess method.
/// However, since this method awaits the completion of the HeavyCalculation task, the flow will go back
/// even further all the way to the Main method.
/// 
/// This means main lines of code will be processed while we wait for the heavy calculation to complete.
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
    return "Done!";
}