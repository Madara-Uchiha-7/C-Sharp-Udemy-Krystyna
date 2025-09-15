// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

/// We will also see how to define multiple constraints for a single type parameter and how to manage constraints
/// for multiple type parameters.
/// 
/// So far we have learnt about four kinds of type constraints.
/// We said that we could limit the generic type parameters to the types derived from a specific base class
/// i.e. where T : BaseClass
/// 
/// Implementing a given interface 
/// i.e.
/// where T : ISomeInterface
/// with a special case being the INumber interface used to represent
/// numeric types.
/// i.e. 
/// where T : INumber<T>
/// 
/// We also said that we could make sure that types passed as a T expose a public parameterless constructor.
/// i.e.
/// where T : new()
/// 
/// There are a couple more type constraints, many of them being quite technical or being variations of
/// the constraints we learned about.
/// 
/// Link the full list of constraints:
/// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters
/// 
/// But be aware that some of them are related to topics we haven't learned about yet.
/// When we reach those topics, we will revisit the type constraints once again.
/// 
/// Please be aware that we can define as many type constraints for a single type parameter as we want.
/// We must simply separate them with a comma.
/// For example, here the TPet type must be both derived from the Pet base class and must implement
/// the IComparable of Pet interface.
void SomeMethod<TPet> (TPet pet) where TPet : Pet, IComparable<TPet>
{

}
/// If this method was parameterized by more than one type, we could define separate type constraints for all of them.
/// In this case, we will have to use the "where" keyword multiple times.
void SomeMethodMultiple<TPet, TOwner>(TPet pet, TOwner owner) where TPet : Pet, IComparable<TPet>
    where TOwner : new()
{

}
/// Now the TPet type must be derived from the Pet and implement the IComparable of Pet interface.
/// The TOwner type must provide a public parameterless constructor. 
/// Please be mindful that there is no comma here.
public class Pet { }
public class PetOwner { }
/// 
///
///
