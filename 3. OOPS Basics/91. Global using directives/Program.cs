// As you saw when you created a new file in the project,
// some of the using directives was graded.
// This is because these are the global using which are 
// defined for this application.
// They gets added automatically when the new console
// application project was created and built.
// They are in :
// FileExplorer -> project -> bin -> Debug -> net8.0 ->
// Here you will find ProjectName.GlobalUsings.g.cs
// Why there is a word g in above file name:
// Convention : The files which are auto generated and not created by
// the programmers, has g in the name.
// This files gets compiled with the rest of the project.
// Diff types of projects will have diff auto generated namespaces.
// We can also create our diff file in the project 
// for namespaces which we want to be global.
// Right click on the project and select add -> new Item -> 
// Give name : GlobalUsings.cs
// Add the namespaces here with gloabl keyword in this file.
// This global using directives are available from the C# 10.
// ***************************************************
// Some times we have the namespaces that we use over and over again
// In alomost every file of the project.
// So, instead of writing these repeated namespaces, we can import 
// it globally for entire project.
// For eg. using System.Diagnostics;
// It contains the handy stopwatch type.
// This namespace helps us to measure how much time the code takes
// to execute.
// Lets use it in code and make it global for other files.

global using System.Diagnostics;

Stopwatch startTime = Stopwatch.StartNew();

for (int i = 0; i < 1000; i++)
{
    Console.WriteLine($"Loop Number {i}");
}

startTime.Stop();

Console.WriteLine("Time in ms: " + startTime.ElapsedMilliseconds);

// Now lets say we want to use this namespace in many of our files
// in this project. 
// To solve this, we can add a keyword "global" before directive using.
// Rule is that you have to add the global namespaces above the normal
// namespaces. This way, you now does not need to add this namespace
// in other files.

