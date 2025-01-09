///
/// HashSet - CreateUnion method
//Implement the CreateUnion method, which takes two HashSets and builds a new HashSet containing all items from both input HashSets.

//For example:

//for set1 containing numbers { 1,2,3,4,5}
//and set2 containing numbers {4,5,6}, the result shall be {1,2,3,4,5,6}

//for set1 containing strings { "a", "b"}
//and set2 containing strings {"c", "d"}, the result shall be {"a", "b", "c", "d"}

//This method should be pure - it should not modify the input parameters in any way.
///


// My code:

namespace Coding.Exercise
{
    public static class HashSetsUnionExercise
    {
        public static HashSet<T> CreateUnion<T>(
            HashSet<T> set1, HashSet<T> set2)
        {
            HashSet<T> test = new HashSet<T>();
            // My Code
            IEnumerator<T> set1Enumerator = set1.GetEnumerator();
            while (set1Enumerator.MoveNext())
            {
                T set1Value = set1Enumerator.Current;
                test.Add(set1Value);
            }

            IEnumerator<T> set2Enumerator = set2.GetEnumerator();
            while (set2Enumerator.MoveNext())
            {
                T set2Value = set2Enumerator.Current;
                test.Add(set2Value);
            }

            /// Teacher's way
            HashSet<T> teacherHashSet = new HashSet<T>(set1);
            foreach (T item in teacherHashSet)
            {
                teacherHashSet.Add(item);
            }
            // End of Teacher's way
            return test;
        }
    }
}
// Teacher used the simple way
