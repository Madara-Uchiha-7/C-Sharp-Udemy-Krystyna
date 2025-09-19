///
/// When to override the GetHashCode method:
/// The short answer would be: if the default implementation does not work for us.
/// First of all, if we override the Equals method, we should also override GetHashCode,
/// so their implementations are consistent. Eqal objects must have the same hash code.
/// 
/// For example, if we consider two objects equal because they have the same IDs, then those objects should
/// also have the same hash codes.
/// 
/// It means that GetHashCode method should only use the ID property to calculate the hash code.
/// 
/// This works both ways, so if we override the GetHashCode, we should also override equals.
/// 
/// 
/// Secondly, if we want to use a type as a key in the hashed collections and we are not happy with the
/// default implementation. This is most often the case
/// for reference types for which the default implementation based on the reference is not often what we
/// want.
/// 
/// For example, if we want two person objects with the same IDs to be considered the same key in the dictionary,
/// we will have to override the GetHashCode method in the Person class.
/// 
/// For structs, it gets a bit complicated.
/// They support value-based GetHashCode method already so we could think we can let it be.
/// But then if we intend to use a struct in hashed collections, we should override its Equals method anyway
/// for performance reasons because the hashed collections also use this method quite a lot.
/// 
/// But as we said, if we override the equals method, we should also override the GetHashCode. And also
/// the default implementation of the GetHashCode method for structs is complicated.
/// 
/// Long story short, it comes in two versions.
/// It will either be fast, but with a big chance of creating hash code conflicts or it will be slow,
/// but with fewer conflicts.
/// And the more hash code conflicts we have, the slower our hashed collections work.
/// We don't have much control over what version will be chosen, so the safe choice is to override this
/// method anyway.
/// 
/// Let's see how it's done in the next lecture.
/// 
/// 
/// 
///