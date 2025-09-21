///
/// You may have already noticed "Debug" little drop down below the toolbar options.
/// 
/// If we click on it
/// we will see that we can choose a debug or release build.
/// Let's understand the difference between them.
/// 
/// As we develop our programs
/// we usually don't want to use the release build.
/// This is because the compiler performs code optimizations
/// when this option is selected. They can be various things like removing unused code, renaming variables
/// or inlining methods, which means copying the method's body in place of a method call.
/// 
/// All those changes can make the code faster and more efficient, so it is great that they happen as we
/// want to release our app and give it to our users.
/// 
/// On the other hand, those changes affect the structure of our code.
/// If some code has been changed, moved or removed, we may be unable to debug the app because the code
/// will be in different places than it used to be.
/// The line numbers will not be properly shown.
/// etc.
/// 
/// Because of that
/// when debugging our code in Visual Studio, we usually want to use the debug build.
/// 
/// Moreover, this type of build is often used when the application is deployed to some testing environment.
/// So even if there are bugs, they can be easily found.
/// 
/// 
/// The release build is usually chosen when we create a release version of the app as we want to improve
/// its performance and we don't expect to debug it.
/// 
/// 
/// 
///