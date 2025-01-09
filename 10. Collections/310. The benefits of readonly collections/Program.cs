///
/// Bennifits of immutable types:
/// 1. Clear and simple code.
/// 2. Pure functions.
/// 3. Easier multithreading.
/// 4. Keeping objects valid.
/// 5. Avoiding identity mutation.
/// 6. Easier testing.
/// (NOTE: Come back after revising immutable types and fill all the details for each point.)
/// 
/// Many of above mentioned benifits can be extended to readonly collections, so collections that cannot be modified.
/// So collections will not be able to modify once they are created.
/// For point 1:
/// Once the collection is readonly, we do not need to guess how it is modified in all the methods it is passed to, which makes the 
/// code simper to follow,
/// For point 2:
/// If methods can not modify the collections they operate on, it means we are one step closer to making those methods pure.
/// Remember, pure methods always return the same result for the set of arguments and have no side effects like modifying the arguments.
/// For point 3:
/// Since collection is readonly, there is no worry because even multiple threads are running parallelly they can't modify the collection.
/// For point 4:
/// We don't need to get surprised that collection is suddenly emptied in places where we expected them to full.
/// For point 5:
/// Not applicable for point 5 becuase collections are usually reference types whose only identity is their reference.
/// Still there may be some rare cases when a collection items identify "this" collection and "this" collection supports the 
/// value-based equality. Then the value of the collection is its identity and it will never be modified for readonly collections.
/// For point 6: 
/// There is no need to check all the scenarios where a collection is changed.
/// 
/// This readonly collection example can be used for :
/// Assignment from last section. For collection of Planets.
/// Once we filled the planets using the DTOs read from the API, we could make the collection of planets readonly.
/// Simplified version of that method we used back then which is not readonly:
/// 
///

List<string> planets = ReadPlanets();
planets.Clear();
List<string> ReadPlanets()
{
    List<string> result = new List<string>()
    {
        "Alderaan",
        "Coruscant",
        "Bespin"
    };
    return result;
}