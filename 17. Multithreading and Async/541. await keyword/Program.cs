/// Lets look at the simple example first.
/// 

Task task = RunHeavyProcess();

Console.WriteLine("Doing other work!!");
Console.WriteLine("Done doing other work!!");

Console.ReadKey();

static Task RunHeavyProcess()
{
    /// Below part which is cumbersome.
    /// We would rather make it similar to plain synchronous code, but without losing the benefits of asynchronous
    return Task.Run(() => HeavyCalculation())
        .ContinueWith(completedTask => Console.WriteLine(completedTask.Result));
}
static string HeavyCalculation()
{
    Console.WriteLine("Starting heavy calculation.");
    Thread.Sleep(2000);
    return "Done!";
}

/// Change in above code in Async await style:
/// First of all, we would get rid of the calls to the Task.Run
/// and ContinueWith methods.
/// await:
/// Run HeavyCalculation()
/// but dont wait and
/// go where this method is called and run remaining calculations.
/// Also don't process the line after the await keyword before the result is ready because that
/// line needs this result to be calculated so logically, it can only be executed after the HeavyCalculation
/// method is complete.
/// This can be done by adding the await keyword.
/// 
/// Let's say the HeavyCalculation method is completed just after we printed "Doing other work" to the console.
/// At this moment, the program flow will go back to the RunHeaveyProcess method and specifically to the
/// line after the await keyword.
/// Since now the HeavyCalculation method is done, the result is ready and we can print it.
/// At this point, the execution of the RunHeaveyProcess method is done.
/// The program flow will go back to where we were.
/// So just after printing "Doing other work".
/// The program will then continue as usual.
/// 
/// Await may sound similar to the Wait method, but they are very different.
/// The Wait method is a blocking operation, and it does not allow this special jumping back to the caller
/// code.
/// That's why in most cases, we would rather await than the Wait method, as this way, we avoid
/// blocking operations.
///
static Task RunHeavyProcessNew()  /// These compilation errors are fixed in the next lecture. Dont change here.
{
    string result = await HeavyCalculation();
    Console.WriteLine(result);
}