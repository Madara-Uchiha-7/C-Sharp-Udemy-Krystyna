///
/// Stack is a data structure that stores the data in linear fashion.
/// Where elements are added and removed from the same place called as Top.
/// So it is last in first out. (LIFO)
/// This works opposite of queue.
/// Stack is the area of memory where local variables are stored. 
/// The memory stack utilizes the same concept as the stack data structure.
/// Stacks are also used in many low level mechanisms of programming languages.
/// Like keeping track of function calls or evaluating mathematical expressions using 
/// paranthesis. The higher level use cases for stacks may be keeping track of operations
/// performed by the user in some editor. So when user want to undo anything in the editor ,
/// it helps.  
///

Stack<string> stk = new Stack<string>();
stk.Push("A"); // Adds at the top of the stack
stk.Push("B");
stk.Push("C");
stk.Push("D");

// Retrieve the item from the top of the stack.
string top = stk.Pop(); // We will get D in this, in Queue it will be A.
// After above line stack will have only 3 items remaining.

// Only check the top value without removing it from the stack.
string topValue = stk.Peek();

Console.ReadKey();