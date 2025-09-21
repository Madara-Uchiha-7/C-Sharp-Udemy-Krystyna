/// Please add the "349_1. Utilities" using project reference in this project.
using _349_1._Utilities;
///
/// We will also understand what happens when the type has a stricter access modifier than the members it
/// contains.
/// 
/// And finally, we will see why the access modifiers we use within types and methods must be consistent.
/// First, let's add a PublicClass class in the "349_1. Utilities" project.
/// This class is public and it could be used in this project.
/// 
/// We saw it already because we used the EnumerableExtensions there, which is also public.
/// 
/// Now let's create an internal class : InternalClass in the "349_1. Utilities" project.
/// If a type or method is internal, it can only be used by types from the same assembly.
/// So, below will not work:
/// 
/// InternalClass internalClass;
/// This class is inaccessible here due to its protection level.
/// On the other hand, we will be able to use it in the same project it is defined in.
/// As you can see, we have used it in "UsingInternalClass" in the "349_1. Utilities" project.
/// 
/// Internal should be the default access modifier for our types.
/// We should only use the public access modifier if we clearly intend to make a type or method available
/// in our assemblies. When we generate new types with Visual Studio
/// it makes them internal by default to follow the same guideline.
/// 
/// Now a tricky question.
/// Can we declare a public method in an internal class?
/// The public access modifier method in the internal class will compile without any issues.
/// But does it mean we will be able to use this method outside its assembly?
/// We can not, because we can not access the class, so, we can not use the public method inside the 
/// internal class outside the assmebly / other code.
/// So effectively, this method is internal because the type it is defined in is also internal.
/// So perhaps we should declare it as internal explicitly?
/// Well, teacher wouldn't recommend it.
/// Having an internal type with public member or members instead of internal ones, it would be easy
/// to make them all public. If we changed our minds, we would only change class internal modifier to public.
/// This way we do not need to change the access modifiers of the members of the classes because they are already public.
/// 
/// In "349_1. Utilities" project,
/// lets say:
/// If class A if public
/// and 
/// class B is internal.
/// 
/// If you define the method in class A.
/// Lets say method Test().
/// Then you can not give the method return type B.
/// i.e. 
/// public B Test()
/// {}
/// You can not define the method like this.
/// Because class A is public and its method is also public.
/// So, this method can be called from the outside of the assmebly.
/// Since, class B is internal that type can not be returned to outside of the assembly.
/// So, this is not allowed.
/// 
/// You can create the class B instance in the class A even if the class A is public and Class B is internal.
/// But you can not return it.
/// 
/// This principle goes beyond methods.
/// For example, we cannot add a public property of an internal class type.
/// 
/// For e.g.
/// We can not add below Property in class B:
/// public B _b { get; } 
/// or
/// public InternalClass _internalClass { get; }
/// 
/// We could access public property in another assembly, but it would return a type that isn't accessible
/// It cannot work this way.
/// The type of a property must be at least as accessible as this property.
/// 
/// 
///