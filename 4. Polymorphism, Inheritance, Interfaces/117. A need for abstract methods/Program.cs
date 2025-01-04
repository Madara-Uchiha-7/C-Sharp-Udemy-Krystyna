// Lets say we have the child classes called
// Cat, Dog, Duck.
// And Parent abstract class called AnimalKingdom.
// Now if we remove the abstract method called Legs() from parent.
// But we do have Legs() method in each of the child class.
// Then following code will work.
// Cat cat = new Cat();
// cat.Legs();
// Same as above for Dog and Duck.
// But below code will break:
// AnimalKingdom allAnimals = new List(<AnimalKingdom>)
// {
//      new Cat(),
//      new Duck(),
//      new Dog(),
// }
// Now allAnimals can not access the Legs method of the Cat, Duck and Dog.
// Because it is a child class member.

// Mark methods a abstract:
///
/// If the base type should not or can not provide any default implementation
/// and you want all the children derive their own implementation.
/// Abstract methods can only be declared in the abstract classes.
/// 
/// Virtual Methods but not Abstract:
/// Provide default implementation.
/// May be overriden in derived types.
/// Virtual methods can be decleared in both abstract and non abstarct classes.
