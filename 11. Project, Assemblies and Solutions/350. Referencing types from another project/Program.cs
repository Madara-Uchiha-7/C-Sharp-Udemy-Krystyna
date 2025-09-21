///
/// In this lecture, we will see how to reference one project from another.
/// We want to use the our utility AsString() method.
/// The method we are trying to use is in another project and it cannot be used unless this project is referenced.
/// Let's add it as a reference to the current project.
/// We can right-click on the project,
/// select Add Project reference,
/// and here we see the list of projects that can be referenced.
/// Let's select "349_1. Utilities" and click okay.
/// Now, the Utilities project is listed in the dependencies section -> Project -> Our file.
/// Add "using _349_1._Utilities;" on top.
using _349_1._Utilities;
///
/// Before we continue, lets clean the solution. 
/// It will delete all files built during the compilation(Files inside This Project -> bin -> Debug -> .net 8.0).
/// Goto Build -> Clean Solution.
/// Then build this project again.
/// While building, on output window, you will see the build messages.
/// As you can see, even if I only build this project, "349_1. Utilities" were built as well because the
/// this Project now uses the code defined there.
/// Let's take a look into the output folder of the this project.
/// This Project -> bin -> Debug -> .net 8.0 -> New files will come with Utility DLL.
/// This assembly is necessary so it was added.
/// Now we know that we can use the code defined in one assembly in another assembly.
/// But we don't always want to make all types and methods accessible in our assemblies.
/// We can control how it works using special access modifiers, which we will learn about in following lectures.
///

var numbers = new int[] { 1, 2, 3 };
Console.WriteLine(numbers.AsString());
/// 
///