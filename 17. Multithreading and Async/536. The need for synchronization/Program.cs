///
/// In this video, we will see why we need synchronization mechanisms when working with multithreading.
/// We will see an example of an operation performed by multiple threads that may result in an unexpected program output.
/// We will also understand what thread safety is.
///

Counter counter = new Counter();

List<Task> tasks = new List<Task>();

for (int i = 0; i < 10; i++)
{
    tasks.Add(Task.Run(()=>counter.Increment()));
}
for (int i = 0; i < 10; i++)
{
    tasks.Add(Task.Run(() => counter.Decrement()));
}

Task.WaitAll(tasks.ToArray());

Console.WriteLine("Counter value is : " + counter.Value);
Console.ReadKey();

class Counter
{
    public int Value { get; private set; }

    public void Increment()
    {
        Value++;
    }
    public void Decrement()
    {
        Value--;
    } 
}

/// 
/// On the high level, this code increments the values 10 times and then decrements the values 10 times.
/// So, value becomes 0.
/// If we remove the task object and keep the simple increament and decrement call the we will get 0.
/// But now multiple tasks execute those operations.
/// Now when I ran the code, I got:
/// Counter value is : -2
/// 
/// This is because our code is not thread safe.
/// Thread Safety is the property of a program that ensures multiple threads can correctly and safely execute it
/// without causing unexpected behavior.
///