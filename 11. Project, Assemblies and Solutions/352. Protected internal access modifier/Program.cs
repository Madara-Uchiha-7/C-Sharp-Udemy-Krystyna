/// Please add the "349_1. Utilities" using project reference in this project.
using _349_1._Utilities;
/// 
/// It is named this way because the types and members it is applied to can be accessed in two contexts.
/// Firstly, in all places where the internal type or members could be used so everywhere within containing
/// assembly.
/// And secondly, in all places where protected members could be used.
/// So in derived types, no matter the assembly.
/// In other words, within the same assembly it behaves like internal, so it can be accessed by any code.
/// Outside this assembly
/// it behaves like protected, so it can only be accessed by derived types.
/// Sounds a bit complicated.
/// So let's see an example.
/// 
/// Lets add a method in
/// the "349_1. Utilities" project 
/// called
/// protected internal void ProtectedInternal() {}
/// in the
/// PublicClass class.
/// 
/// Now in "349_1. Utilities" project 
/// this method is internal, so any class will be able to call it.
/// E.g. check method : CallingProtectedInternal()
/// This works without issues because InternalClass and PublicClass types are in the same assembly.
/// 
/// Putside this assmebly, this method is protected.
/// Only derived classes will be able to use it.
/// So,
/// If you do below code here, it will not work:
/// new PublicClass().ProtectedInternal();
/// Calling this code here in the Main method of the Program, class doesn't work, but it will work inside
/// a class derived from the PublicClass.
public class DerivedFromPublicClass : PublicClass
{ 
    public void Test()
    {
        ProtectedInternal();
    }
}
/// DerivedFromPublicClass class is derived from a class defined in another assembly.
/// Because of that, it can call the protected internal method defined there.

/// 
/// 
/// 
///
