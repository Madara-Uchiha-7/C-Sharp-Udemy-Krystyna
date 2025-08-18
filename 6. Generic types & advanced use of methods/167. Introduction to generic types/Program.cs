// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

///
/// Whenever we see angle brackets like < >, it means 
/// we are dealing with the generic types or methods.
/// For e.g. the list class is the generic class
/// List <int> list = new List<int>();
/// Here at the place of int, we can also use other data types.
/// Generic types or methods are parameterized by other types.
/// If you take a look at List class then it will look something
/// like :
/// public class List<T> : IList<T>, IList, IReadOnlyList<T>
/// The <T> is what allows us to make the class generic.
/// These angle brackets means that List will be parameterized 
/// by type.
/// The IList<T> interface extends IEnumerable of <T> interface.
/// The T means type. 
/// Generic types are like templates of classes.
/// We can define generic classes, generic methods and generic
/// interfaces.
/// 
