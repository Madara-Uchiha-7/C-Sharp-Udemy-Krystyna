///
/// We will discuss the process of updating the version of .NET in the code we work
/// on.
/// 
/// .NET evolves rapidly.
/// 
/// Each version brings something new to the framework and the C# language itself.
/// So usually we want to stay up to date.
/// 
/// In the simplest scenario, updating the version of .NET should be easy.
/// Let's say we created a project when .NET six was the latest version.
/// Then .NET seven is released, and we want to use it in our code.
/// To do so we can simply type install .NET into Google or any other browser.
/// And go to the first result.
/// 
/// Here we can download .NET SDK.
/// Select latest .NET verson to download.
/// SDK stands for Software Development Kit, and it consists all tools required to develop applications
/// with .NET.
/// 
/// For example, the compiler.
/// 
/// After the download is finished, we run the file and go step by step through the installation process.
/// After this is done.
/// If we open the properties of our project, we will see that the new version of .NET is available
/// , then you can select it and cick save or ctl + s.
/// If not, we may need to restart Visual Studio.
/// 
/// In the simple scenario, we change the version of .NET for all projects.
/// We need to do it for all projects because the .NET version is project-specific, not solution-specific.
/// And in theory each project can use a different .NET version.
/// 
/// Usually we want to use the same version, so we should update .NET for each project.
/// The most tricky scenario is when we have a project using
/// .NET Framework and we want to migrate it to .NET.
/// 
/// Remember, they are not the same technologies.
/// Microsoft released the new technology called
/// .NET Core, which was later renamed to .NET .
/// So upgrading from, for example, .NET Core 3.1 to .NET 6 should be simple because they are the same
/// technology only named differently at different versions.
/// 
/// On the other hand, .NET Framework is a different technology and it's not fully compatible.
/// For example, the Csproj files have been changed significantly between those technologies. But it doesn't
/// mean such an upgrade is impossible, but it has its tricks and caveats.
/// 
/// Lets not get into too many details as nowadays apps using the old
/// .NET Framework are less and less common. Just in case you ever need that to port the
/// .NET Framework app to .NET
/// Teacherhas  linked an article about that in the resources of this lecture.
/// That Link:
/// https://learn.microsoft.com/en-us/dotnet/core/porting/
/// 
/// It describes the main differences and guides the programmer through the upgrade process.
/// 
/// 
///