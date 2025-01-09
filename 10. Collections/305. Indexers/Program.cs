using System.Diagnostics.Contracts;

using System;

///
/// We use indexers all the time like
/// string element = list[i]; OR
/// list[2] = "Hello";
/// 
/// With List class it seems very simple but there is a lot going in the List class.
/// 
/// Code for indexers in the List class:
// Sets or Gets the element at the given index.
/* 
public T this[int index]
{
    get
    {
        // Following trick can reduce the range check by one
        if ((uint)index >= (uint)_size)
        {
            ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
        }
        return _items[index];
    }

    set
    {
        if ((uint)index >= (uint)_size)
        {
            ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
        }
        _items[index] = value;
        _version++;
    }
}
*/
/// 
/// Indexers don't necessarily used integers as parameters. For e.g. while using the 
/// dictionary we use indexers to access to access an element under a given key.
/// The key can be any e.g. : dict[new Point(1,5)] = "Point1";
/// Indexers with multiple parameters is also allowed.
/// E.g. : twoDimentionalArray[1,3] = "def";
/// 
/// We can define our own indexers in the types we create. 
/// We will add the indexer in our CustomCollection type which we defined in last lecture.
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

string first = customCollection[0];
customCollection[1] = "abc";

Console.ReadKey();

public class CustomCollection : IEnumerable<string>
{
    public string[] Words { get; }

    public CustomCollection(string[] words)
    {
        Words = words;
    }

    // To define the indexer in your custom type 
    // you can type indexer and then press tab twice.
    // We can use only getter or only setter according to our need.
    public string this[int index]
    {
        get => Words[index];
        set => Words[index] = value;
    }
    // For dictionary the index type will not necessary be int. For e.g.:
    // public TValue this[TKey index]
    // public TValue this[string index]

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

