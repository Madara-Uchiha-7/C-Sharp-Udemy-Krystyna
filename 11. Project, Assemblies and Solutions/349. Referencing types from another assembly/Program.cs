
using _349_1._Utilities;

///
/// We will see how to reference an existing assembly in our code.
/// 
/// We said that assembly is the result of building a project.
/// Let's create a new assembly.
/// 
/// To do that, we will need to add a new project, define some code there and then build it.
/// Lets name it : 349_1. Utilities
/// Select class library project instead of console project while creating the Project.
/// Select the class library project template since we don't want this project to be executable.
/// Its purpose is to define types that can be referenced in other projects.
/// 
/// This name is very general, and because of that may be not perfect, but it is just an example.
/// I will select the class library project template since I don't want this project to be executable.
/// 
/// This project will contain some general methods that can be used in many other projects.
/// For example, let's define an extension method for IEnumerable that joins all items from a collection
/// together to form a single string.
/// We have added the "EnumerableExtensions" class with required method.
/// 
/// Let's build the Utilities project so an assembly is created.
/// Right click on 349_1. Utilities and select build.
/// 
/// Let's go to the project folder by right clicking on "349_1. Utilities" project.
/// Then selecting open folder in File Explorer.
/// 
/// You will find the .csproj project file and the *.cs file we defined.
/// Go to bin -> Debug -> net8.0 -> And here is the assembly (The file ending with .dll)
/// 
/// In a second, we will remove the Utilities project, but this assembly first and paste it into
/// the upper directory (Folder where our solution is present with all the projects) so we don't lose it.
/// 
/// Now remove the "349_1. Utilities" project from VS and File Explorer. (I have kept it for the code we added.)
/// The source code that created this assembly is gone.
/// Still, we can use the types defined there as the code was built and packed inside this assembly.
/// This, in a way mimics a situation when we somehow gain access to assemblies defined by other developers,
/// but not to the source code. In the .NET environment,
/// we usually achieve that using NuGet, which we will learn about later in this section.
/// 
/// All right, let's use the Utilities assembly in the main app project.
/// To do so we can right click on the this project.
/// Select Add, and Project reference.
/// Here, we will click the browse button and find the Utilities dll.
/// 
/// In VS you will see it in:
/// Extend current project -> Dependencies -> Assemblies -> Utilities file.
/// After building and running the this project, you will find this dll in File Explorer:
/// 11. Project, Assemblies and Solutions\349. Referencing types from another assembly\bin\Debug\net8.0
/// 
/// 
/// Let's use the method we defined earlier to print a collection of numbers.
/// 
var numbers = new int[] { 1, 2, 3 };
Console.WriteLine(numbers.AsString());
/// 
/// 
/// 
/// You can go :
/// 11. Project, Assemblies and Solutions\349. Referencing types from another assembly\bin\Debug\net8.0
/// 
/// and run :
/// 349. Referencing types from another assembly.exe
/// directly.
///
/// If you delete the our  utility dll
/// from: 
/// 11. Project, Assemblies and Solutions\349. Referencing types from another assembly\bin\Debug\net8.0
/// and run :
/// 349. Referencing types from another assembly.exe
/// again then we will get error.
/// 
/// 
/// To remove the assmebly:
/// Unfold the projects dependencies section.
/// And then the Assemblies part.
/// And here we see the Utilities assembly.
/// Remvoe it.
/// 
///