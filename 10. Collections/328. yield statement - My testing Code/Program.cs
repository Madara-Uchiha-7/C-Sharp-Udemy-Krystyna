

// This below for loop will go the yield then come here to WriteLine
// This is because we are calling this iterator method which is returning the iterator 
// which is needed for the for loop.
foreach (string item in stringItemMethodOne())
{
    Console.WriteLine(item);
}
Console.ReadKey();

// Below line will not go to yield statement
// because this method returns the iterator which will be used
// inside the foreach loop (foreach internally uses iterator).
IEnumerable<string> stringItemMethodOneIterator = stringItemMethodOne();

foreach (string item in stringItemMethodOneIterator)
{

}

IEnumerable<string> stringItemMethodOne()
{
    string[] stringItemsOne = new string[] { "A", "B", "C" };
    foreach (string stringItem in stringItemsOne)
    {
        yield return stringItem;
    }
}