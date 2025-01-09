/// Quesues are data strucutres that store elements in a linear fashion.
/// Where elements are added at the the end of the queue and removed from the front of the queue.
/// The elements are processed in the order they were added to the queue following the FIFO (first in, first out)
/// These are used to process the messages and tasks in sequential way.
/// For e.g. there is hotel who process the orders of the customers. 
/// C# standard library has a Queue class.
///

Queue<string> queue = new Queue<string>();

queue.Enqueue("Hi"); // To add the item at the end of the queue.

// To remove the item from the front of the queue.
string removedItem = queue.Dequeue(); // This will return the item that is removed

// Only check the fist item without removing it
string peekedItem = queue.Peek();

// We can find the priority of some items
// For e.g. item which came last can go first due to high priority.

PriorityQueue<string, int> pq= new PriorityQueue<string, int>();
// Here string will be the item and int will be the priority

pq.Enqueue("a", 10);
pq.Enqueue("b", 6);

string firstPq = pq.Dequeue(); // You will see b at the first even if we are adding it in the end.
// So smaller the number, higher the priority.
// If priority of 2 items are same then order will decide which one will be first and which one will be later.
