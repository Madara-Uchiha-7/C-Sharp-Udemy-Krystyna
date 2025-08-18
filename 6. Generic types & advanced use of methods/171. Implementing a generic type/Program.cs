// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// Creating the method for delete

ListOfItems<int> items = new ListOfItems<int>();
items.Add(1);
items.Add(2);
items.Add(3);
items.Add(4);
items.Add(5);

items.ReadItems();
items.RemoveAtIndex(2);
items.ReadItems();


Console.ReadKey();

// We can use any word instead of T inside <>
// Convention for that word is, it should start as a capital letter.
// Also we can have more than 1 parameterized type.
// Now this class is generic i.e. parameterized by type
class ListOfItems<T>
{
    // In the real list initial size of the array is set to 0
    private T[] _items = new T[4];
    private int _size = 0;

    public void Add(T item)
    {
        // We will put the element at the position of 
        // our size variable value and then we will increment the 
        // size.

        // If size is greater or equal to 
        // total items in the array
        // then allocate new array size
        if (_size >= _items.Length)
        {
            T[] newItems = new T[_items.Length * 2];

            // Copy the old array elements to the new array
            for (int i = 0; i < _items.Length; i++)
            {
                newItems[i] = _items[i];
            }
            // Replace old array with new one.
            _items = newItems; // Old array is now bigger
        }

        _items[_size] = item;
        ++_size;
    }

    public void RemoveAtIndex(int index)
    {
        // Check if index is valid
        if (index < 0 || index >= _size)
        {
            throw new IndexOutOfRangeException($"" +
                $"Index ${index} is outside the bounds of " +
                $"the list.");
        }
        // Since we are removing the element, we are decrementing the size by 1.
        --_size;
        // Now we will shift the necessary elements to the left.
        // The loop iterates will begin at the index of the item
        // to be removed.
        // 10 20 30 40 50.
        // The size is 5.
        // If you remove the 30, then index is 2. Size is 4.
        // So, we want 40 that is index + 1 to move at index
        // and then we will increment the index
        for (int i = index; i <= _size - 1; i++)
        {
            _items[i] = _items[i + 1];
        }

        // We can not assign 0 to T because T can be anything. If it is DateTime or string 
        // then assigning 0 does not make sense.
        // default(type) : Returns the default value for the type passed as a parameter.
        // for e.g. : var item = dafault(DateTime) -> if we are using var keyword
        // DateTime date = dafault; -> if we are not using var keyword
        // It will understand that it needs the default date due to left side of = operator.
        _items[_size] = default;
        // for T we do not need to write like default(T);
        // because the type T that was passed can be inferred from the context.
        // since our array _items[] is of type T, default will pick from this context and
        // assign the default value of that type.
    }

    public void ReadItems()
    {
        for (int i = 0; i < _size; i++)
        {
            Console.WriteLine(_items[i]);
        }
    }
    public T GetAtIndex(int index)
    {
        // Check if index is valid
        if (index < 0 || index >= _size)
        {
            throw new IndexOutOfRangeException($"" +
                $"Index ${index} is outside the bounds of " +
                $"the list.");
        }

        return _items[index];
    }
}