///
/// We will understand whether C# code can be defined outside classes or if it must
/// always be contained within one.
/// We will also learn what top-level statements are.
/// 
/// 
/// Do we have to put all code into classes, or can we have some code
/// living outside them?
/// What may be a bit surprising to beginner programmers, the former is correct.
/// Virtually all C# code we write must belong to some class.
/// No variables or methods can live outside the body of a class.
/// 
/// But
/// We went through the first section of this course writing lots of code, yet we did not define a class
/// even once. We wrote the code anywhere we wanted in the *.cs file and it did not seem to be contained within
/// a body of a class.
/// 
/// 
/// Well, this is because, starting with .NET 6, a feature called top-level statements has been introduced.
/// 
/// So below, we can write in new version:
Console.WriteLine("Hello World");
/// 
/// 
/// Below was what we used write in old version:
namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}
/// 
/// As you can see, a class called Program was created containing a method called Main.
/// This old code was auto-generated when a new console application project was created.
/// 
/// Whatever code we wanted to be run, when the console application starts, we needed to put in the Main
/// method.
/// 
/// Of course, we could still have some helper methods defined in the program class, and we could still
/// have some custom classes that we would use from within this class.
/// 
/// The problem with this old approach is that we had 12 lines of code here while only one actually did
/// something interesting.
/// 
/// Because of that, the top-level statements feature was added, removing all the ceremonies related to
/// having the Program class and the main method.
/// 
/// With this feature, we simply write all statements
/// we want to be executed at the top of the file.
/// 
/// If we need to define any custom types, we need to do it below.
/// So if you write the Console.WriteLine() below our custom class type,
/// Then code will not compile. 
/// We need to put Console.WriteLine() on top.
///
/// Because Console.WriteLine() is in reality in Main method.
/// 
/// And when we create the new classes/types then those will get created outside 
/// the class which defines the Main method.
/// 
/// Of course, we can also put these custom types
/// into separate files and this is recommended in real-life projects.
/// 
/// When we built the program, it is actually modified behind the scenes.
/// 
/// 
/// The code we have written at the top of the file is put into the Program class and its Main method.
/// So as a result, it is the same as it was in the older versions of .NET.
/// 
/// Please be aware that using this feature is a choice.
/// 
/// You can either write it by hand or check 
/// "Do not use Top-Level statements"
/// checkbox when creating a new project from the Console
/// Application template.
/// 
/// 
/// Please notice that we can only have a single file in a project in which we write code like this, 
/// i.e. using Top-Level statements feature.
/// 
/// Please be aware that if we define methods in a file using the top level statements, they cannot have
/// access modifiers specified.
/// 
/// 
/// 
/// 
/// 
/// 