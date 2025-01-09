///
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
    // This parameterless constructor allows us to initialize the elements like 
    // CustomCollection newCollection = new CustomCollection {"one", "two", "three"};
    // i.e. by skipping the (), otherwise we will have to create reference like :
    // CustomCollection newCollection = new CustomCollection() {"one", "two", "three"};

    // Add method with one varibale to make collection initializer work.
    private int _currentIndex = 0;
    public void Add(string item)
    {
        Words[_currentIndex] = item;
        ++_currentIndex;
    }
    // Thia Add method is not necessarily have to be implemented in the Custom Collection. It can also be an extension method.

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
        return new WordsEnumerator(Words);
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

