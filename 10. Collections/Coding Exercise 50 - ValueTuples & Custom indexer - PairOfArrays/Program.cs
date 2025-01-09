///
/// Add the indexer to the PairOfArrays class. This class is a container 
/// for two arrays: left and right.
/// This is how we want to be able to use this indexer:
/// var ints = new int[] {1,2,3};
/// var strings = new string[] { "a", "b", "c", "d"};
/// var pairOfArrays = new PairOfArrays<int, string> (ints, strings);
/// (int, string) result = pairOfArrays[2, 1];
/// 
/// As you can see, the indexer takes two integers. 
/// The result variable should be a ValueTuple with items (3, "b")
/// because we take the element at index 2 from the left array and 
/// the element at index 1 from the right array.
/// 
/// We can also use this indexer to set values in the arrays:
/// var ints = new int[] {1,2,3};
/// var strings = new string[] { "a", "b", "c", "d"};
/// var pairOfArrays = new PairOfArrays<int, string> (ints, strings);
/// pairOfArrays[1, 2] = (100, "XXX");
/// 
/// After this code is executed, the left array should contain numbers 1,100,3 
/// (because the item at index 1 has been set to 100), and 
/// the right array should contain strings "a", "b", "XXX", "d" 
/// (because the item at index 2 has been set to "XXX").
/// 
/// It the arguments given to the indexer are outside the bounds of arrays, 
/// the IndexOutOfRangeException should be thrown.
///
using System;

namespace Coding.Exercise
{
    public class PairOfArrays<TLeft, TRight>
    {
        private readonly TLeft[] _left;
        private readonly TRight[] _right;

        public PairOfArrays(
            TLeft[] left, TRight[] right)
        {
            _left = left;
            _right = right;
        }

        //your code goes here
        public (TLeft Left, TRight Right) this[int indexInLeft, int indexInRight]
        {
            get
            {
                return (_left[indexInLeft], _right[indexInRight]);
            }
            set
            {
                _left[indexInLeft] = value.Left;
                _right[indexInRight] = value.Right;
            }
        }
    }
}

