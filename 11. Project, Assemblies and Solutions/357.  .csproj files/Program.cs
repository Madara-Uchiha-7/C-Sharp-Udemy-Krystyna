///
/// Go to the file manager area of our current project.
/// 
/// Here is the *.csproj file representing this project.
/// Just like *.cs files, it is a text file and we could open it with any text editor, but we can open
/// it right in Visual Studio.
/// 
/// so, let's right-click on the project
/// and select Edit Project file.
/// 
/// It is an XML describing the properties of the project as well as its dependencies.
/// It is a textual representation of all the settings we set using the graphical interface.
/// For example, here we can see that the nullable reference types feature is enabled.
/// 
/// Here we see the dependency on the Newtonsoft.Json package we installed and here the dependency on the
/// Utilities project.
/// 
/// Generally, we should not fiddle with this file unless we are sure we know what we are doing.
/// 
/// Most of the project settings can be managed through the graphical interface.
/// Editing the Csproj files manually can lead to hard-to-understand issues.
/// 
/// If you are curious about how those files work and want to try editing them manually,
/// go for it, but save a copy just in case.
/// 
/// Errors from Csproj files are shown in the error tab like any others.
/// For example,lets break this file by removing any forword slash.
/// Then save it.
/// Then we will see a little warning symbol at the name of the project.
/// 
/// Visual Studio tells us there is something wrong with the project file itself and it cannot show us the
/// project in the solution explorer correctly.
/// 
/// And in below, you may see the error tab.
/// Luckily, in this case it is quite simple to understand, but this is not always the case.
/// 
/// Fix the file again.
/// 
/// We will also need to reload the project.
/// VS will show the option to reload the project in such cases on the top.
/// 
/// And now the warning symbol is gone.
/// 
/// So generally, we should be careful with editing this file manually.
/// Still, some settings cannot be set with the UI.
/// I guess this is a gentle suggestion from the .NET creators that we should not change those settings
/// One of those settings is the language version.
/// 
/// If you recall, in the project properties, we can easily change the version of .NET, but it is not
/// the same for the version of C#.
/// Still, if we really want to use the older version of C# for whatever reason, we can change it
/// by editing the Csproj file manually.
/// 
/// You can add:
/// <LangVersion>9</LangVersion>
/// in :
/// <PropertyGroup></PropertyGroup>
/// 
/// This way, the setting in the properties window is also updated.
/// 
/// 
/// Csproj files changed significantly when .NET Core was introduced.
/// So if you ever work in the .NET Framework, which is the predecessor of .NET Core and .NET, you
/// may see that those files are a bit different.
/// 
/// For example, they used to list all *.cs files included in the project.
/// Now all *.cs files from the project directory are included automatically, so the csproj file does not
/// need to list them.
/// 
/// 
/// 
///