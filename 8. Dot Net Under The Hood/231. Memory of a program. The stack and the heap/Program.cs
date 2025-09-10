// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

/*
Each program needs memory to store its data.
Whenever we create a variable, whether simple like an int or complex like a List of DateTimes, it
occupies a piece of the computer's memory.
The memory occupied by programs is the random access memory, also called RAM.
Everything a computer stores is saved as a series of bits, so zeros and ones. 
This array is divided into eight-bit pieces called bytes.
Each byte has its address.

The computer must remember where variable object is stored so it can be retrieved when needed.
In .NET applications, the Common Language Runtime takes care of the low-level operations related
to memory management.

The memory of a .NET program is divided into two parts: the stack and the heap.
The stack is reserved for each thread of the application.
So in multithreaded applications we have multiple stacks.
The heap is a single entity shared between all threads.
The stack is rather small.
It occupies 1 megabyte of memory for 32-bit processes and 4 megabytes for 64-bit processes.
The heap is much larger and it can be resized if a program needs more memory.
The memory is organized differently for the stack and the heap.
In the stack there are no empty chunks of memory between objects and those
objects are automatically removed from the stack once they are no longer used.
For the heap, the memory can become defragmented.
So there may be chunks of empty memory between chunks occupied by objects that are still in use.
Also, the process of removing unused objects from the heap is more complex, and in .NET it is performed
by a mechanism called the Garbage Collector.
Removal of objects from the heap is more complex, it is also slower.
So in general we can say that the stack has a better performance than the heap.

*/