///
/// We will learn how to define async methods.
/// We will also see what types can be returned from such methods and what types we can use the await keyword
/// with.
/// The await operator can only be used within an async method.
///

Task task = RunHeavyProcess();

Console.WriteLine("Doing other work!!");
Console.WriteLine("Done doing other work!!");

Console.ReadKey();


/// We use async to specify that a method is asynchronous.
/// An asynchronous method will run synchronously until it reaches the first await expression, at which
/// point the method is suspended until the awaited task is completed.
/// In the meantime, control returns to the caller of the method.
/// So the whole point of making a method async is to enable using the await keyword in its body.
static async Task RunHeavyProcess() 
{
    /// We were getting compilation error on line "await HeavyCalculation();"
    /// Error was : String does not contain a definition for GetAwaiter.
    /// This error is here because we try to await a string, i.e. returning the string from
    /// HeavyCalculation() which is not permitted.
    /// We can use the await keyword only with specific types. 
    /// So what types are they?
    /// First of all, any kind of task like a plain Task or a generic Task of T.
    /// We can also implement custom awaitable types, but they are rarely used.
    /// So it seems the issue lies in the HeavyCalculation method.
    /// Instead of a string, it should return a Task of string so this task can be awaited.
    /// So, we changed "static string HeavyCalculation()" to "static Task<string> HeavyCalculation()"
    /// Now, HeavyCalculation returns a task then how come 
    /// we are writing "string result = "
    /// Why does it compile without errors?
    /// The HeavyCalculation method returns a Task of string.
    /// Why can we assign it to a string variable?
    /// There are two different types and it shouldn't work.
    /// Well, the reason for that is again the await keyword.
    /// It unwraps the Task result from the Task object.
    /// So after the calculation of this task is completed, it will unwrap its result and assign it to the
    /// result variable.
    /// Once we reach the next line, which, remember only happens after the task is completed, result variable
    /// will carry the task result, not a task.
    ///
    /// The second mysterious thing is that there RunHeavyProcess compiles fine, even though it declares
    /// it will return a task, but it seems not to do so.
    /// We don't use the return keyword anywhere in this method.
    /// Well, this time the reason lies in the async keyword.
    /// It makes this method asynchronous, and asynchronous methods always return a task of some kind.
    /// The only other type allowed to be returned from async methods is void, but this is a special case needed
    /// for compatibility with some .NET frameworks.
    /// Usually async methods that do not produce any result should return a non-generic task.
    /// Because async methods always return tasks, we don't need to return them explicitly.
    /// For methods that do not produce any result, a non-generic task will be created and returned behind
    /// the scenes.
    /// For methods that do return some results, we should simply return it, and it will be wrapped in a generic
    /// task.
    /// So, we made "static Task<string> HeavyCalculation()" async by adding async keyword and
    /// returned a string i.e. "return "Done!"; from this method then you will not get the error even if 
    /// the return type and the method return type does not match.
    /// So the string result will be wrapped in a Task of string behind the scenes.
    /// If method does not contain the await and if it is defined the async then
    /// we will get the warning:
    /// This async method lacks await operators and will run synchronously.
    string result = await HeavyCalculation();
    Console.WriteLine(result);
}

static async Task<string> HeavyCalculation()
{
    Console.WriteLine("Starting heavy calculation.");
    Thread.Sleep(2000);
    return "Done!";
}
/// This code will still not work and
/// will print 
/// Starting heavy calculation.
/// Done!
/// Doing other work!!
/// Done doing other work!!
/// This means it still ran as the synchronous way which should not happen.
/// We will see this in the next lecture.