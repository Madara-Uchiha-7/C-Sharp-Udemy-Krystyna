///
/// We will take a closer look at the project's properties.
/// Let's open this window again by clicking on the project and pressing Alt+Enter.
/// 
/// They are dozens of settings here, but I want to discuss only some of them, specifically those that
/// you may have the highest chance of ever needing to modify.
/// 
/// Here is the output type we saw already.
/// Below is probably the most important setting of all: the .NET version. 
/// We can change it.
/// Lets say you change it to .NET 5    
/// .NET 5 came with C# 9.
/// So if we try to use some feature from C# 10 or 11, it will not work.
/// e.g.
/// public record struct WontWork {}
/// Declaring a record struct doesn't work because this feature is only available starting from C# 10.
/// But this project uses .NET 5, compatible with C# up to version 9.
/// 
/// Later in this section we will discuss changing the .NET version in more detail.
/// For now, let's go back to the latest .NET.
/// 
/// If you scroll down more on the right side,
/// you will see "Global Usings".
/// 
/// The default ones differ between project templates.
/// For example, web projects will have different global usings than console apps.
/// If you don't like the defaults, you can change them here.
/// 
/// 
/// In "Build" options if you scroll down more:
/// Here is the global setting for using the nullable reference types feature.
/// Teacher recommend having it enabled.
/// However, if you don't want to see warnings related to nullability of reference types, perhaps because
/// you work on an older project and you would see hundreds of them, then here you can disable this feature
/// globally.
/// 
/// 
/// In "Errors and warnings" options if you scroll down more:
/// There is a dropdown of Warning Level.
/// We can choose the severity of warnings we want to see.
/// And the version of C# they come from.
/// Teacher always leave it at default because teacher prefer to be warned if teacher does something wrong.
/// And here is an interesting but unforgiving setting "Treat warnings as erros.".
/// If it's enabled, warnings will be treated as errors and they won't let the program compile.
/// Teacger once worked for a company that decided to use it in all projects.
/// This setting forced the programmers to be very disciplined because we couldn't ignore any warnings or
/// promise to fix them later.
/// But the truth is, the code in this company was top notch.
/// 
/// In "Events" options if you scroll down more:
/// It is possible to configure that before or after the build some commands will be invoked.
/// For example, we could decide that before the build some files will be copied to the build folder or 
/// that after the build some special cleanup script will be run.
/// 
/// In "Advanced" options if you scroll down more:
/// Language version:
/// Specific .NET versions come with specific C# versions.
/// For example, .NET 7 comes with C# 11.
/// Still, if we want to, we can use an older version of C#.
/// As you can see, this setting cannot be changed here.
/// It can only be modified directly in the Csproj file, which we will discuss later.
/// 
/// Usually we want to use the latest C#version for the chosen Dotnet version.
/// 
/// 
/// Please notice the tiny question mark icon that is next to most of the settings.
/// If we click on it, we will be taken to this settings documentation so it can be a great help when we
/// try to understand all those options.
/// 
/// 
/// 
///