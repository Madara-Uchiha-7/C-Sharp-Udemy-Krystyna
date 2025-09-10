// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// A memory leak is a situation when some piece of memory is not being cleaned up, even if the object
// occupying it is no longer in use.
// It is important to understand that the Garbage Collector does not give us 100% protection from memory leaks.
// You might have heard that one of the most common sources of memory leaks in .NET is related to events.
// But we will revisit this issue after we have learned what events are.
// For now, let's consider another common source of memory leaks:
// Static fields:
// Remember, a static field does not belong to some particular instance of a class.
// It belongs to the class as a whole.
// Let have a class that wants to keep track of all its existing instances.
// To do so, one could declare a static list of instances in this class and in the constructor add the
// current instance to this list.
SomeClass sm1 = new SomeClass();
Console.WriteLine(SomeClass.CountOfInstances); // This will print count of all the instances.
Console.ReadKey();

public class SomeClass
{
    private static List<SomeClass> _allExistingInstances = new List<SomeClass>();

    public static int CountOfInstances => _allExistingInstances.Count;
    public SomeClass()
    {
        _allExistingInstances.Add(this);
    }
}
// As we said in the lecture about the Mark-and-Sweep algorithm, static fields in classes are one of the
// routes from which the Garbage Collector starts to build the graph of reachability.
// It means this list will always be considered reachable, and since it holds references to all instances
// of the same class ever created, they will always be considered reachable as well, even if they should
// be removed from memory.
// Lets say you use if condition and you craete the object of that class inside that if:
/*
bool someCondition = true;
if (someCondition)
{
    SomeClass sm1 = new SomeClass();
}
*/
// So, after the } of if condition the instance that was created inside will not be removed because 
// of _allExistingInstances which holds the instance created of that class.
// So this creates a memory leak.
// This variable is no longer used, but it still occupies memory.
// It is one of the many reasons to be careful with static fields in classes.
// You may wonder how we could write this code differently so the memory leaks do not occur.
// Well, in the first place, the need to track all instances of a class is quite fishy and the developer
// who needs it probably does something wrong.
// 