/// 
/// Lets understand the yield and role of iterator.
/// Methods using the yield statements are very specific.
/// They returns the iterator of collection not the collection themselves.
/// As you can see in the last lecture method, the return type is IEnumerable<int>.
/// If a type implements the IEnumerable, it does not mean the collection.
/// It only means it is something that can be iterated with the foreach loop.
/// Iterator is an object that can produce a sequence of items.
/// There are 2 things that Iterator needs to work.
/// 1st is the method of producing new items.
/// 2nd is the Iterator needs to remember where in the iteration it is.
/// and should return the IEnumerable or IEnumerator. (Remember that : 
/// IEnumerator is a type that GetEnumerator method returns and this method 
/// is a part of IEnumerable interface. This means we can implement this interface
/// using iterator methods instead of defining a custom enumerator class.)
/// When we define a method with a yield statement inside, it becomes an iterator 
/// method.
/// The code we write inside is not the code that gets called when the method is 
/// executed. All this method does is produce and return the new iterator.
/// like
/// return new Iterator 
/// {
///     CurrentIteration = 0,
///     MethodGeneratingSequence = Here will go the code logic from our method.
/// }
/// The code we define in the iterator method is given to this iterator as its 
/// property.
/// Now it uses this only when it is asked to do so. And we ask it using
/// foreach or etc. we saw in last 2 lectures.
/// 
/// Note: Be aware that if we iterate an iterator with a new foreach loop, it gets 
/// reset. Lets see it in action:
/// 
IEnumerable<int> secondNumbers = GenerateEvenNumbers();
foreach (int evenNumbers in secondNumbers.Take(3))
{
    Console.WriteLine(evenNumbers);
}
// This below for loop will reset the iterator. So sequence is 
// generated from start.
foreach (int evenNumbers in secondNumbers.Take(3))
{
    Console.WriteLine(evenNumbers);
}
// This makes iterator work twice for the same operation.
// We can avoid this by removing the secondNumbers.Take(3) and keep it in variable.
// And then converting that variable in the List using ToList() and use this list in
// both of the foreach.
Console.ReadKey();

IEnumerable<int> GenerateEvenNumbers()
{
    for (int i = 0; i < int.MaxValue; i = i + 2)
    {
        yield return i;
    }

}

// Take(number) is a LINQ method which produces iterator which is used by the foreach
// loop. 