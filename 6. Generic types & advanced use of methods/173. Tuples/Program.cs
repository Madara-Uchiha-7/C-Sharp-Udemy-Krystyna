#region TestOfInterview

///
/// Array 100 unsorted numbers
/// find :
/// 3rd smallest no from array
/// 
///
/*
int arraySize = 10;
int[] numbers = new int[arraySize];
numbers[0] = 10;
numbers[1] = 0;
numbers[2] = 0;
numbers[3] = 0;
numbers[4] = 0;
numbers[5] = 0;
numbers[6] = 0;
numbers[7] = 0;
numbers[8] = 0;
numbers[9] = 0;

// 10 30 50 40 -> arr
// 

int firstSmallest = numbers[0];
int secondSmallest = numbers[0];
int thirdSmallest = numbers[0];


for (int i = 0; i < arraySize; i++)
{
    for (int j = i + 1; j  < arraySize; j++)
    {
        if (numbers[i] > numbers[j])
        {
            if (firstSmallest < numbers[j] && (firstSmallest > secondSmallest && firstSmallest > thirdSmallest))
            {
                firstSmallest = numbers[j];
            }
            if (secondSmallest < numbers[j] && (secondSmallest > firstSmallest && secondSmallest < thirdSmallest ))
            {
                secondSmallest = numbers[j];
            }
            if (thirdSmallest < numbers[j] && (thirdSmallest > firstSmallest && thirdSmallest > secondSmallest))
            {
                thirdSmallest = numbers[j];
            }
        }
    }
}
*/
#endregion 


/*
    List<int> numbers = new List<int> { 5, 3, 2, 8, 16, 7 };
    SimpleTuple<int, int> minAndMax = GetMinAndMax(numbers);
    Console.WriteLine("Smallest number is " + minAndMax.Item1);
    Console.WriteLine("Largest number is " + minAndMax.Item2);
*/

List<int> numbers = new List<int> { 5, 3, 2, 8, 16, 7 };
Tuple<int, int> minAndMax = GetMinAndMax(numbers);
Console.WriteLine("Smallest number is " + minAndMax.Item1);
Console.WriteLine("Largest number is " + minAndMax.Item2);

Console.ReadKey();
Tuple<int, int> GetMinAndMax(IEnumerable<int> input)
{
    if (!input.Any())
    {
        throw new InvalidOperationException($"The input collection can not be empty.");
    }
    // First method is the LINQ method which returns the first element
    int min = input.First();
    int max = input.First();

    foreach (int number in input)
    {
        if (number < min)
        {
            min = number;
        }
        if (number > max)
        {
            max = number;
        }
    }
    return new Tuple<int, int>(min, max);
}


public class SimpleTuple <T1, T2>
{
    public T1 Item1 { get; }
    public T2 Item2 { get; }

    public SimpleTuple(T1 item1, T2 item2)
    {
        Item1 = item1;
        Item2 = item2;
    }
}


// There are 2 classes of SimpleTuple with different parameters.
// This is allowed.
public class SimpleTuple<T1, T2, T3>
{
    public T1 Item1 { get; }
    public T2 Item2 { get; }
    public T3 Item3 { get; }

    public SimpleTuple(T1 item1, T2 item2, T3 item3)
    {
        Item1 = item1;
        Item2 = item2;
        Item3 = item3;
    }
}

// By convention, all genertic type parameters names should start with capital T.

// We can not define or try to create a custom tuple class using the
// generic class, since the prameters of generic class can not be dynamic.
// So, check how backend tuple implementation is done.
// I think this tuple class generate dynamically according to the parameters given.
