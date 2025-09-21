/// 
/// We will also discuss which ones should be used in what context.
/// Here is a table with all access modifiers.
/// 
/*
Celler's Location                          Public       Protected Internal      Protected       Internal        Private Protected       Private
-----------------
Within the class                            True                True                True            True                True             True

Derived Class (Same Assembly)               True                True                True            True                True             False

Non Derived Class (Same Assembly)           True                True                False           True                False           False

Derived Class (Different Assembly)          True                True                True            False               False           False

Non Derived Class (Different Assembly)      True                False               False           False               False           False
*/
///
/// The file access modifier is skipped as it is a bit different since it can only be applied to types,
/// not members, and it simply limits the usage of this type to the file it belongs to.
/// 
/// If you are unsure what I mean by private types, then please remember that types can be
/// nested.
/// 
/// We can define a class within a class and then use any access modifier we want.
/// For e.g. in outer class we can use public access modifier.
/// And for the nested class we can use the private access modifier.
/// 
/// If a class is not nested but it lives directly in a namespace, then it can only be public or internal.
/// 
/// Protected is quite simple.
/// Protected types or members are available in all types derived from the type they belong to, no matter
/// the assembly.
/// 
/// Protected internal is less restrictive.
/// That's why it is to the left of protected. Within the same assembly
/// it works as internal so unlike protected, it can be used by non-derived types as long as they belong
/// to the same assembly.
/// This brings us to internal. Internal types or members can be used by any type in the same assembly,
/// but they may never be used outside it.
/// Derived types are no exception, and they will also not have access to internal types or members if they
/// are in a different assembly.
/// 
/// Finally, private protected. Only derived types from the same assembly can access it.
/// It is not accessible at all in another assembly.
/// 
/// Link:
/// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
/// 
/// 
/// The good thing is that in practice, in 99% of the cases we use the simplest access modifiers: public,
/// internal and private.
/// 
/// The rest is relevant only if we use inheritance, which is not a common thing.
/// We will discuss the reasons for that later in the course.
/// 
/// Even if the inheritance is used, usually the protected access modifier is chosen.
/// 
/// Also, questions about access modifiers are quite common during C# interviews.
/// So what access modifiers should we use?
/// The rule of thumb is pretty simple.
/// We should use the strictest access modifiers applicable in a given context and valid for our use case.
/// Within a type
/// every member should be private unless we are 100% sure we want other types to be able to access it.
/// In this case, we can make those members public. Types themselves should be internal unless we are certain
/// we want them to be accessible in another assembly.
/// 
/// Remember that even if we define a member as public, but it is contained in an internal type, then
/// effectively this member is internal too.
/// 
/// 
/// If you define the below code:
namespace SomeNamespace
{
    class ClassA
    { 
        class ClassB
        {

        }
    }
}
/// What will be the access modifiers of the ClassA and ClassB:
/// ClassA : Internal and ClassB : Private
/// Correct. The default access modifier is always the strictest one valid in the given context. 
/// ClassA lives directly in the namespace, so for it, only public and internal access modifiers are valid, 
/// out of which internal is more strict. ClassB is nested, so for it, the strictest modifier of all (private) is valid,
/// so it is the one to be used.
/// 
/// 
///