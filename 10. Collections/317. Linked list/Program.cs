///
/// Linked list is a collection whose elements are not stored in contiguous memory 
/// location like arrays or lists.
/// It contains the sequence of elements where each element has a reference to the next item in
/// the list.
/// Each item in the Linked List is an object called a node of the list.
/// Each node contains the value and the reference to the next node.
/// Node<T> : T Value; Node<T> next;
/// The first node of the list is called the Head of the list.
/// The above list which we are discussing is called as the singly linked list.
/// The singly linked list means each node has a reference only to the next node.
/// This is enough if we want to iterate the list from start to end.
/// But for this list there is no way fast way to find the predecessor of a given node.
/// We could also have the doubly linked list in which where each node will have the reference
/// for the next node and the previous node.
/// It occupies more memory but allows iteration from start and generally easier identification
/// of the node's predecessor. 
///