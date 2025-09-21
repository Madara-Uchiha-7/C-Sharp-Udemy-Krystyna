///
/// We will take a close look at the *.sln files. Just like the Csproj files represent projects
/// the *.sln files represent solutions.
/// 
/// Let's see the *.sln file for this solution.
/// If we right-click on the solution
/// we will not see an option to edit its file in Visual Studio as we did with projects.
/// 
/// This is because manual modification of the files is probably an even worse idea than manual modification
/// of Csproj files.
/// 
/// Go to the area where .sln is present in file explorer.
/// 
/// Let's open it with the notepad.
/// The most important thing we see here is the list of projects this solution contains:
/// 
/// Project("{...}) = "Project Name", "path\ProjectName.csproj", "{...}"
/// EndProject
/// 
/// And so on. (Here ... means some number and letters)
/// 
/// Notice 
/// second "{...}" : 
/// It is an identifier of a project used in all places
/// this project is referred to.
/// 
/// For example, we can see that this identifier string is also used below, where the way of building those
/// projects is configured.
/// 
/// Even if we change the project's name, its identifier will remain the same.
/// 
/// 
/// Just like the Csproj files
/// the *.sln files are modified behind the scenes
/// when we do an operations that affect the solution, such as adding or removing projects.
/// 
/// We can edit the solution file directly if we need to, although it's not a very good idea.
/// It is recommended to manage the solution with the interface of a Visual Studio.
/// 
/// 
