// Creating the method for delete

ListOfItems items = new ListOfItems();
items.Add(1);
items.Add(2);
items.Add(3);
items.Add(4);
items.Add(5);

items.ReadItems();
items.RemoveAtIndex(2);
items.ReadItems();


Console.ReadKey();
class ListOfItems
{
    // In the real list initial size of the array is set to 0
    private int[] _items = new int[4];
    private int _size = 0;

    public void Add(int item)
    {
        // We will put the element at the position of 
        // our size variable value and then we will increment the 
        // size.

        // If size is greater or equal to 
        // total items in the array
        // then allocate new array size
        if (_size >= _items.Length)
        {
            int[] newItems = new int[_items.Length * 2];

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
        _items[_size] = 0;
    }

    public void ReadItems()
    {
        for (int i = 0; i < _size; i++) 
        {
            Console.WriteLine(_items[i]);
        }
    }
    public int GetAtIndex(int index)
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