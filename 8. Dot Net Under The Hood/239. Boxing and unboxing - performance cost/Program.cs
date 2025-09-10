// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------


// Unlike regular variables assignment, boxing is a performance-heavy operation.
// It requires the creation of a new object and allocating memory on the heap for it.
// The unboxing requires a cast, which is also expensive from the performance point of view.
// Also remember that for value types the reference does not exist and the reference itself also occupies memory.
// It takes 32 bits, so 4 bytes on 32-bit systems and 64 bits, so 8 bytes on 64-bit systems.

// Teacher story:
// I was given a task of improving the performance of a certain application.
// This application took a huge CSV file as an input.
// CSV is a bit similar to Excel files, so it is just a table with rows and columns of data.
// Most of this data was value types, mainly integers and floats, but there were some strings too, and
// strings are reference types.
// The original application attempted to load this whole table into memory, and this table had thousands
// of columns and tens of millions of rows.
// Since the values inside this table were of various types, the original developers decided the only
// way to store them was to save each cell's value as an object.
// This meant billions of boxing operations were executed because each of those numerous integers and floats has to boxed.
// Each of those boxing operations took some time to be done, and it also created a new reference in memory.
// The program was crashing for big files.
// The analysis showed that if the program loaded the whole table correctly, the references alone would
// occupy more than 80GB of memory.
// The solution was not to box those billions of value types variables, but to store the table in a specialized
// data structure that held integers in an integer container, floats in a float container etc.
// This story can teach us to be careful with boxing, especially if we operate on big datasets.

// In the lecture about ArrayLists we mentioned they have worse performance than lists for certain types.
// We now know the names of those types : the value types.
// If you have an ArrayList or even a List of objects and you put value types inside, each of them must
// boxed.
 
using System.Collections; // For ArrayList

// For a list of integers, boxing doesn't need to happen because this list doesn't store its items as objects.
// It knows they are ints, so it keeps them in an array of ints.
List<int> number1 = new List<int> { 1, 2, 3, 4, 5 };

// Behind the scenes, five boxing operations happen in this line because for ArrayList.
ArrayList number2 = new ArrayList { 1, 2, 3, 4, 5 };
// This performance difference would not be the case if all items in the ArrayList were reference types.
// In this case, boxing would not be done and the performance of an ArrayList would be similar to the list. 

// Also, remember that boxing happens when the target type is any reference type, not only an object.
// For example, boxing also happens when assigning value types to interface types.
// 
List<IComparable<int>> number3 = new List<IComparable<int>> { 1, 2, 3, 4, 5 };
// In this case, five boxing operations will happen because IComparable of int is a reference type as
// all interfaces are.

// Does boxing happen in this code?
object asObject = number1;
// No
// Correct. Boxing happens when we wrap a value type in a reference type.
// Here, we assign a List object to a variable of object type,
// but List is a reference type, so no boxing needs to happen.
// If "numbers" was, for example, an int, it would have to be boxed.