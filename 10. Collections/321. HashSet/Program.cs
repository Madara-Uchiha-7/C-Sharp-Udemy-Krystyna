// App to check the spelling
// Given a string it tells us if it is a correct word.


Console.ReadKey();

public class SpellChecker
{
    // Collection of words we consider as correct.
    private readonly List<string> _correctWords = new()
    {
        "dog", "cat", "fish"
    };
    public bool IsCorrect(string word) => 
        _correctWords.Contains(word);
        
    // Allow user to add their own words in this collection
    public void AddCorrectWords(string word) =>
        _correctWords.Add(word);

}
// Above design issues:
// 1. Performance of the Contains method for list.
// This method iterates the List and checks if present or not using Equals(itemToCheck).
// This makes it O(N).
// 2. One word can be placed twice. Which will make the program slower.
// Lets improve the performance using Dictionaries because if it uses GetHashCode()'s good implementation then it will be helpful.
// But what to add at the place of value?? This brings us at the HashSet. This HashSet is the collection representing a set of values.
// All values in a HashSet are unique.
public class SpellCheckerDict
{
    // Collection of words we consider as correct.
    private readonly HashSet<string> _correctWords = new()
    {
        "dog", "cat", "fish"
    };
    public bool IsCorrect(string word) =>
        _correctWords.Contains(word);

    // Allow user to add their own words in this collection
    public void AddCorrectWords(string word) =>
        _correctWords.Add(word);
}
// It is fast because its complexity is O(1)
// It works similarly as dictionaries. It calculates the Hash Code of a given item and iterates the linked list matching this hash code.
// Also we will not have a problem with duplicated entries in this collection because HashSet by definition does not allow it, it is same as 
// dictionary does not allow duplicate keys.
// If we add 2 identical entries in the HashSet then other one will simply get ignored.
// It will not throw the error if you try to add the duplicate value but it will also not add the duplicate value.
// This also does store ordered entries.
// Interview question that might come:
///
/// How to get rid of duplicates in the list:
/// 1. Use the Distinct method from LINQ: List<T> notADuplicateList = input.Distinct().ToList();
/// 2. Transform the list into the HashSet : new HashSet<int>(input).ToList();
/// The Distinct() from LINQ uses a HashSet under the hood but it has a little overhead(Slow).
/// Teacher test both for 100 Million integers and it took 4700 ms for Distinct() and 4200 ms for HashSet.
///

