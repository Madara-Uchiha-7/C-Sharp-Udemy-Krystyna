/// 
/// We will start this lecture by discussing when to use nullable reference types.
/// We will learn how to disable or enable this feature in specific parts of the code using preprocessor
/// directives.
/// Finally, we will see the generic type constraints for nullable and non-nullable types.
/// 
/// When to use, Teachers advise.
/// Think about the types in your code, their fields and properties, as well as local
/// variables and parameters.
/// Can they ever be null or do you always ensure that they are not?
/// If they can be null, make them nullable explicitly as it will clearly show your intention.
/// Anyone working with your code will know that this thing may be null and if they want to use it, they
/// should first check whether it is null or not.
/// 
/// If you make sure they can never be null, also be explicit about it.
/// This will help to reduce the number of null checks around the app.
/// 
/// 
/// Also, a word of caution about migration.
/// If you work on some old project and you will update the .NET version, you may have a problem.
/// Since the old type declarations are non-nullable starting with C# eight,
/// it may mean that after update you will suddenly get an overwhelming number of warnings.
/// Don't worry, they are a good thing and will help you migrate to this new feature.
/// 
/// But as we said in the previous lecture, if you really don't want to see the warnings, you can disable
/// this feature in project properties.
/// 
/// The process of removing warnings related to nullability can be a bit tiring.
/// Remember the Whac-A-Mole metaphor?
/// 
/// But having nullable reference types can save you from many errors and unnecessary null checks, making
/// the code cleaner, more expressive, and easier to maintain.
/// 
/// Even if you don't decide to introduce this feature in an existing project due to a complex migration,
/// teacher recommend using it in a new code.
/// 
/// 
/// You can disable or enable this feature per file or even a code fragment.
/// This way, you can improve your code step by step and not drown in an ocean of warnings.
/// 
/// To disable or enable this feature, we can use the nullable preprocessor directive.
string beforeNullDirective = null;
#nullable disable
string text = null;

/// 
/// Preprocessor directives in C# are special commands that are processed by the compiler before the
/// actual compilation of the code begins.
/// They don't change how the code works, but they control how it is compiled.
/// They are often used to control what warnings we want to see.
/// As you can see now, the warning for null is gone for text variable, 
/// even if we assign null to a non-nullable string. The warning that we have
/// is related to the fact that this variable is not used.
/// 
/// So by specifying this preprocessor directive here, we disable this feature from this line till the end
/// of the file.
/// 
/// If I want to enable it later in the code I can add another directive.
#nullable enable
string afterNullEnable = null;
/// Now this feature is enabled again, so only the code in between thoese directive lines will not be checked
/// for nullability warnings.
/// 
/// 
/// Generic type constraints related to Nullability:
void SomeMethod<T>(T inpupt) where T : class
{

}
/// Now let's call this method with a nullable string as the generic parameter.
/// string? otherText = null
/// SomeMethod(otherText);
/// On the above line you will see the warning.
/// 
/// This is because "where T : class" constraint says we expect T to be a non-nullable reference type.
/// If we would like to pass any reference type here, either nullable or non-nullable
/// we should add a question mark here.
/// 
/// So if you do : where T : class?
/// Then warning will go.
/// 
/// So thanks to this, we have better control over the nullability of the reference types used in generic
/// methods.
/// 
/// We could also use the question mark with other type constraints related to reference types, for example,
/// the base class constraint.
/// E.g.
/// void SomeMethod<T>(T inpupt) where T : Person?
/// 
/// Now any nullable or non-nullable type derived from the Person class can be used as T.
/// 
/// 
///
