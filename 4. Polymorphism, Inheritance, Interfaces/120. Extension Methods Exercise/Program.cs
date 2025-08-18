// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

/*
Extension methods - List extensions
Create an extension method for the List<int> type called TakeEverySecond.
This method should return a new List of ints with every second element from the input list.

For example:

for input  { 1, 5, 10, 8, 12, 4, 5 }, the result shall be { 1, 10, 12, 5 }

for input  { 1, 5, 10, 8, 12, 4, 5, 6 }, the result shall be { 1, 10, 12, 5 }

for input  { 1 } , the result shall be { 1 }

for empty input, the result shall be empty

don't handle the null input in any way (let it throw an exception)
*/

// My code:
using System;

namespace Coding.Exercise
{
    //your code goes here
    public static class ListExtension
    {
        public static List<int> TakeEverySecond(this List<int> inputList)
        {
            List<int> result = new List<int>();
            int i = 1;
            foreach (int item in inputList)
            {
                if (i % 2 != 0)
                {
                    result.Add(item);
                }
                i = i + 1;
            }
            return result;
        }
    }

}
// Teacher code : Look at for
/*for (int i = 0; i < inputList.Count; i += 2)
{
        result.Add(item);
}*/