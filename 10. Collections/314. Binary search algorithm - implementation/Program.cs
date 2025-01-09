///
/// With what collections the binary algorithm will work with.
/// The collections that have the indexer will be able to use this.
/// For e.g. the IList.
/// We will add this algorithm as extension method for IList of T type.
///

List<int> sortedList = new List<int>
{
    1, 3, 4, 5, 6, 11, 12, 14, 16, 18
};
Console.WriteLine(sortedList.FindIndexInSorted(1));
Console.WriteLine(sortedList.FindIndexInSorted(4));
Console.WriteLine(sortedList.FindIndexInSorted(6));
Console.WriteLine(sortedList.FindIndexInSorted(11));
Console.WriteLine(sortedList.FindIndexInSorted(18));
Console.WriteLine(sortedList.FindIndexInSorted(13));

Console.ReadKey();

public static class ListExtensions
{
    // Binary Search
    // We made the return type a nullable int.
    // If item to find is not present then the value will be null.
    // The T type can not be anything, we should be able to comapre the 
    // collection elements. Should be able to know if smaller, equal or bigger.
    // The interface which gives such ability IComparable, so we are adding the type 
    // contraint. Using IComparable we will make this algorithm universal as it will not 
    // only work with numbers but also with types that can be ordered like strings.
    public static int? FindIndexInSorted<T>(
        this IList<T> list, T itemToFind) where T : IComparable<T>
    {
        int leftBound = 0;
        int rightBound = list.Count - 1;

        while (leftBound <= rightBound)
        {
            // If the result is not whole number then it will be trimmed.
            // e.g. 9 / 2 will be 4.
            int middleIndex = (leftBound + rightBound) / 2;

            if (itemToFind.Equals(list[middleIndex]))
            {
                return middleIndex;
            }
            // < 0 means item to find is smaller than list[middleIndex]
            else if (itemToFind.CompareTo(list[middleIndex]) < 0)
            {
                rightBound = middleIndex - 1;
            }
            else
            {
                leftBound = middleIndex + 1;
            }
        }
        return null;
    }

}

/// We can use the built in implementation of this algorithms called 
/// BinarySearch(valueToFind); E.g:--> sortedList.BinarySearch(1)
/// We can call it on array and list.
/// It returns the int not nullable int like we do if not present.
/// If the value is not present, the returned integer will be negative.