string[] input = new[] {"a", "b", "a", "c", "d", "b"};

foreach(string item in Distinct(input))
{
    Console.WriteLine(item);
}

Console.ReadKey();

IEnumerable<T> Distinct<T>(IEnumerable<T> input)
{
    HashSet<T> hashSet = new HashSet<T>();
    foreach (T item in input)
    {
        if (!hashSet.Contains(item))
        {
            hashSet.Add(item);
            yield return item;
            Console.WriteLine("After yield.");
        }
    }
}
///
/// Flow:
/// The control will go to yield return item,
/// then Console.WriteLine from foreach loop,
/// then Console.WriteLine from Distinct method.
/// Now if you add the debugger at "Console.WriteLine("After yield.");" 
/// and once debugger comes their for the first time, hover over the hashSet variable,
/// you will see count 1, this means iterator method is stateful means it remembers its 
/// state from the previous iterations.
///