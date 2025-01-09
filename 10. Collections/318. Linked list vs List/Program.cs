///
/// 1. To get the value at the index:
/// List : Fast with O(1) since List uses the array underhood.
/// Linked List : Since it does not use the array as the underlying functionality.
/// So we have to move one by one causing O(N) complexity.
/// It is so bad that the LinkedList defined in the C# standard library does not even expose 
/// an indexer. So ironically LinkedList does not implement the IList interface.
/// 
/// 2. Inserting the element at the begining:
/// List : All items in the list should be moved to the one place at right and then new 
/// element will be placed at the index 0. Making this a O(N).
/// Also there is a possibility to resize the array. This will increase the complexity and 
/// also increase the memory consumption.
/// Linked List: The new element becomes the new head and the old head becomes its successor.
/// Which makes the complexity O(1) since it does not depend on the count of items in the 
/// collection. 
/// 
/// 3. Inserting element at the end:
/// List :  Adding item to last is vary fast making it O(1) assuming the array does not need 
/// to be resized O.W. the time complexity will grow from O(1) to O(N).
/// Linked List : We will change the reference/successor of last element to new node instead of
/// null. But to find the last element we need to iterate whole linked list making it O(N)
/// but we can define one variable which will point at the tail of the linked list. 
/// If we have tail node then it makes it O(1)
/// 
/// 4. Delete the item:
/// List: O(N), because all the other items are needed to move left by one position if 
/// deleting node is not the last item.
/// Linked List: To remove the item we change the reference of its predecessor and 
/// then delete the item. Making it the complexity O(1).
/// 
/// For memory consumption:
/// List :
/// 1. Books more memory that it needs.
/// 2. Each item in the internal array only carries the data.
/// Linked List:
/// 1. Books only memory it needs. Only each node occupies it's own chunk of memory.
/// 2. Each node has data and 1 or 2 references. 
/// 
/// C# standard library includes a generic linked list collection which actually is doubly linked.
/// It contains all the basic operations a linked list should provide. 
/// For performance and big collection prefer the linked list. 
///