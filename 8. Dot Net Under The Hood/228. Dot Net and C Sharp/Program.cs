// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// What is .NET and how it is different from C#

// People tend to consider C# and .NET synonyms, but they are not.
// Both are technologies developed by Microsoft, but they are different.
// C# is a programming language. Nothing more. 
// One could develop a C# compiler that would translate C# files into a binary code that any computer could interpret,
// even one without .NET installed.
// However, Microsoft's implementation of C# is heavily integrated with .NET, and in almost every
// practical case, applications written with C# will be run under .NET.
// .NET is a framework that enables running applications written in C#.
// C# is not the only programming language that can be run under .NET.
// Other examples could be F#, a functional language developed by Microsoft, IronPython a .NET-compatible version of Python,
// or Visual Basic.
// The cool thing is that we can use the code written in one language in the code written in another.
// For example, we could have a C# class derived from an F# class.
// You can think of C# and .NET like this. 
// C# is a plane and .NET is an airport.
// Let's now understand what the role of .NET is exactly.
// Its most important part is the execution environment called Common Language Runtime, which is responsible
// for managing the memory, providing error handling, dealing with threads, and more.
// .NET also provides a set of standard libraries, the ones we can find in the System namespace.
// When talking about .NET, we should also mention various .NET-related frameworks.
// For example, Windows Forms and Windows Presentation Foundation can be used to create desktop applications
// or ASP.NET MVC is used for web development.
// More recently, .NET MAUI had its release. It's a cross-platform framework for creating native mobile and desktop apps.
// There are many more .NET-related frameworks, and we can create almost any type of program using the .NET

// At this point, you might be curious why it seems that .NET , .NET Framework and .NET Core are also used interchangeably.
// First, there was .NET Framework released in 2002.
// The truth is people rarely used the full name, and everyone was calling it just .NET.
// Then in 2016, .NET Core, a successor of .NET Framework, was released.
// .NET Core, unlike the older .NET Framework, is cross-platform and open-source.
// Cross-platform means we can use it to create applications not only for Windows machines.
// Open source means all its code is publicly available.
// So at this point we had .NET Framework, which was commonly called .NET, and .NET Core.
// The real problem started in 2020 when Microsoft released a new version of .NET Core, but decided that
// from now on this technology would be called .NET.
// And this new release was called .NET 5.
// So nowadays, someone may talk about a .NET app while actually meaning an old .NET Core or even .NET Framework app.
// Since in this course we will use versions of .NET that are newer than .NET 5
// I'm going to use the name .NET.

// C# and .NET are different things, which also means their versioning is not in line. At the moment
// .NET 7 is the latest release and it comes with C# 11.
// 


