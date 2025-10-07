///
/// We will understand how they differ from arrays.
/// We will learn the most crucial methods we can use with lists.
/// 
/// As we learned in the lecture about arrays, they have one major disadvantage.
/// Their size is fixed.
/// Once an array is created, its size cannot be modified.
/// An array of three elements will always be an array of three elements.
/// 
/// That's why arrays are most useful in cases when we know the size of the collection upfront.
/// 
/// The simplest solution is to use a list.
/// List is a collection of elements of a given type whose size is not fixed.
///
List<string> strings = new List<string>();
///
/// Get the number of elements present in the list:
Console.WriteLine(strings.Count);
/// 
/// List is a class, so similarly to the array,
/// we must use the "new" keyword to create it.
/// Please notice the angle brackets we used to declare what type of elements will be stored in this list.
/// 
/// Angle brackets are related to generic types and list is a generic type.
/// 
/// Lets add the values in this list.
/// 
strings.Add("Helloo");
strings.Add("Helloo hiii");
/// 
/// We used the Add method.
/// Naturally, this code would not compile if I tried to add a value of a different type than string.
/// We successfully resized the list, so we did something we could never do with an array.
/// 
/// Please notice that we can initialize the list with some items right at the moment of its creation similarly
var strings1 = new List<string>
{
    "One",
    "Two"
};
/// 
/// 
/// We can access the lists element at a given index the same way as we do with arrays by using the square
/// brackets.
/// 
/// We can update the list element value like:
strings1[1] = "Updated Two";
/// 
/// 
/// Remember that list size change over time.
/// So, for example, if the last element of this list is removed, it would then only have one element
/// and the only valid index would be zero.
/// 
/// Now let's remove an element from this list.
strings1.Remove("Updated Two");
/// 
/// We passed the element we wanted to remove from the list as the argument of the Remove method.
/// The remove method simply does nothing if the list holds no element matching the given argument.
/// So far we have learned about two methods the list exposes: the Add and the Remove methods, as well as the
/// Count property.
/// 
/// When we write a dot after the list variable
/// Visual Studio shows us all methods and properties we can use.
/// For now, let's see some of the most basic methods we can use with lists.
/// Firstly, the RemoveAt method.
/// It works similarly to the Remove method, except that it takes an index of the element we want to remove.
/// strings1.RemoveAt(0);
/// 
/// Please notice that the RemoveAt method is unforgiving
/// if we provide an invalid index exceeding the bounds of this list.
/// When using it, make sure to provide a valid index.
/// 
/// Lets see .AddRange()
/// This method takes a collection as a parameter and adds all its elements to the list.
strings1.AddRange(strings);

///
/// IndexOf method:
/// It allows us to get the index of a given element in the list.
Console.WriteLine(strings1.IndexOf("Helloo"));
///
/// If the value is not present in the List then this method will give:
/// -1, special value indicates that such an element does not exist in the list.
/// 
/// There is another method that allows us to check if an element exists in the list.
/// The Contains method.
/// strings1.Contains("Helloo"))
/// 
/// It returns true or false.
/// 
/// strings1.Clear()
/// will remove all the elements from list.
/// 
///