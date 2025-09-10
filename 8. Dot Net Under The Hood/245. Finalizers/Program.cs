// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------


// After the end of the for loop, the Person class objects should get deleted
// but we don't know when the GC will run, so will force it to run, so that our destructor will run.
for (int  i = 0; i < 5; i++)
{
    Person person = new Person { Name = $"{i}", Age = i + 1 };
}
GC.Collect();
Console.WriteLine("Ready to close."); // If this runs before the desstructor then it means GC did not block the main thread.
Console.ReadKey();
// You will notice that even though for loop runs for 5 times 
// the Person object with name.... will be printed only 4 times.
// Well, destructors are extremely tricky.
// There may be one of the most complex mechanisms in the entire .NET.
// Luckily, we don't need to understand how they work internally for a very simple reason.
// We should never use destructors.
// Also, destructors are commonly discussed during job interviews, so it is better to have a basic knowledge.
// The opinion that we should never use destructors does not come from me, but from Eric Lippert, one
// of the designers of C#.
// Even according to him, the destructors are really weird and may cause many unexpected situations in the code.
// Eric Lippert wrote that the only scenario when he actually needed to define destructors was when he
// was testing some parts of the C# compiler.
// Some links for more info:
// https://stackoverflow.com/questions/4898733/when-should-i-create-a-destructor
// https://ericlippert.com/2015/05/18/when-everything-you-know-is-wrong-part-one/

// So, long story short, don't define destructors.
// But still, there are scenarios when we would like to clean up some resources once we are done working
// with some objects.
// But for that we should use the Dispose method from the IDisposable interface, which we will learn about
// in the next lecture.


// We will take a close look at destructors, also known as finalizers.
// We will also understand when we should define them.
// A destructor is a special method executed on an object right before it is removed from memory by the
// Garbage Collector.
// Lets add the destructor to Person class:
// 
class Person
{
    public string Name { get; init; }
    public int Age { get; init; }

    // Destructor 
    ~Person() {
        Console.WriteLine("Person object with name : " + Name + "is going to get deleted.");
    }
    // The syntax is a bit similar to the one of a constructor.
    // The difference is this tilde symbol here and the lack of an access modifier.
    // Also, the destructors must always be parameterless.
    // Destructors are sometimes called finalizers.
    // This is because during the compilation a destructor is translated to a method called Finalize which
    // looks like this.
    // 
    //protected override void Finalize()
    //{
    //    Console.WriteLine("Person object with name : " + Name + "is going to get deleted.");
    //}
    // Also, we cannot call the Finalize method directly.
    // If we try to call the Finalize method on an object, we would get a compilation error.
    // Only the Common Language Runtime can call it.
    // 
}