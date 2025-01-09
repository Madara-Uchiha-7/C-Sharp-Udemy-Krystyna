// Stop the iterator method once we find the negative number.

int[] numbers = new int[] { 1, 2, 3, 4 };

foreach (int number in GetBeforeFirstNegative(numbers))
{
    Console.WriteLine(number);
}

Console.ReadKey();

IEnumerable<int> GetBeforeFirstNegative(IEnumerable<int> input)
{
    foreach (int number in input)
    {
        if ( number >= 0)
        {
            yield return number;
        }
        else
        {
            yield break;
        }
    }

}