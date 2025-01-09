using System.Collections;

///
/// We will see what methods IEnumerable defines which are used when foreach loop is 
/// executed. Only IEnumerable not IEnumerable<T>.
/// IEnumerable : Generic
/// IEnumerable<T> : Non-Generic
/// Since that collection only has 
/// Generic : IEnumerator GetEnumerator();
/// it means, it does not provide any methods to modify the content.
/// If you check IEnumerator definition, :
/// 1. Generic : object Current { get; } : 
/// Returns the Object that is currently process in the iteration.
/// 2. Generic : bool MoveNext();
/// Returns the False when at the end.
/// 3. Generic : void Reset();
/// Moves the pointer to the begining.
/// For non Generic it will be : T Current { get; } and so on. 
///

// Lets see how the foeach loop is converted in compilation

string[] words = new string[] { "1", "22", "33", "44" };

foreach(string word in words)
{
    Console.WriteLine(word);
}

// IEnumerator comes in System.Collections
IEnumerator wordsEnumerator = words.GetEnumerator();
object currentWord;
while(wordsEnumerator.MoveNext())
{
    currentWord = wordsEnumerator.Current;
    Console.WriteLine(currentWord); 
}

Console.ReadKey();
// foreach and while both gives same result, proving that foreach is nothing but sugercoted
// version.