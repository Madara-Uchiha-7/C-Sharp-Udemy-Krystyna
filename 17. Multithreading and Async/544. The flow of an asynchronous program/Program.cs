///
/// In this video, we will trace the flow of an asynchronous program step-by-step to understand better
/// how the await keyword works.

/// Flow for the below code:
/// 1. It will start at 1st : Console.WriteLine
/// 2. Task task = RunHeavyProcess();
/// 3. Console.WriteLine("RunHeavyProcess
/// 5. await HeavyCalculation();
/// 6. Console.WriteLine("HeavyCalculation th
/// 7. Console.WriteLine("Starting heavy
/// 
/// After 5 it will not directly fo at : Console.WriteLine("Doing
/// because HeavyCalculation() has 2 Console.WriteLines
/// which are not the tasks, so it will be executed synchronously.
/// Once the code reaches Delay() which is a task then control will go to : await HeavyCalculation()
/// but it is also in await state i.e. in wating state, so compiler can not run Console.WriteLine(result);
/// So control will go to Task task = RunHeavyProcess(); and 
/// then flow will go to : Console.WriteLine("Doing other work!!");
/// 
/// 8. await Task.Delay(2000);
/// 9. Console.WriteLine("Doing
/// 10. Console.WriteLine("Done doing
/// 11. return "Done!";
/// 12. Console.WriteLine(result);
/// 13. Console.ReadKey(); 
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
    return "Done!";
}



// So remember, if we use the await keyword, we will go back to the caller method while waiting for the
// completion of the awaited task.
// Of course, the caller method can also await something, and in this case, we'll go back even further.
// This way the program can continue even when waiting for some tasks to be finished.