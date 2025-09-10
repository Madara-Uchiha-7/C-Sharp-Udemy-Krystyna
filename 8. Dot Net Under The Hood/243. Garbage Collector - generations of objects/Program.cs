// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// We will understand what generations of objects are and how they improve the performance of the Garbage Collector.
// We will also learn what the Large Objects Heap is.
// And what does it mean that an object is pinned.
// GC needs to identify objects to be removed, which we learned about in the previous lecture.
// Then it must actually remove them.
// Finally, it must defragment the memory of the application.
// As we know, the Garbage Collector marks objects as reachable or unreachable and removes the latter from, the memory.
// Imagine there is some object.
// Let's call it object A. During the first execution of the garbage collector
// this object is marked as reachable and so are all objects reachable from object A e.g. B and C.
// After some time, the garbage collector gets to work again, and again,
// it marks object A and its friends as reachable.
// Then again, some time passes and garbage collector gets triggered again.
// And one more time it marks object A as reachable.
// If I were the Garbage Collector, I would probably get a bit frustrated.
// This object is obviously long-lived and I don't want to check if it's still needed every time I get to work.
// Well, that's exactly the optimization the garbage collector creators come up with: to not make it check
//  each object every time.
// If some object survived a couple of cycles of the garbage collector's work, it's most likely long-lived.
// And we should check it only every once in a while.
// This optimization introduced the concept of generations of objects.
// Once an object is first created, it is assigned to generation zero.
// If it survives its first collection, it advances to generation one.
// If it survives the second, it advances to generation two.
// The garbage collector checks objects from generation 0 most frequently.
// Less frequently, it checks objects from generation 1and least frequently from generation 2.
// For e.g. Logger object to log the data. Since it will be used till the end there is not need to check it again 
// and again.
// Please note that during a collection of a generation, all previous generations are also collected.
// So when generation zero is collected, no other one is.
// But when generation two is collected, generations zero and one are too.
// And that's why collecting objects from generation two is sometimes called a full garbage collection.
// 
// One more thing that needs to be mentioned is the Large Objects Heap.
// When a very large object, so larger than 85 000 of bytes, is initially created, it is stored in
// a special area of memory called the Large Objects Heap, and it is assigned to generation two
// right away. It gets this special treatment because it rarely happens that very large objects are short lived.
// Also, the objects in the Large Objects Heap have one more special feature.
// They are pinned.
// It means they will not be moved in memory during the defragmentation step of the garbage collector's
// work, which happens after removing unreferenced objects from memory.
// This is because the larger the object is, the more expensive is the operation of moving it and the
// harder it is to find the chunk of memory large enough to fit it.
// It's better to pin such large objects and move smaller objects around them.
// 