///
/// We will learn about C# projects and solutions.
/// We will see how to add more than one project to a solution.
/// 
/// 
/// Let's take a look at the Solution Explorer.
/// A solution is simply a group of projects that are bundled together, edited together, and usually built
/// together.
/// 
/// Visual Studio can open one solution at a time.
/// Until now, we have always worked on solutions containing a single project.
/// It is rarely the case when working on real-life applications, as they often have dozens of projects
/// in the solution.
/// 
/// Let's add another project to this solution.
/// We can do it by right clicking on the solution.
/// And selecting Add new project.
/// 
/// We already know this window, but let's investigate it closer.
/// On right side there are various project templates that we can choose from.
/// Each project template has a different boilerplate code that will be generated right at the moment of
/// the project's creation.
/// 
/// For example, let's say I want to create a WPF application.
/// WPF means Windows Presentation Foundation, and it's one of the .NET frameworks for creating desktop
/// applications.
/// 
/// Now, if you click on create after selecting WPF application,
/// Now, this new project will be created. 
/// Because we chose a different project template
/// other files than those in the console app have been generated.
/// As you can see, not all those files have the *.cs extension.
/// 
/// This should not surprise us.
/// A C# project may contain files of almost any kind.
/// 
/// If we select the build from toolbar and select build solution,
/// All projects in the solution will be built.
/// 
/// If we only want to build a single project, we can do it by right-clicking on it and selecting build.
/// 
/// We can set the project as startup project by right clicking it and selecting the "Set as startup project".
/// 
/// The type of the project can be seen in the project properties, along with many other options. To open
/// the project properties window
/// we will right-click on the project and select Properties.
/// We can also click on the project and press Alt+Enter.
/// On right side, Output Type:
/// It says the output type is Windows application.
/// It could be changed, but it wouldn't modify the generated files and we would need to adjust them
/// manually from the project output types.
/// I want to point your attention to "Class Library" in Output type dropdown.
/// 
/// It is quite special, but also very useful.
/// It is for projects containing code that can be used in other projects, but not run as an executable.
/// 
/// For example, consider all built-in types we use, like generic collections.
/// The projects they are defined in are most likely not executable, and they just define types to be reused
/// in other projects.
/// 
/// We will practice defining class libraries soon.
/// 
/// But now you can remove the WPF project we created.
/// 
/// Please notice that even if this project is removed from the solution, the files still exist on the
/// file explorer.
/// 
/// This is our safety measure so we don't remove the files by accident.
/// So now this folder contains a C# project, which is not included in our solution because we just removed it.
/// 
/// If we wanted to, we could add it again.
/// We will right-click on the solution, select Add,
/// and then instead of a new project, we will select an existing project.
/// Here we need to find the project file for the project we want to add.
/// 
/// In C# applications
/// project files have csproj extensions.
/// We will take a closer look at those files later.
/// But now let's simply add this project to the solution.
/// And now it is back.
/// 
/// You can again remove it. 
/// 
/// 
/// 
///