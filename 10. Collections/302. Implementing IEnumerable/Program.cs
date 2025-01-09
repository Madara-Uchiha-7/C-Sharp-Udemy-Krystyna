using System.Collections;

CustomCollection CustomCollection = new CustomCollection
    (
        new string[]{ "1", "22", "333" }
    );


foreach (string word in CustomCollection )
{
    Console.WriteLine( word );
}

Console.ReadKey();

// Since we are implementing the interface,
// we have to implement the methods which this interface uses.
public class CustomCollection : IEnumerable
{
    public string[] Words { get; }

    public CustomCollection(string[] words)
    {
        Words = words;
    }

    public IEnumerator GetEnumerator()
    {
       return new WordsEnumerator(Words);
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
                //throw new IndexOutOfRangeException(
                //$"{nameof(CustomCollection)}'s end reached.", ex); -- Giving error here.
                throw new IndexOutOfRangeException();
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