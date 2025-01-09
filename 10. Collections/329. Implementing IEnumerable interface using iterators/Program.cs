/// We will refactor our old code in which we were using the CustomCollection class.
/// ///
/// When creating an object of a collection type, we often want to use a collection initializer.
/// For e.g. this is how it looks for lists:
/// List list = new List<int>(10) {1, 2, 3, 4};
/// We will do this for custom collection. Like : 
/// CustomCollection newCollection = new CustomCollection { "one", "two", "three" };
/// To do this we need to define the parameterless constructor.
/// Also we need to define the public Add method which adds the element in the CustomCollection.
/// Intrestingly the Add(one Parameter) will be the extension method.
/// 
///

using System.Diagnostics.Contracts;

using System;

using System.Collections;

CustomCollection newCollection = new CustomCollection
{
    "one", "two", "three"
};

Console.ReadKey();

public class CustomCollection : IEnumerable<string>
{
    public string[] Words { get; }

    // type ctor and press tab once default suggetion comes
    // to create the parameterless constructor.
    public CustomCollection()
    {
        // Our collection initializer will work only till 10 implementation.
        Words = new string[10];
    }
    private int _currentIndex = 0;
    public void Add(string item)
    {
        Words[_currentIndex] = item;
        ++_currentIndex;
    }

    public CustomCollection(string[] words)
    {
        Words = words;
    }

    public string this[int index]
    {
        get => Words[index];
        set => Words[index] = value;
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    public IEnumerator<string> GetEnumerator()
    {
        //return new WordsEnumerator(Words); Old approch

        /// Below is the first Approch :
        /// Words is the collection which is a wrapper for an array of strings. 
        /// This below yield allowed us to return the enumerator produced 
        /// by the array. WordsEnumerator is our custom enumerator. 
        /*foreach (string word in Words)
        {
            yield return word; // Allowed for IEnumerator also like IEnumerable
        }*/

        /// Second Approch : Let's see how we can use the enumerator created by the array. 
        /// Since array of strings implements the generic IEnumerable interface explicitly,
        /// we had to create a additional varibale words to hold it.
        /// So to use the method form this interface (that is method GetEnumerator()) 
        /// we need to operate on a varibale of this interface type.
        /// If we call the GetEnumerator() on the variable of the array type
        /// i.e. Words.GetEnumerator() then this will cause the compilation error.
        /// Because GetEnumerator() method returns the non generic enumerator. i.e.
        /// another type than IEnumerator<string>. To avoid this we created the varibale.
        IEnumerable<string> words = Words;
        return words.GetEnumerator();
        /// Above two lines ,means : If our collection simply wraps another collection,
        /// we can easily refer to its GetEnumerator method.
        /// If not, we can write an iterator method or a custom enumerator i.e. old Approch
        /// and 1st approch. Old one is small and easy and 
    }
}

public class WordsEnumerator : IEnumerator<String>
{
    private const int InitialPosition = -1;
    private int _currentPosition = InitialPosition;
    private readonly string[] _words;

    public WordsEnumerator(string[] words)
    {
        _words = words;
    }
    object IEnumerator.Current => Current;

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

    public bool MoveNext()
    {
        ++_currentPosition;
        return _currentPosition < _words.Length;
    }

    public void Reset()
    {
        _currentPosition = -1;
    }

    public void Dispose()
    {
        // We don't want to dispose anything here so we will keep this empty.
    }
}

