///
/// We will also understand the difference between a project and an assembly.
/// We already know what projects are: collections of files used to build an application or library.
/// 
/// The result of building the project is an assembly.
/// An assembly is a compiled unit of code that can be loaded and executed by the Common Language Runtime.
/// 
/// Assemblies take the form of an executable,
/// so an exe file, or dynamic link library,
/// so a *.dll file. Assemblies are the building blocks of .NET applications.
/// 
/// Also, assemblies can be versioned, meaning a particular assembly declares its version.
/// 
/// A project by itself is useless for the user.
/// It cannot be run.
/// First, it must be built into an assembly, which means an assembly can be distributed and installed
/// independently of the project that created it.
/// 
/// This is what we witness when we install some programs on our computers.
/// We see that in the installation folder
/// there are a bunch of *.dll files and an *.exe file.
/// But naturally the source code is not there. Yet,
/// we can still run this program.
/// 
/// As users, we don't care about the source code.
/// To summarize, a project is only a bunch of files that are not yet ready to be executed.
/// We can say that those files belong to some assembly, which means that once compiled, they will end
/// up in the same assembly.
/// 
/// An assembly may be run or referenced by another assembly, and the code defined inside is ready to be
/// executed.
/// 
/// Let's go to the next lecture to see how to reference an existing assembly in our code.
/// 
/// 
/// 
///