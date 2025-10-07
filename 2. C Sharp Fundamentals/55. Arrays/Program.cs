///
/// We will understand the purpose of the index from end operator(^).
/// We will also learn how to easily fill a new array with items using the array initializer.
/// Finally, we will see what is the greatest disadvantage of arrays is.
/// 
/// The array is the most basic collection type in C#, storing multiple elements of the same type.
/// We said that a variable is like a box storing a value of a given type.
/// An array is like a collection of boxes, each storing a variable, all of the same type.
/// Arrays are collections of fixed size, so once an array is created, its size cannot be changed.
/// 
int[] number;
/// To declare an array type we must write the type of elements we want to store in it, followed 
/// by the square brackets. For now, we only declared a variable of array type.
/// Let's now initialize it with a new array of size three.
number = new int[3];
///
/// 
/// We can do both at the same time
///
int[] numbers = new int[3];

///
/// The new keyword. Array is a class, and to create instances of classes, we must use this keyword.
/// After the new keyword, we write the type of elements that will be stored in the array, and in the brackets
/// we put the size of this array.
/// 
/// For now, we don't say what values exactly will be stored in it, but it doesn't mean this array will
/// be empty.
/// 
/// It will be filled with the default values for the type it stores.
/// For integer, the default value is zero.
/// So right now this array holds three zeros.
/// 
/// You can access the array elements using indexes.
/// The index of array starts from 0. So, to access the first element of the array, you need to use 
/// the 0 not 1.
Console.WriteLine(number[0]);
/// 
/// 
/// You can update the values in the array:
number[1] = 10;
Console.WriteLine(number[1]);
///
Console.WriteLine(number.Length);
/// 
/// Length property will give us the number of elements present in the array.
/// Lets get the last and second last elements from the array.
Console.WriteLine(number[number.Length - 1]);
Console.WriteLine(number[number.Length - 2]);
/// 
/// We can do same using ^ operator.
Console.WriteLine(number[^1]);
Console.WriteLine(number[^2]);
///
/// We used the caret symbol. 
/// As you can see, it gave us the same element as if we used the index equal to the length of this array,
/// minus the number given here.
/// 
/// If we know the elements of the array upfront, we can initialize the array like this.
int[] numbers2 = new int[] { 2, 3, 4, 5 };
///
/// As you can see in this case, we can skip the size of the array as it is inferred from the count of
/// elements we provide.
/// 
/// We can even skip the type of the array as it is also inferred from the type of elements.
var numbers3 = new [] { 2, 3, 4, 5 };
/// 
/// 
/// Array size is fixed.
/// We must know upfront how many elements the array will hold.
/// Also, we can't just remove some elements and make it an array of size 2 or 1.
/// There are many use cases when this is a problem.
/// For example, imagine an online store.
/// We could have an array holding the items that the user has added to the shopping cart.
/// But what size should it be? 
///
/// Later in this section, we will learn about lists which are collections of flexible sizes.
///