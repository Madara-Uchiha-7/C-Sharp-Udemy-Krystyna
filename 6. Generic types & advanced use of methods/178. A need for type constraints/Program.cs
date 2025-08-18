// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// Using generic type is powerfull be it isn't without the issues,
// When we operate with generic types, we don't know what it is exactly, so
// there is not much we can do with it.
// If you try to see the methods which we can call on result variable in the
// ConvertTo() method then you will see that we can call only those methods 
// which are defined on the System.Object Type. 

// Lets consider the use case:
// We want to generate a collection of random length storing some objects
// inside. We do not want those obejcts to be null.
// So we will create them using the new operator.


IEnumerable<int> ints = CreateCollectionOfRandomLength<int>(100);
IEnumerable<DateTime> dates = CreateCollectionOfRandomLength<DateTime>(100);

Console.ReadKey();
IEnumerable<T> CreateCollectionOfRandomLength<T>(int maxLength) where T : new()
{
    // Random class to generate the random number between the 0 and 
    // max count.
    // Next() returns the non negative random number smaller than specified maximum.
    int length = new Random().Next(maxLength + 1);
    List<T> result = new List<T>();
    for (int i = 0; i < length; i++)
    {
        // This below code does not compile because we have no idea what T is, 
        // so we can not tell if it has a parameter less constructor or not.
        // But there are some type which do have parameter less constructor.
        // So, we will have to limit this method to accept only those types.
        // This is where the type constraints come in handy.
        // Type Constraints limit the types that can be used as the generic 
        // parameter to some specific group that must meet the certain criteria.
        // We use where keyword to define Type Constraints.
        // look at the right side of  <T>(int maxLength)
        // new() :  we are telling only accept the types which has the parameterless
        // constructors.
        // If you pass wrong type then you will get the error called
        // Type must be a non-abstract type with a public paremeterless constructor.
        result.Add(new T());
    }
    return result;
}


// Look at below class for the description of line number 4.
static class ListExtension
{
    public static void AddToFront<T>(this List<T> list, T item)
    {
        list.Insert(0, item);
    }
    public static List<TReturnCollectionType> ConvertTo<TSourceCollectionType, TReturnCollectionType>
        (this List<TSourceCollectionType> list)
    {
        List<TReturnCollectionType> result = new List<TReturnCollectionType>();

        // Use result to check and see, we can call only 
        // Object methods on it.

        foreach (TSourceCollectionType value in list)
        {
            TReturnCollectionType itemAfterCastin = (TReturnCollectionType)Convert.ChangeType(value, typeof(TReturnCollectionType));
            result.Add(itemAfterCastin);
        }
        return result;
    }
}