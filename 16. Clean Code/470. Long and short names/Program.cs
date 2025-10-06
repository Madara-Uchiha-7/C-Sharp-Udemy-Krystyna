///
/// Let's now talk about how long the names should be.
/// The rule of thumb is this: If you need to choose between a long name that clearly shows your intentions
/// or a short one that does not, go for the long name.
/// 
/// Still, if you can convey the same meaning using a shorter name, do it.
/// 
/// For e.g.
/// 
/// var varName = people.Where(person => person.Age >= 18);
/// 
/// We can name it adults.
/// As you can see, we managed to express clearly what this variable stores using only one word. But this
/// is not always possible, and shortening the name too much may result in losing some of its meaning.
/// 
/// 
/// A special case for long names is the names of unit tests.
/// They need to carry information about at least two things.
/// The tested scenario and the expected result.
/// We should not hesitate to use long names for unit tests.
/// If a unit test fails, reading its name is the first thing we do to understand what went wrong.
/// Also, unit tests work as a kind of documentation and it is sometimes the easiest to understand how
/// a class works only by reading unit tests that verify its behavior.
/// 
/// e.g. 
/// TransferMoney_ShouldFail_IfNotOk() is not a good name for the test case.
/// Use 
/// TransferMoney_ShouldFail_IfAccountBalanceLessThanTransferAmount()
/// 
/// E.g.From Assignment
/// I am writing the teachers ans.
///
using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        //you may rename the parameters of this method,
        //but do not change their order or type
        //don't remove or add any parameters
        //do not rename the method!
        // Change the variable names.
        public static string Reverse_Refactored(string input) // I had kept str as it is
        {
            //your code goes here
            var resultCharacters = new char[input.Length]; // I had used result only
             
            var currentIndex = input.Length - 1; // I had used strLength

            foreach (var _char in input)
            {
                resultCharacters[currentIndex] = _char;
                --currentIndex;
            }
            return new string(resultCharacters);
        }

        //do not modify this method!
        public static string Reverse(string str)
        {
            var arr = new char[str.Length];

            var i = str.Length - 1;
            foreach (var _char in str)
            {
                arr[i] = _char;
                --i;
            }

            return new string(arr);
        }
    }
}

