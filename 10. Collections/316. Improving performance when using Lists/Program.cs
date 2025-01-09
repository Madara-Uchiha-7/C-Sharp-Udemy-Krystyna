
// Lets create the list using Enumerable.Range()
// This will generate the collection od numbers 
// like 0, 1, 2, ... and so on till 100 million.
using System.Diagnostics; // For stopwatch

///
/// The original working of the List:
/// List used the arrays to store the data.
/// For e.g. list will create the array of size 4 at the start and if we want to add more
/// elements then it will double the size of that array. 
/// Also garbage collector will remove the memory 
/// occupied by old array and perform the defragmentation. 
/// This takes a tole on the processing.
/// There are some ways to overcome this loss.
///
int[] input = Enumerable.Range(0, 100_000_000).ToArray();

// If list is built using existing collection then lets not do like follows:
Stopwatch stopwatch = Stopwatch.StartNew();
List<int> list = new List<int>();

foreach (int item in input)
{
    list.Add(item);
}
stopwatch.Stop();
Console.WriteLine($"Took : {stopwatch.ElapsedMilliseconds} ms");

// This above way will make the list resized again and again.

// Now instead of iterating the input collection, let us just pass it as an argument to the
// list constructor.
stopwatch.Restart();
List<int> list_1 = new List<int>(input);
stopwatch.Stop();
Console.WriteLine($"Took : {stopwatch.ElapsedMilliseconds} ms");

// Or if you want to use the for ten we can also do as :
List<int> lst = new List<int>(input.Length);
// This will make the array of this size so no need to create and destroy the array.
// But do this only when you know that this much size will be used other wise the
// memory will go to waste. This passing the lengh to constructor of the List is still the
// worst approch if you compare to the passing the collection to the constructor using
// Stopwatch.

// Why passing the length to the constructor takes more time than passing the collection to the 
// constructor :
// For the first case the list is still using the .Add method which is called for 100 million 
// times. But for passing collection to the constructor, the constructor uses the 
// copyTo method that when input is as array then it works very fast. 
Console.ReadKey();


// Even if you remove many items from the list still List does not reduce the size of an array.
// Since it is possiible that those spaces are needed again, it does not remove it.
//
// listVariable.TrimAccess();
// This will trim the array to the count of elements currently stored in the list. 
// Do this if you are sure that List does need to increase by a big size again.
// This TrimAccess also requires copying the old array to new array but frees a lot of
// memory. 

/// 
/// So:
/// 1. Use constructor of List to initialize the collection if you want to convert the 
/// collection to list.
/// 2. Use constructor of List to initiaize that array size if you know the certain size.
/// 3. Use TrimAccess() to remove unnecessary memory usage when you know that so much space is 
/// not needed soon.
///

// If you already have a list created and you want to add a lot of elements at once then
// use AddRange() instead of calling Add() again and again. Like this:
//list.AddRange(input); 

// Removing items also comes with the penalty.
// If you remove item from list then items which were right to that item will have to be 
// reshifted. So each right element will move to left by one position making the 
// time complexity O(N)

// If you want to remove many items at one go, use RemoveRange() instead of calling Remove()
// many times.
list.RemoveRange(5, 10);
// 5 is where you want to start to remove items and 
// 10 is the count of elements to be removed.

// RemoveAt(index);
// Unlike remove method which takes an item. So remove method must have to find the item and 
// then remove it using the RemoveAt().
// The RemoveAt(index) does not need to find the element in the List.

// Some operations which we used here has more better alternatives in the Linekd List.