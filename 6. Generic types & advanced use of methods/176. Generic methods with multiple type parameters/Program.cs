// Lets say we want to convert the list of one type to the 
// list of another type.

List<decimal> decimals = new List<decimal>() { 1.1m, 2.2m, 33.3m };

// ConvertTo : will be called on the collection of certain type 
// and in <> brackets we will declare what type we want to have in
// output list.
// We must declare this type explicitly, since there is no context the
// compiler could use to infer the target type.
// List<int> ints = decimals.ConvertTo<int>();

Console.ReadKey();
static class ListExtension
{
    public static void AddToFront<T>(this List<T> list, T item)
    {
        list.Insert(0, item);
    }


    // We will use 2 parameters
    // 1 for source collection
    // 2nd for target collection
    public static List<TReturnCollectionType> ConvertTo<TSourceCollectionType, TReturnCollectionType>
        (this List<TSourceCollectionType> list)
    {
        List<TReturnCollectionType> result = new List<TReturnCollectionType>();

        foreach (TSourceCollectionType value in list)
        {
            // This below error will be discussed in the lecture 177.
            result.Add((TReturnCollectionType)value);
        }
        return result;
    }
}
