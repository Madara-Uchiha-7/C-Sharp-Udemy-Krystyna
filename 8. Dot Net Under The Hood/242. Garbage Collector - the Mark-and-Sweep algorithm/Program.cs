// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// In this lecture, we will learn how the Garbage Collector decides what objects can be removed from memory
// using the Mark-and-Sweep algorithm.
// We will also understand the alternative algorithm called Reference Counting, used in some other technologies
// and see what disadvantages it has.
// We will also understand what a circular reference is.

// As we learned in previous lectures, the Garbage collectors job is to remove unused objects from memory.
// But how it can tell if an object can be removed?
// Well, the algorithm it implements is called Mark-and-Sweep because first, it marks the objects that
// can be removed and then sweeps them from memory.
// But how can we tell if an object can be removed?
// In simplest terms, when there are no existing references that point to this object.
// But how can the Garbage collector know it?
// Well, in the family of tools similar to the garbage collector
// and remember, this concept is not exclusive to .NET,
// there are two most commonly used algorithms.
// The first is called reference counting, which, for example, is used in Swift.
// According to this algorithm, the Garbage collector keeps track of the count of references pointing
// to some object.
// When the count reaches zero, it considers this object unreferenced by any other object, and thus a
// candidate to be removed from memory.
// There is a problem with this algorithm, though.
// Imagine there are two objects: A and B.
// There is a reference from A to B and a reference from B to A, and such reference is called circular
// reference, but no other object in the application references A nor B.
// A and B objects could be removed from memory because they cannot be reached from any point in the application.
// But since for both of them the reference count is one, not zero,
// a garbage collector using the reference counting algorithm would not remove them. Because of that
// reference counting is not used in .NET.
// Instead, tracing is used.
// Tracing will determine whether an object is reachable or not by tracing it from a set of application roots.
// We will learn what application rootsare in a minute, but for now, let's just say there are objects
// that the Garbage Collector starts building the graph of reachability from.
// If an object is reachable from a root object, either directly or indirectly, then it will be considered alive.
// If it's not reachable, it means it can be removed from memory.
// Let's say that the Garbage collector identifies 3 application roots.
// They, by definition are considered reachable.
// Then for each of them, the Garbage collector checks what references they hold, and it adds the objects
// pointed by those references to the graph of reachable objects.
// It repeats this step for each of the new objects.
// It continues its work until there are no more objects, having references to objects that are not included
// in the graph.
// The power of this algorithm is that the circular references will not be included in the graph of reachable
// objects because, well, they are not reachable.
// All right, let's now see what application roots are exactly.
// Roots include static fields and local variables on the thread stack.
// To be more specific, there are also a couple more things that will be included in the application roots
// collection, but they come from low-level mechanisms of C#, which are beyond this course's scope.
// If you are curious, I linked a document about that in this lectures resources.
// https://learn.microsoft.com/en-us/dotnet/standard/garbage-collection/fundamentals
// For us, the most important part is local variables on the thread stack.
// Each thread has its own stack.
// So in multithreaded applications we will have more than one stack. 
// For simplicity, let's focus on single-threaded applications.
// The Garbage collector will look at the stack and see what references are currently stored on it.
// Remember the reference itself is stored on the stack and it points to an object stored on the heap.
// For e.g.
bool flag = true;
Person per = new Person(); 
if (flag)
{
    string textInsideIf = "aaa";
    per.Name = "Tom";
}
string text = "bbb";
Console.ReadKey();
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
// Assume that execution happened till Console.ReadKey();
// Stack will hold per which points to the Person Class inside the heap.
// text wlll be in stack and bbb will be in heap.
// Person Obj -> "Tom" is not stored on the stack.
// textInsideIf reference is not stored in the stack.
// It's not on the stack because it was removed from it once the code execution reached the end of the if statement.
// If the garbage collector gets triggered after we reach at ReadKey() line,
// it will identify two references stored on the stack and will include them in the application roots:
// the reference to the person object and the reference to the "bbb" string.
// It will start building the reachability graph from those routes.
// The person object holds a reference to the "Tom" string, so it will also get included in the graph.
// No object in the graph holds the reference to the "aaa" string, so it will be considered a candidate for
// removal by the garbage collector.
