///
/// Assume we want to write a method that can generate a very long collection 
/// of even numbers.
///

IEnumerable<int> GenerateEvenNumbers()
{
    List <int> evenNumbers = new List <int>();

    // Here MaxValue returns the maximum value of integer.
    // Hover over it to see the number.
    for (int i = 0; i < int.MaxValue; i = i + 2)
    {
        evenNumbers.Add (i);
    }

    return evenNumbers;
}

///
/// Lets see how other developers may use this method:
/// 1.
IEnumerable<int> someNumbers = GenerateEvenNumbers().Skip(5).Take(10);
/// Here someone is trying to skip the first 5 elements and then take next ten 
/// and then ignore the rest of the collection.
/// 2.
foreach (int number in GenerateEvenNumbers())
{
    if (number == 50)
    {
        break;
    }
    Console.WriteLine(number);
}
///
/// Someone is breaking the loop after 50 and only using the numbers < 50. 
/// 3.
int firstNumber = GenerateEvenNumbers().First();
/// Someone is only intrested in the first number.
/// 
/// Each time our method is called, a collection is created with the size greater than
/// the 2 billion. But only small part of its is getting used. 
/// This is the waste of resource.
/// 
/// It will be great to somehow make this method start returning the values
/// before the whole collection is built.
/// 
/// For e.g. for point 3 only first one is returned instead of 
/// building the whole collection.
/// For point 2 we will only generate 25 even numbers.
/// We can not tell such things by passing the parameter if case is like point 1.
/// 

Console.ReadKey();
