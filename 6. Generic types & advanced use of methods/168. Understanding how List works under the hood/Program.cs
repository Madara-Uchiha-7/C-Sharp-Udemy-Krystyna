// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

///
/// Data structures are the types which are ment for storing and 
/// organizing data so that it can be accessed and modified 
/// efficiently.
/// List is the data structure.
/// Arrays, Stacks, queues or dictionaries are 
/// also the data structures.
/// List uses array as its underlying data structure.
/// T[] _items;
/// Each list object has a private array in which elements are
/// stored.
/// List tracks how many elements it currently stores using 
/// the int _size field. 
/// Lets say List class in background has initial array of size 4.
/// So, even if you add only 3 elements the one space will remain.
/// If you add 4 elements then new array is created with the size 
/// 8. This new array will replace the old array.
/// This above process takes time and creates more load
/// on memory usage.
/// If you remove middle element from list 
/// then in backend the array will move necessary items 
/// to the left to fill that place.
/// This also cause performance issue.
/// Using big list will cost performance issue.
/// This List is defined in 
/// System.Collections.Generic namespace.
/// 