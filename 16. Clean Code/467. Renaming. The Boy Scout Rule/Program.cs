///
/// We will talk about renaming things, which allows us to change bad names into better ones.
/// We will also learn what the Boy Scout rule is.
/// 
/// The first name that pops into our heads is not always the best, but in time, the vision of what a
/// class or a method does will clarify and a better name may appear.
/// 
/// We should always be open to renaming things.
/// If you see a name you know is bad, don't leave it like this.
/// 
/// If you see a good name but a better one pops into your head, change it.
/// Modern IDEs make renaming things very easy.
/// 
/// In Visual Studio, we can use the CTRL+ R R shortcut FOR rename.
/// 
/// Incremental improvement of names is in line with the so-called Boy Scout rule.
/// 
/// This rule says, always leave the code you are working on a little bit better than you found it.
/// The inspiration comes from a rule
/// Boy Scouts follow, which encourages them to leave the environment cleaner than they found it.
/// 
/// Huge refactoring can be overwhelming and because of that, we may avoid doing it for too long.
/// When following the Boy Scout rule, we don't put pressure on ourselves to always create a perfect code,
/// but we are encouraged to do a little clean up while we work on some class or a method.
/// 
/// All those little refactorings combined together can make a huge difference in code quality.
/// 
/// E.g.
/// Class name : AccountManager does not suite
/// if it has a method: UpdatePassword.
/// We would expect it contains methods for creating and deleting accounts.
/// 
/// Also, the word "manager" does not carry any information and it is just a noise in this name.
/// In this case, we would rename this class to PasswordUpdater.
/// 
/// This way it would clearly and honestly describe what its purpose is.
/// 
/// Now the name of the method and the name of the class carry the same information so we could simplify
/// the method name to Update.
/// 
/// There are certain scenarios when renaming is problematic.
/// When we expose our code as a library that other developers use and we change a name, they would need
/// to adjust their code once they update this library.
/// 
/// For example, imagine what would happen if, with the new version of .NET, its creators decided to
/// rename the Console.WriteLine method to something else.
/// 
/// For example, Console.WriteSingleLine. All places in which we use Console.WriteLine would no longer
/// compile.
/// 
/// That's why when we share the code we create as a library, it is especially important to consider the
/// names carefully.
/// This way we will not need to change them later.
/// 
/// Sometimes we see a bad name, but we cannot think of anything better.
/// Lets see that in next lecture.
/// 
/// 
///