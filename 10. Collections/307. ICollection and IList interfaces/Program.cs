// Use ctl + t to find the file. 

///---------------------------------- ICollection<T> ----------------------------
/*
    public interface ICollection<T> : IEnumerable<T>, IEnumerable
    {
        int Count { get; }
        bool IsReadOnly { get; } // This says if collection is readonly or not.
        void Add(T item);
        void Clear();
        bool Contains(T item);
        void CopyTo(T[] array, int arrayIndex); // Takes array and index 
        bool Remove(T item);
    }
*/

List<int> numbers = new List<int> { 1, 2, 3 };
int[] intArr = new int[10];

numbers.CopyTo(intArr, 2); // Will copy 1,2,3 and will start placing the elements from index 2

// List internal Data Structure is also an array. 
// So when this constructor is called the list copies all the elements from the input collection
// to the internal array of a list.
// You can go to the definition of this constructor by right clicking "List" from "new List".
// That constructor takes (IEnumerable<T> collection) as a parameter.
// Then checks in if (collection is ICollection<T> c)
// then does c.CopyTo(_items, 0);
// So, I think array goes to this collection which is represented as c and then _items is our list inside that class and 
// using CopyTo we are pasting data from our array and keeping it in List from index 0. 
List<int> numbers_1 = new List<int>(new int[] { 1, 2, 3, 4 });
// This constructor also handles the input collection that does not implement the ICollection interface in the else block.
// That is else block of "if (collection is ICollection<T> c)"
// In that else the input collection is enumerated and each item is simply added to the list using while and MoveNext().
// But this makes performance worse. 

/// --------------------------------------- IList<T> --------------------------------------------------------

/*
public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable
{
    T this[int index] { get; set; }
    int IndexOf(T item);
    void Insert(int index, T item);
    void RemoveAt(int index);
}
*/
///
/// As you can see the class implementing the IList<T> must define the indexer. 
/// Declaration of indexers can be declared in an interface like methods or properties like done here : "T this[int index] { get; set; }"
///

Console.ReadKey();

///
/// If you want to implement the IList<T> then you must implement the methods of ICollection<T>, IEnumerable<T>, IEnumerable.
/// These are lot methods and not every collection (custom type which we are using and making it liek a collection) 
/// can define the Add method from the ICollection Interface. If collection (custom type which we are using and making it liek a collection)
/// is Immuatable or its size is simply fixed, like it is for an array, we should not be able to add the items to it.
/// The answer to this is in the next lecture.
///