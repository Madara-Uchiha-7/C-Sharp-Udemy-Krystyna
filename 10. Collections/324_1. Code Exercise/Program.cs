// "params" keyword - Does Stack contain any of the given words?
// In the StackExtensions class, implement an extension method for
// Stack<string> called DoesContainAny, which takes a params array of strings as input.
// This method should return true if this stack contains any of the given words and
// false otherwise.

///
/// For e.g. Below show return true.
/// For Stack with items "fox", "cat", and "wolf" and 
/// input containing words "cow" and "cat", the result shall be true
/// Code: 
/// Stack<string> stack = new Stack<string>();
/// stack.Push("fox");
/// stack.Push("cat");
/// stack.Push("wolf");
/// 
/// bool result = stack.DoesContainAny("cow", "cat");
///

/// Teacher's code:
public static class StackExtensions
{
    public static bool DoesContainAny(this Stack<string> stack, params string[] words)
    {
        return words.Any(word => stack.Contains(word));
    }
}