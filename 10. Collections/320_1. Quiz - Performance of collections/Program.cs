//Question 1:
//We have a List of one million items. Then, we remove 99% of them, and we don't intend to add more items in the future.

//Which of the following will not improve the performance of this code?

// Ans: Calling the G.C. method.
//This method will clean some unused objects, but it will not reduce the size of the List in any way, because it is still used.
//Also, the Garbage Collector knows best when it should collect memory. Generally, we should not use this method in production code.


