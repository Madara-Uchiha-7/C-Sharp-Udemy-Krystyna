///
/// We will learn what compilation is and what the program performing it is called.
/// We will also see what the compilation result is and, specifically, what *.dll files are.
/// 
/// As we said in the previous lecture, the source code of any program is just a text document.
/// So how does it happen that our computer can read it and understand what it means?
/// Well, it can't.
/// 
/// Before the computer can understand and execute the code we wrote, the code must be compiled.
/// The compilation is a process of transforming the source code, in our case, a *.cs file into a format
/// that the computer can work with.
/// 
/// This format will not be anything we, as humans, could understand.
/// 
/// So basically, a compiler is a program that translates human-readable source code to computer-readable
/// files. 
/// It got installed together with Visual Studio.
/// 
/// Click on build -> clean solution -> 
/// It will remove all files created when our code was first built, which happened when we clicked the
/// run button.
/// 
/// 
/// Now let's right-click on our project and select "Open Folder in File Explorer".
/// 
/// Here is the *.csproj file representing the project.
/// And here is the Program.cs text file.
/// 
/// There are also two folders Bin and Obj.
/// 
/// Let's go to Bin, Debug, .net6.0.
/// As we can see, this folder is now empty.
/// 
/// Now let's build our project again by clicking, Build, Build Solution.
/// And now we see that some files appeared in this folder.
/// Those files are the results of the compilation of our source code into an executable application.
/// The application is right here. It is the one with the *.exe extension.
/// 
/// We can run it completely independent of Visual Studio.
/// You could even share this program with someone by simply copying the contents of this folder and giving
/// it them.
/// 
/// They wouldn't need Visual Studio to run this program.
/// Except for the executable,
/// there are also some other files here.
/// The most important is the *.dll file.
/// DLL stands for Dynamic Link Library.
/// It sounds a bit cryptic, but in practice, it is just our code compiled to a format that the computer
/// can understand.
/// The executable file uses the DLL file.
/// So if we remove the DLL, the *.exe would no longer work. Any code will create in C# will be compiled
/// to a dll file.
/// 
/// 
/// 
/// 
///
/// 
/// 
/// 
/// 