
/// This foreach loop ask the iterator to return the first item.
/// So compiler will first go to yeild return 0 due to in singleDigitNumbers().
/// Then it prints and then it goes to yield return 1 and so on.
/// 
foreach (int number in singleDigitNumbers()) 
{
    Console.WriteLine(number);
}


Console.ReadKey();

// Below method proves that iterator method does need an 
// loop to work.
IEnumerable<int> singleDigitNumbers()
{
    yield return 0;
    yield return 1;
    yield return 2;
    yield return 3;
    yield return 4;
    yield return 5;
    yield return 6;
    yield return 7;
    yield return 8;
    yield return 9;
}
///
