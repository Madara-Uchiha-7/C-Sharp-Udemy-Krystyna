// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// In the previous lecture, we learned what Garbage Collector is.
// As it turns out, it's not only removing unused objects from memory, it also executes memory defragmentation
// after it finishes memory cleanup.
// To understand what it means, we must first understand what memory fragmentation is.
// Let's imagine a computer's memory as a long array of bytes where 1 byte is 8 bits.
// This is actually pretty close to the real thing.
// Let's say we create a variable of type string and the value of ABC. It consists of three characters and
// each char in C# is two bytes.
// So to store the string on the heap, we will need six bytes of memory.
// The Common Language Runtime finds a six byte long part of empty memory in this long array of bytes assigned
// to the process in which our application runs and reserves it for the ABC string.
// Now let's assume the DEF is also one more string object and that string is no longer used and
// its memory is freed by the Garbage collector.
// This memory is fragmented now.
// It means that there are chunks of free memory placed between chunks occupied by some objects.
// If we now want to store a new long string in memory, we might actually not find a place for it to fit,
// even if the total amount of free memory would be enough to store it.
// That is we have chunks of fragmented space which is enough to store the long string,
// but those fragments are not in order or in sequence which is causing the issue to store the long string.
// What the Garbage Collector needs to do is to move some pieces of memory and make them continuous, thus
// creating a bigger free block of memory. Now the new long string can easily fit in.
// The process of moving the objects in memory to make them contiguous and create a bigger block of free
// memory is called defragmentation.