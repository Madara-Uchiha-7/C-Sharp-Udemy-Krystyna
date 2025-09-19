///
/// We will also understand what pure functions are.
/// We will also discuss the downsides of immutable types.
/// 
/// We've already learned what immutable types are.
/// They are types that once created, cannot be modified.
/// So the concept of immutable types is very simple.
/// It can extend to more complex types, for example, collections.
/// 
/// Once we create an immutable collection, none of its elements can be added, removed or altered.
/// 
/// The question is, why should we bother creating immutable types?
/// First of all, immutable types let us create clear and simple code.
/// If the variable is immutable, we do not need to worry and we would be sure that once created its value
/// would remain the same, and we would know right away what would be printed to the console.
/// 
/// Another thing that immutable types make simpler is writing pure functions.
/// Pure functions are functions whose results only depend on the input parameters and have no side effects.
/// I.e. it does not change any variable value which is pesent outside the fucntion.
/// They don't modify the input parameters.
/// 
/// We can call a pure function any time we want with the same set of parameters and it will always yield
/// the same result.
/// 
/// Because of that, we can cache the result.
/// Making the parameters the key of the cache.
/// 
/// Pure functions are simple to understand as we don't need to be aware of the context in which they are
/// called.
/// 
/// Testing them is extremely simple as we only check if the result is as expected.
/// 
/// For testing purposes, we don't need to set up any context in which those functions work, as they only
/// depend on the input parameters.
/// 
/// Please be aware that I am not only talking about automated tests, which we will learn about later in
/// the course, but also manual tests.
/// If we write a method and we want to make sure it works as expected, we can, for example, call it
/// with some parameters and check if the result printed to the console is correct.
/// 
/// 
/// Using immutable types and creating pure functions work very well together.
/// They are two tenets of functional programming, a coding paradigm that grows more and more popular for
/// its clarity, as well as working great in multi-threaded applications.
/// 
/// Which actually leads us to the next point.
/// For now, we don't focus too much on multi-threaded applications.
/// Still, we can discuss the benefits of immutable types in their context.
/// 
/// The thing about having multiple threads is that they can all modify the state of some object at the
/// same time.
/// That's why, when working with Multi-threaded applications, we must always be very cautious when making
/// assumptions about the state of an object, because it can always be the case that another thread alters
/// its state without our knowledge.
/// 
/// Using immutable types wipes this problem out.
/// If an object cannot be altered, there is no need to worry that some thread altered it.
/// This makes the creation of Multi-threaded applications much simpler and less error-prone.
/// 
/// And you must know that finding bugs in multi-threaded applications can be extremely hard as they often
/// happen in a non-deterministic manner that can be very hard to reproduce.
/// 
/// Another benefit of using immutable types is that they can make it easier to avoid having invalid objects.
/// 
/// For e.g.
/// One class can have constructor that have null checks.
/// But we can later on change the value of that class Property using that class object.
/// Which makes the null checks pointless. 
/// But using immutable will avoid this.
/// You can argue by saying that we can add the same null checks in the method like the constructor.
/// But this will be a code duplication because the same code is already added in the constructor.
/// It will also create a lot of noise in the code, making it harder to understand, maintain and test.
///
/// Because whenever we want to test code that uses this type, we will have to write tests for both valid
/// and invalid class objects or do such tests manually.
/// The easier testing is another benefit of immutable objects.
/// 
/// But before we move on to this point, let's consider another aspect of making objects invalid, which
/// is identity mutation.
/// 
/// Imagine we want to use the Person class object as the key in a dictionary.
/// We want to use the person's ID as the hash code that the dictionary will use.
/// var dictionary = new Dictionary<Person, string>();
/// dictionary[person] = 10;
/// This looks simple, but what if the ID is mutable?
/// We can actually lose this object in the dictionary.
/// If you do:
/// person.Id = 20;
/// Then if you add below line, you will get the error:
/// Console.WriteLine(dictionary[person]);;
///  
/// As a rule of thumb, if an object is meant to be a key in the dictionary, it should be immutable.
/// Or at least those fields and properties that are used in the GetHashCode method should be immutable.
/// 
/// The last benefit of immutable types is easier testing.
/// Immutable objects make code easier to understand, and they also give us a guarantee that once a valid
/// object has been created, it will remain valid forever.
/// This makes testing much simpler because we have fewer paths of code to test as handling invalid objects
/// is simply not needed.
/// As mentioned before, using immutable objects makes it easier to create pure functions and they are
/// very simple to test.
/// 
/// Seems like immutable objects can be really beneficial, but following this "nothing ever changes"
/// rule can be demanding.
/// After all, we sometimes need to change something.
/// But in such cases, remember about the non-destructive mutation that produces a new changed object instead
/// of modifying the existing one.
/// 
/// But we must also be aware of the important disadvantage they have: with the non-destructive mutation
/// each update of an object actually creates a new object allocating new memory.
/// If we operate on reference types, the old object must be cleaned up by the garbage collector.
/// It is usually not an issue with small types.
/// But remember even collections can be immutable.
/// Imagine having a list of million elements and that adding a new item to this list means actually building
/// a whole new collection of size million and one.
/// 
/// It may sound scary, but don't be discouraged from using immutable types.
/// First of all, there are implementations of collections that actually make the non-destructive mutation
/// quite efficient.
/// 
/// Secondly, not all applications suffer from performance loss when using immutable types, and the benefits
/// are often bigger than the costs.
/// 
/// Garbage collector is a smart tool and most often you won't even notice the performance impact of introducing
/// immutable types.
/// 
/// Nevertheless, there are cases when performance is critical.
/// For example, I wouldn't recommend making every type immutable when developing video games as it would
/// make the garbage collector kick off more often.
/// And remember that when garbage collector works, it may freeze all other threads. In the case of games
/// it could lead to a performance decrease that would be noticed by the players.
/// 
///