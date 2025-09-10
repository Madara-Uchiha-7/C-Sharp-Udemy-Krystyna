// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

/*
The Common Language Runtime is a runtime environment that manages the execution of .NET applications.
The CLR works as a special operating system for all .NET applications.
It manages all operations that otherwise must have been dealt with by a programmer.
The CLR stands between the actual operating system, for example, Windows and the application.
If it wasn't for the Common Language Runtime, we would need to do a lot of low-level tasks ourselves.
For example, make sure that the memory occupied by unused objects is freed.
This is how things are done in languages without an equivalent of the CLR.
For example, C or C++.
The important thing to understand is that the CLR is not exclusive to C#applications.
All programs written for .NET are executed by the CLR.
All code executed under the CLR is called the Managed Code.
Thanks to the CLR, cross-language integration is supported and for example, we can have a C#
class derived from an F# class.
This works because the CLR can understand both languages because both are compiled to the intermediate language.
The CLR is responsible for many operations essential for any NET application.
First is the Just-In-Time compilation, which we learned about in the previous lecture.
Then we have memory management.
The CLR allocates the memory needed for every object within the application.
The CLR also includes the Garbage Collector which is responsible for releasing and defragmenting the
The error handlin. When an exception is thrown
the CLR makes sure that the code execution is redirected to the proper catch clause.
Thread management.
We can have multithreaded applications in which many threads perform many jobs.
If this application is executed on a multi-core processor, those threads can run concurrently, which
means their execution happens at the same time.
What we need to understand for now is that the CLR is doing the thread management, so it makes sure
that all threads are working together well.
Of course, the Common Language Runtime does many more things, but I just wanted to mention the most

Let's go step by step through a simplified, of course, process of creating
and running the application, to see when and how the Common Language Runtime plays its role.
First, the programmer writes the program, which at this moment is just a bunch of text files.
Then those files are compiled to the Common Intermediate Language, which, as we learned before, is
platform independent.
Now the Common Language Runtime comes into play.
It starts the program under the specific operating system.
The CLR's Just-in-Time compiler compiles the intermediate language to binary code that can be interpreted
by the machine's operating system.
As the application runs, the CLR manages all its low-level aspects, memory, threads, exceptions handling and so on.
When the application stops, the CLR's job is done.

*/