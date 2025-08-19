/// In last lectures we saw the basic working of thread.
/// But our methods which we are passing to Thread, are not returning anything.
/// But what if we want to return a value from our Thread.
/// It is hard to do for Thread but it is easy for the Task.
/// Lets see the Example for Thread:
/// 
string result = null;
Thread thread = new Thread(
    () =>
    {
        // We can assign a value to external variable.
        result = "Hello World";
    });
thread.Start();
thread.Join(); // Wait for the thread to be finished
Console.WriteLine(result);

// Lets see for Task now:
Task taskWithResult = Task.Run(() => CalculateLength("Hello there"));
/// Once you pass the method to Run using lamabda function,
/// hover over the Run(), you will see it returns the generic Task of int i.e. Task<int>.
/// This type is derived from the non generic Task, which is why it can be assigned to a
/// variable of Task type i.e. Task taskWithResult 
/// We can change it to the Task<int> taskWithResult 
/// Lets see the next project for next process to get the value which method returned.
static int CalculateLength(string input)
{
    Console.WriteLine("CalculateLength thread's ID: " + Thread.CurrentThread.ManagedThreadId);
    // Lets assume that this is the long complex calculation which takes time.
    // So, to add a time to slow down this method, lets add:
    Thread.Sleep(2000); // Takes mili seconds as a parameter, for
                        // 2 seconds it will stop the current thread.
                        // Now it will feel like this method is running for 2 seconds. 
    
    return input.Length;
}
Console.ReadKey();
