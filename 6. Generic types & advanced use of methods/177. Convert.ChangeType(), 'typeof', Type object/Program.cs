// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// Lets say we want to convert the list of one type to the 
// list of another type.

List<decimal> decimals = new List<decimal>() { 1.1m, 2.2m, 33.3m };
List<int> ints = decimals.ConvertTo<decimal, int>();

List<float> floats = new List<float> { 1.4f, -100.01f };
List<long> longs = floats.ConvertTo<float, long>();
// Floats are floating point numbers which are similar to decimals,
// but less precise.
// Long is the whole number same as int with bigger size.

// We have either explictly specify all the parameters 
// or none of them. Here we have to specify because compiler can 
// understand the source type because we are doing  decimals.ConvertTo..
// but it can not find the target type.

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
            TReturnCollectionType itemAfterCastin = (TReturnCollectionType)Convert.ChangeType(value, typeof(TReturnCollectionType));
            result.Add(itemAfterCastin);
        }
        return result;
    }
}

// Check the ChangeType() signature.
// It takes Object as 1st parameter. Which means we can pass anything here.
// Its second parameter is of type 'Type'. Type class representing types.
// It contains the properties like type's name, namespace it belongs to
// the base type, or the list of the type's constructors. It is the part of
// the reflection mechanism.
// We can get the type object of any type using "typeof" keyword.
// For e.g. Type dateTimeType = typeof(DateTime);
// If we want to get the type object for some instance, not a specific class
// then we do like:
// List<decimal> decimals = new List<decimal>() { 1.1m, 2.2m, 33.3m };
// Type listOfDecimalTypes = decimals.GetType();
// GetType() is defined in the System.Object type, so we can call it on any object.
// It returns the Type object describing the type of this instance.
// So it does the same thing as the typeof keyword, but we use the typeof with the
// type's name and we call the GetType method on the object.
// So, DateTime is the type and decimals is the obejct of type List.
// Return type of the ChangeType() is System.Object type.
// So, we casted the ChangeType to TReturnCollectionType.
// ChangeType() throws the error if the conversion is not possible.



/*
Quiz
Which of the following is not the right way of building
a Type object describing the int type?

1. Type type1 = int.GetType(); -->Ans
2. Type type2 = 1.GetType();
3. Type type3 = typeof(int);
*/