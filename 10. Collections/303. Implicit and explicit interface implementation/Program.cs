///
/// Generic IEnumerable<T> extends the non-generic IEnumerable.
/// So, according to the rule, if a class implements an interface that extends
/// another interface, it must implement the methods from both of those interface.
/// So we have to implement the,
/// IEnumerator<string> GetrEnumerator() and IEnumerator GetrEnumerator()
/// But here as you can see both the methods have the same signature. Which will 
/// cause the error. So to fix this issue we have to use the explicit interface.
/// It is used when 2 implemented interfaces declare different members with the 
/// same name and parameters.
/// To use explicit interface we must precede the method's name with the name 
/// of the interface like we have done in the CustomCollection class.
/// 

using System.Collections;

CustomCollection customCollection = new CustomCollection(
        new string[] { "1", "22", "333" }
    );

 IEnumerator<string> enumerator = customCollection.GetEnumerator(); // This will call implicit interface implementation.

// To call the explicit interface, you have to create the object or variable 
// of the IEnumerable which points to CustomCollection.
IEnumerable customCollection_1 = new CustomCollection(
        new string[] { "1", "22", "333" }
    );

IEnumerator enumerator_1 = customCollection_1.GetEnumerator(); // This will call explicit interface implementation.

foreach (string word in customCollection)
{
    Console.WriteLine(word);
}

Console.ReadKey();

// Since we are implementing the interface,
// we have to implement the methods which this interface uses.
public class CustomCollection : IEnumerable<string>
{
    public string[] Words { get; }

    public CustomCollection(string[] words)
    {
        Words = words;
    }

    // This below is the definition of explicit interface.  
    IEnumerator IEnumerable.GetEnumerator()
    {
        return new WordsEnumerator(Words);
    }
    // Adding public to above method will give the error: Modifier public is not valid for this Item.
    // This is because you can not use any access modifiers when you are using explicit interface implementation.
    // Since to call this explicit interface we have only option that is to create the reference of this interface and then
    // call this method using that reference. So, we can not use access modifier here.

    // This below is the definition of implicit interface.
    public IEnumerator<string> GetEnumerator()
    {
        //return new WordsEnumerator(Words);
        throw new NotImplementedException();
    }
}
// GetEnumerator method returns the IEnumerator interface.
// So we need to create the custom type implementing the IEnumerator interface.
// Because IEnumerator interface will have empty method

public class WordsEnumerator : IEnumerator
{
    // Stores the index of the element that it is currently pointing to
    private const int InitialPosition = -1;
    private int _currentPosition = InitialPosition;
    // our MoveNext() we are increment the value of _currentPosition
    // by 1, and then returning the true or false.
    // Our CustomCollection foreach will first call the MoveNext()
    // Which will move the index to 1 and then will print the value using "Current".
    // But this will skip the value which is at the index 0, 
    // so to avoid such scenario we have made the _currentPosition as -1/
    // We have seen this default behavior in while loop in 301 lecture.
    // In that while checks the true or false using MoveNext() and then
    // we are using the Current.

    // Array of words will also be needed because it is the array of words that
    // we are working on.
    private readonly string[] _words;

    public WordsEnumerator(string[] words)
    {
        _words = words;
    }

    public object Current
    {
        get
        {
            // Write keyword try and press tab twice, it will automatically add 
            // the catch block.
            try
            {
                return _words[_currentPosition];
            }
            catch (IndexOutOfRangeException ex)
            {

                // By doing ,ex we are also passing the original 
                // exception as the inner exception parameter so it can be
                // accessed by whoever catches the exception.
                throw new IndexOutOfRangeException(
                $"{nameof(CustomCollection)}'s end reached.", ex);
                // my nameof(CustomCollection) was failinf because by mistake I gave the object name of the class
                // same as the class name. So nameof() got confused.
            }
        }
    }

    public bool MoveNext()
    {
        ++_currentPosition;
        return _currentPosition < _words.Length;
    }
    public void Reset()
    {
        _currentPosition = -1;
        // Same reason of -1 as mentioned while defining this variable.
    }
}



// If class is implementing 2 interfaces which has same method name 
// then it is not necessary to use explicit interface implementation. 