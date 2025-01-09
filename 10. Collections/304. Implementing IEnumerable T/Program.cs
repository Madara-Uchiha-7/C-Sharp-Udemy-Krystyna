///
///
/// 

using System.Collections;

CustomCollection customCollection = new CustomCollection(
        new string[] { "1", "22", "333" }
    );

IEnumerator<string> enumerator = customCollection.GetEnumerator();

IEnumerable customCollection_1 = new CustomCollection(
        new string[] { "1", "22", "333" }
    );

IEnumerator enumerator_1 = customCollection_1.GetEnumerator();

foreach (string word in customCollection)
{
    Console.WriteLine(word);
}

Console.ReadKey();

public class CustomCollection : IEnumerable<string>
{
    public string[] Words { get; }

    public CustomCollection(string[] words)
    {
        Words = words;
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        //return new WordsEnumerator(Words);
        return GetEnumerator(); // We can use below method's working because it is same functionality.
    }
    public IEnumerator<string> GetEnumerator()
    {
        return new WordsEnumerator(Words);
    }
}


// Originally we had written "public class WordsEnumerator : IEnumerator"
// But to make "public IEnumerator<string> GetEnumerator()" work for above class
// we made made it "public class WordsEnumerator : IEnumerator<String>".
// Because we need to return the IEnumerator<string> of "new WordsEnumerator(Words);"

// Generic IEnumerator<string> implements Non Generic Enumerator, IDisposable
// We need to implement that methods
public class WordsEnumerator : IEnumerator<String>
{
    private const int InitialPosition = -1;
    private int _currentPosition = InitialPosition;
    private readonly string[] _words;

    public WordsEnumerator(string[] words)
    {
        _words = words;
    }


    // From IEnumerator
    object IEnumerator.Current => Current;

    // The above property will simply return the value of the below property 
    // I think "Current;" will trigger below getter and since "IEnumerator.Current" type is of
    // object, it will hold the string from below getter.
    public string Current
    {
        get
        {
            try
            {
                return _words[_currentPosition];
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new IndexOutOfRangeException(
                $"{nameof(CustomCollection)}'s end reached.", ex);
            }
        }
    }

    // From IEnumerator
    public bool MoveNext()
    {
        ++_currentPosition;
        return _currentPosition < _words.Length;
    }

    // From IEnumerator
    public void Reset()
    {
        _currentPosition = -1; // Why -1 is already written in the lecture 303.
    }

    public void Dispose()
    {
        // We don't want to dispose anything here so we will keep this empty.
    }
}


///
/// -------------------------------------- Part 1 --------------------------------------------
/// I think I need to write down the flow, because there is a lot going on here in this
/// code: Flow is :
/// 1. We need to implement the IEnumerable<T>
///    So here <T> is string for us.
/// 2. Originally the foreach loop uses this. But to show how its really works,
///    we are implementing this.
/// 3. Now, CustomCollection is our main class here which we will create the array
///    of string.
/// 4. That class since implements the IEnumerable<string> interface, we need to implement the 
///    methods of this interface. Note that this interface also extends another interface(IEnumerable),
///    so we need to impletment the methods of that interface also.
/// 5. The methods which we need to implement are:
///    IEnumerator<string> GetEnumerator();   --> from IEnumerable<string>
///    IEnumerator GetEnumerator();   --> from IEnumerable
/// 6. Since our both the interface has same method signture, we are using spcial syntax to 
///    know the difference.
/// 7. So, we implemented "IEnumerator IEnumerable.GetEnumerator()" and 
///    "public IEnumerator<string> GetEnumerator()" in our CustomCollection class.
/// -------------------------------------- Part 2 --------------------------------------------
/// 8. Now since implementation of :
///    "IEnumerator IEnumerable.GetEnumerator()" -> Expects the return type IEnumerator 
///    and
///    "public IEnumerator<string> GetEnumerator()" -> Expects the return type IEnumerator<string>
///    
///    we are implementing a class "WordsEnumerator" which implements the Interface 
///    "IEnumerator<string>" which extends the "IEnumerator, IDisposable" interfaces.
///    So, class will have the implementation of  "IEnumerable" and "IEnumerator<string>".
///    This will allow us to return type "IEnumerator" and "IEnumerator<string>".
/// 9. The methods which we need to implement for class "WordsEnumerator" are:
///    string Current { get; }   --> from IEnumerator<string>
///    void Reset();             --> from IEnumerator
///    bool MoveNext();          --> from IEnumerator
///    object Current { get; }   --> from IEnumerator
///    void Dispose();           --> from IDisposable
///    NOTE: The class must implement everything from interface like methods, properties like Current. 
///    Defining fields in interface is not allowed like int number;
///


///
/// IEnumerator<string> extends IDisposable interface. The non generic IEnumerable does not extend it. Why?
/// The .NET Framework 1 came with generic IEnumerable and .NET Framework 2 came with IEnumerable<T>
/// The .NET Framework 2's IEnumerable<T> extends the IDisposable. Now, DEV couldn't update
/// .NET Framework 1's IEnumerable, because it will fail the codes of other people which are using the 
/// IEnumerable and all those people who are usin the IEnumerable from .NET Framework 1, will have to 
/// implement the IDisposable's methods to make their code work.
/// This, not updating the IEnumerable so that people's code will keep on working is called backword
/// comapatibility.
/// But this also means keeping some of the mistakes as it is.
/// For e.g. Teacher's fev example is:
/// constructor of Random class.
/// Its parameter name starts with capital letter "Seed" which it should not according to Microsoft's
/// recommendations.
/// Because some has used this class by passing the value to this "Seed" Parameter like : 
/// Random random = new Random(Seed : 123);
/// So devs can not update it now and make it seed. 
/// (Seed : 123) is called Named Arguments.