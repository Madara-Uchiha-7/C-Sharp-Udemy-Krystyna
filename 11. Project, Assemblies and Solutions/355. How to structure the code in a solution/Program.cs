///
/// We will discuss the topic of splitting a solution into smaller projects.
/// We will learn when we should and when we should not do it.
/// We will also see what circular dependencies are.
/// 
/// There are many schools on how to approach this topic.
/// The right choice depends on the context and personal preferences.
/// So let see some typical strategies and their upsides and downsides.
/// 
/// The first school says we should only split the solution if we want to deploy those projects separately.
/// Let's understand what it means.
/// A typical example could be having the main code in one project and the unit tests for this code in another.
/// We don't want to deploy them together.
/// When we release the application, we only want to release the production code, not the unit tests because
/// the users will not need them.
/// 
/// 
/// We could also have a solution implementing a couple of functionalities.
/// For example, one of its projects could be responsible for accessing some data.
/// The other for processing it and yet another for presenting it.
/// We may want to be able to release them separately, for example, because other developers from the
/// same company use the data reading mechanism we implemented and they only want to access this code.
/// They don't care about the other functionalities. But splitting the code into projects has its downsides.
/// 
/// Some developers prefer each project to be tiny, and because of that, large code bases can be split
/// into dozens of projects.
/// 
/// But this comes at a cost, and this cost is performance.
/// Building a solution with one big project works faster than building a solution with ten little projects.
/// 
/// The same goes for the time of loading assemblies into memory as the program runs.
/// That's why teacher does not recommend such extreme splitting unless we really intend to deploy those projects
/// seperately.
/// 
/// Remember that even within a single project, we still have tools to organize our code.
/// We can organize it into folders and have namespaces matching those folders.
/// But sometimes the boundaries made by folders and namespaces are not strict enough.
/// For example, let's revisit the Star Wars Planet Stats app we created earlier.
/// This app reads data from an API.
/// The serializes it into DTOs and then transforms them into some custom types we defined.
/// We may want to separate those details from the custom types so they don't get mixed up.
/// I.e.
/// Folder ApiDataAccess, DataAccess and DTOs can be present in seperate.
/// 
/// We don't want the developers of this project to use DTOs anywhere except in the code that transforms
/// them into custom types.
/// But with the design we have, it is hard to prevent.
/// One may simply add a using directive that loads types from the DTOs namespace and then they could
/// use them anywhere in the code.
/// It might be easier to prevent the usage of DTOs in places they shouldn't be used
/// by putting the code using them in a separate project. Within this project, the DTOs themselves would
/// be internal.
/// Then we couldn't use them in any other project because as internal types they wouldn't be accessible
/// there.
/// 
/// They are only accessible in project
/// they are defined in.
/// 
/// Before we wrap up a word of caution.
/// When having multiple projects within a solution, we must ensure there are no circular references.
/// 
/// In simple case, a circular reference is a situation when Project A references Project B and Project
/// B references project A.
/// 
/// Of course, it can be more complex with many other projects in between.
/// 
/// This simply cannot work in .NET applications, and Visual Studio will not allow us to define such dependencies.
/// Solving such a pickle requires a different approach in each case, but usually it involves extracting
/// some common code into a separate project and referencing this project from all our projects that need it.
/// 
/// For e.g.
/// We can do
/// Class C: 
/// It will have
/// Class A
/// Class B
/// 
/// Then
/// 
/// Project A:
/// Which needs Class B will go to class C.
/// 
/// And
/// 
/// Project B:
/// Which needs Class A will go to class C.
/// 
/// So this way, circular loop is broken.
/// 
///