// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

/* 
We will learn what the Common Intermediate Language is.
We will also understand how and when it is compiled into binary code by the just-in-time compiler.
Also the mystery of how can C# code communicate with the F# or Visual Basic code will be resolved.

At the very beginning of this course, we said that the compiler transforms the *.cs files into binary
code that a computer can understand.

We have two compilers doing their work at different moments in time.
When we click Build in Visual Studio, the C# compiler called Roslyn starts its work.
It takes all the *.cs files from the project and compiles them.
But the result of this operation is not the binary code, at least not yet.
The C# code is compiled into the Common Intermediate Language code.
It is sometimes abbreviated as the CIL or IL - the Intermediate Language.
It is a programming language like any, perhaps not the prettiest ever, but still human-readable,
unlike the binary code, which is just a series of zeros and ones. Only when we start the application,
the Common Intermediate Language is translated to the binary code.
We call this process just-in-time compilation because a piece of code is only compiled to the binary
code right before it is used for the first time.
This second compilation is specific to the machine the program will run on so the same app can be run
on different systems like Windows or Mac OS.
The binary code must be slightly different for those systems, and the just-in-time compiler takes care of that.
That's why using .NET, we can easily create apps that can be run on different platforms.
Another benefit of the Just-In-Time compilation is that when it is used, not all code is necessarily compiled into binary code.
It is often the case that big chunks of an application are not actually executed when it runs.
The user may use one simple feature and then close the application.
So compiling it all to the binary code would be a waste of time and resources.
What is important to understand, all .NET-compatible languages, not only C# get compiled to the
CIL. That enables the communication between, for example, a C# and an F# libraries.
For example, we can have a C# class derived from an F# class because they both get compiled
into the same programming language.
The Common Intermediate Language.
The Just-In-Time compilation is managed by the Common Language Runtime.

*/