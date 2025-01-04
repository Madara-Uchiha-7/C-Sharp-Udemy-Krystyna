// We will start from non generic class 
// and then we will convert it to the generic class in next lectures.

ListOfItems items = new ListOfItems();
items.Add(1);
items.Add(2);
items.Add(3);
items.Add(4);
items.Add(5);

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
            for(int i = 0; i < _items.Length; i++)
            {
                newItems[i] = _items[i];
            }
            // Replace old array with new one.
            _items = newItems; // Old array is now bigger
        }

        _items[_size] = item;
        ++_size;
    }
}