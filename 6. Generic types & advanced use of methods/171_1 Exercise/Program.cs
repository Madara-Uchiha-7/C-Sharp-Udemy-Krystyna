// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

///
/// Generic types - Pair class
/// Implement the generic Pair type as follows:
/// It should be a container for two items of the same type.
/// It should have two properties called First and Second of the type that 
/// parameterized this class. Both those properties should be 
/// publically gettable but should not be publically settable.
/// It should have a constructor taking two parameters that sets First 
/// and Second properties. 
/// This class should expose public ResetFirst and 
/// ResetSecond methods that set the First or the Second 
/// property to the default values for their type.
/// 1. What I did wrong:
/// Did not add the private set;
///
using System;

namespace Coding.Exercise
{
    //your code goes here
    public class Pair<T>
    {

        public T First { get; private set; }
        public T Second { get; private set; }

        public Pair(T first, T second)
        {
            First = first;
            Second = second;
        }

        public void ResetFirst() => First = default;

        public void ResetSecond() => Second = default;
    }
}