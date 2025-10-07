///
/// We learned about the basic collection type in C#: the array.
/// It is often the case that we want to execute some code for each element of the collection.
/// Let's print all elements of this array to the console in a for each loop.
///
var numbers2 = new[] { 2, 3, 4, 5 }; //  I guess this is the new way to define the array.

foreach (var number in numbers2)
{
    Console.WriteLine(number);
}

///
/// As you can see in this loop, we don't have access to the index.
/// 
///