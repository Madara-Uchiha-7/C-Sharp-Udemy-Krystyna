///
/// Big O notation can be used to measure the time complexity which we did below,
/// also can be used to measure the space complexity (How much memory an
/// algrithm will need).
///

// Assume that this method has input : 5,4,3,2,1
// If you want to check if 5 is present or not 
// which is present at the 1st location, then it will check "if (item.Equals(itemToCheck))"
// this condition only once. This was a optimistic scenario.
// Lets consider the passimistic one:
// If the item which you want to search is not present in this collection at all
// then condition will be checked == size of input collection.
// So here we can say that the number of the basic operations that will be 
// executed scales linearly with the size of the input collection.
// So, F(N) = n, N is size of input collection.

bool Contains<T> (T itemToCheck, IEnumerable<T> input)
{
    foreach (T item in input)
    {
        if (item.Equals(itemToCheck))
        {
            return true;
        }
    }
    return false;
}
///
/// The big O notation tell us how the cost of an algorithm will with the 
/// size of the input. So above algorithm's complexity is big O of N --> O(N).
/// Because the number of basic operations, which are correlate with the execution
/// time. grows linearly with the input size.
/// 
/// Please notice that we actully don't care if its 1N or 2N, 3N or whatever else.
/// For example, if we had one more if condition inside like if () then break;
/// still the complexity will still remians the O(N), because the growth is 
/// linear with the size of the input. 
/// 
/// There are more complexities like this, e.g.:
/// O(N^2) : Quadratic Complexity. : This happens for nested for loops.
/// i.e. 2 for loops in total and 1 is nested inside the other.
/// 
/// The fastest algorithm has the O(1) Complexity.
/// They are the algorithms whose execution time does not depend at all on the 
/// size of the input collection. On graph it will be a line parallal to 
/// X-axis starting from point 1 on Y-axis.
/// E.g.: If function has below code:
/// return input[index];
/// O(1) does not mean that any algorithm with the Big O of one complexity will
/// take exactly the same time. It only means that time does not scale with the 
/// size of the input.
/// For e.g. if function has below code:
/// return input[key]; 
/// Assume that this code returns the value from the dectionary for given key.
/// So, this is more complex than taking value using index for list.
/// Still the time complexity for this dictionary code will also be O(1).
/// 
/// Then we have Big O of logN i.e. O(Log N)
/// Also some call it logarithmic complexity. 
/// A typical algorithm using it is binary search.
/// 
/// So if we compare the time take by these complexities:
/// O(1) < O(logN) < O(N) < O(N*N)
/// These are also called as :
/// Constant < Logarithmic < Linear < Quadratic
/// 
/// There are more complexities but the once which we are seeing are the most
/// common ones.
/// 
/// The Big O notation can also be used to measure the complexity of 
/// algorithms using multiple inputs.
/// 
/// For e.g.
/// 
void SomeMethod<T> (IEnumerable<T> inputA, IEnumerable<T> inputB)
{
    foreach (T itemA in inputA)
    {
        foreach (T itemB in inputB)
        {

        }
    }
}

// Here the complexity will be O(N*M)
// The N will be the size of one collection and M will be the size of 
// another collection. 
