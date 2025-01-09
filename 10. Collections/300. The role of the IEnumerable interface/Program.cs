///
/// IEnumerable is an interface that allows us to iterate a type with a 
/// foreach loop. Since this functionality is so basic for collections,
/// we should implement this interface if you are 
/// going to create your custom collection type.
/// 
/// It may seems like abitlity to iterate the collection is not so much, but 
/// remember the LINQ library has the set of extension methods like Where(), Any()
/// which allows us to manipulate the collections. All these extension methods works because
/// this interface allows iterating the collection with the foreach loop.
/// 
/// 
/// Even strings are collections.(i.e. Collection of characters)  -- * Point 1 Reference.
/// Underlying data structure for strings is an array of characters.
/// In below example for Point 1, if type of testString1 was not implementing the 
/// IEnumerable interface then the code would have failed.
///

namespace _300._The_role_of_the_IEnumerable_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Point 1 Reference Code
            string testString1 = "Chinmay Borkar";
            foreach (char ch in testString1)
            {
                Console.WriteLine(ch);
            }
            Console.ReadKey();
            #endregion Point 1 Reference Code


        }
    }
}
