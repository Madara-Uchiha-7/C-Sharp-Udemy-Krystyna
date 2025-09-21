///
/// One of the rules we should try to follow while programming is: don't reinvent the wheel.
/// This, of course, means we should not solve the problems that other people have solved in the past.
/// 
/// Let's consider manipulating collections.
/// Why should we write our own methods that can do it when other developers have already created the LINQ
/// library and they were kind enough to share it?
/// 
/// If we created a library just like LINQ from scratch, it would simply be a waste of time.
/// It would also most likely be not as good as LINQ, as it wasn't tested and reviewed by millions of users.
/// LINQ is a part of the C# standard library, so it is developed and distributed by Microsoft and gets
/// installed on our computers when we install .NET.
/// 
/// But other developers not working on .NET may have great ideas too, and they may choose to make their
/// implementations publicly available.
/// 
/// We can benefit from that and use them in our programs.
/// In the .NET environment the central repository of packages is called NuGet.
/// 
/// 
/// NuGet allows developers to find, install, and update packages easily.
/// Let's see the NuGet Packages Manager in action.
/// 
/// Right click on the this project and select manage NuGet packages.
/// 
/// The first view we see is the list of all installed packages.
/// Currently we don't have any.
/// 
/// All assemblies we use are built in into .NET, so we don't need to install them using NuGet.
/// Let's go to the browse tab.
/// Here is the list of packages that can be installed.
/// This list is very long as anyone can publish a package in NuGet.
/// We can search for a package by its name by entering it in serch bar.
/// 
/// Let's say I want to install the Json.NET library.
/// This library can serialize and deserialize objects to and from JSON.
/// Nowadays we can use the built-in library for that.
/// However, many older projects still rely on the package published by Newtonsoft.
/// 
/// Select
/// Newtonsoft.Json
/// 
/// It is a very popular package, so it is shown almost at the top of this list.
/// Let's see the options and properties we should pay attention to.
/// 
/// Here we see the version of the package.
/// We can choose some older version if we want to, but we must be aware that it may lack some functionality
/// of the latest version.
/// 
/// Select the older version.
/// Select 13.0.1
/// 
/// 
/// Here we have some additional information.
/// The most important is the license.
/// 
/// The fact that a package is published in NuGet does not mean we can use it however we like.
/// For example, some packages may be free for private use, but are not free for commercial use.
/// We should always understand the license of a package we install.
/// This package uses the MIT license, which allows us to use it in any way we like, also commercially.
/// 
/// If you scroll down,
/// Right here are the dependencies of a package.
/// 
/// In other words, the assemblies needed for this package to work.
/// If not installed on our computer, they will be automatically added when we install this package.
/// 
/// On top right
/// There is a "Package Source" dropdown.
/// We can choose the source of the packages.
/// As we learn, we usually use nuget.org as the package source, but many companies have their own repositories
/// of internal packages.
/// 
/// So when we work in a company like that, we may want to configure another package source.
/// To do so we must click on this gear(setting symbol present there).
/// 
/// And in this window on the plus icon.
/// Here we can choose the source name, and we must provide the URL of the repository, for example, like
/// this:
/// Name   : MyCompanyRepository
/// Source :  https://myCompany.com/packages
/// 
/// Once we add it,
/// we could then choose the internal repository in "Package Source" drop down menu.
/// 
/// In this case, on the left pannel 
/// we would see all the packages published in this repository, not the ones published
/// in NuGet.
/// 
/// We want to use nuget.org as the source, so we will leave this option.
/// 
/// Let's install Json.NET.
/// 
/// Once the application is installed, we can also see our notification under the Updates tab.
/// It tells us we don't use the latest version of this package.
/// 
/// Update it.
/// Now the latest version of this package is used.
/// Let's use it in our code.
/// 
using Newtonsoft.Json;

var json = JsonConvert.SerializeObject(5);

///
/// We can also see it in the dependencies of the product in the packages section.
/// If we wanted to uninstall this package, we could simply do it here.
/// Right click and select remove.
/// 
/// We only installed this package for this single project so we don't see it in the other project.
/// 
/// To see all packages installed for all projects, we can open the NuGet Package manager for the solution,
/// not for a single project.
/// Let's right click on the solution and select manage NuGet packages for solution.
/// Here we see the summary of all installed packages.
/// Select the JSON library.
/// It clearly shows that the JSON library is installed only in the MainApp project.
/// 
/// If we wanted to, 
/// we could install it in other projects by checking the checkbox in front of the project
/// and clicking install button.
/// 
/// 
/// Now let's see how to use NuGet in Visual Studio Code.
/// If you use Visual Studio Community, you can jump to the next lecture.
/// The NuGet Package Manager was automatically installed when we added the C# Dev Kit extension to
/// Visual Studio Code.
/// 
/// The process is quite similar to what we saw in Visual Studio Community, so this will be quick .To add
/// a package to a project
/// click on the top menu(search area), select "Show and Run commands", and then search for "NuGet: Add NuGet package". 
/// To find it faster,
/// simply type "nuget" in the search bar.
/// Here we can see all available NuGet options.
/// Let's select the one for adding a new package.
/// Next, we need to choose the project where we want to install the package.
/// After that, we search for the package by name.
/// We'll type "newtonsoft" in the search bar. And there it is.
/// Select it.
/// Now we select the package version.
/// We'll go with the latest one. And done.
/// 
/// The package is installed.
/// We can confirm this by opening the csproj file of that project
/// where the package reference is now listed.
/// 
/// 
///