///
/// We will also understand the meaning of the IDE abbreviation.
/// Additionally, we will learn what comments are and how to print messages to the console.
/// Finally, we will see how to configure the options of Visual Studio Community.
/// 
/// Let's create our first C# program.
/// Open Visual Studio and select create a new project.
/// 
/// If you already have Visual Studio running, just select File, New and Project. In this window
/// As you can see with .NET, we can create programs for various platforms and users.
/// For now, let's select Console Application, making sure we select it for C#.
/// 
/// 
/// In this window we can select .NET version.
/// Let's click Create. And here is our project.
/// It is ready to be run right now.
/// 
/// Visual studio is a powerful IDE, so an Integrated Development Environment,
/// a program that is meant to help developers to write and build source code.
/// 
/// Below line allows us to write the statements on the console.
Console.WriteLine("hIIIII");
/// 
/// We can change the message that will be printed to whatever we want.
/// Please notice that in C#, we must have a semicolon at the end of each line containing a statement.
/// 
/// On the right we see the solution window with the project and all files that it contains.
/// Currently just one file called Program.cs.
/// Please notice that all files containing the C# code must have the "cs" extension.
/// 
/// On the bottom, there are a couple of other windows from which the one that will interest us most is
/// the error list.
/// Currently we have zero errors and zero warnings, which is great.
/// 
/// All right, let's build and run this program by clicking on 
/// the top green arrow.
/// 
/// 
/// We see an additional message saying that we need to press any key to close the window.
/// If we don't want this message to be shown, as this is an extra step added by Visual Studio and not coming
/// directly from our code, 
/// Let's disable it so we have full control of the code.
/// To do so, we must go to Tools, Options in the search bar
/// let's type "automatically".
/// It it in Debugging -> General.
/// 
/// Tick the option:
/// Automatically close the console when debugging stops.
/// Click ok.
/// 
/// Now if you run the application again then
/// As you can see it was closed immediately.
/// 
/// Let's understand why is that so.
/// Currently our program has only one line of code.
/// Once it is executed, there is nothing else to do and the program closes.
/// Let's add a second line.
Console.ReadKey();
/// 
/// This line will make the program stop and wait until the user presses a key.
/// Only once he or she does, this line's execution will be finished and the program will continue.
/// Since there is nothing else to be executed, the program will close.
///
/// If you want to take some notes right within the file, you can add your own comments like 
/// we are currently doing so.
/// You can use 
/// /// or //
/// for single line
/// And
/// /* comments */
/// for multi line comments