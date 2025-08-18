// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// Implement the static SwapTupleItems method .Its purpose is to take a Tuple of two items as a
// parameter and, as a result, return a tuple in which those items are swapped. 

// For example:

// for an input equal to Tuple<int, string>(1, "hello"),
// the result should be Tuple<string, int>("hello", 1)

// for an input equal to Tuple<int, int>(1, 2),
// the result should be Tuple<int, int>(2, 1)

public static class TupleSwapExercise
{
    //your code goes here
    public static Tuple<T2, T1> SwapTupleItems<T1, T2>(Tuple<T1, T2> input)
    {
        return new Tuple<T2, T1>(input.Item2, input.Item1);
    }
}
