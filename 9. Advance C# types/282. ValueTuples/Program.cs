/// 
/// We will learn what ValueTuples are and how they are different from tuples.
/// Tuples are small data structures used to bundle a couple of pieces of information together.
/// This can be useful when, for example, we want to create a method that needs to return two pieces of
/// information without declaring a dedicated type for the result.
var tuple1 = new Tuple<string, bool>("aaa", true);
var tuple2 = Tuple.Create(10, false);
/// The first one is created using the constructor and the second one with the Tuple.Create static method.
/// The benefit of using this method is that it doesn't require specifying the type parameters.
/// It infers them from the given arguments.
/// 
/// We can access the components of a tuple using its properties called Item1,
/// Item2 etc.
var number = tuple1.Item2;
/// The maximal number of elements in a tuple is eight.
/// Please notice that tuples are immutable.
/// All their properties are readonly.
/// So,
/// tuple1.Item1 = "Hii"; 
/// will not compile.
/// 
/// The important thing to know about tuples is that they are reference types.
/// Let's see how the equality operator,
/// the Equals method and the GetHashCode method is implemented for them.
var tuple3 = Tuple.Create(10, false);
Console.WriteLine(tuple2 == tuple3);      // False
Console.WriteLine(tuple2.Equals(tuple3)); // True
Console.WriteLine(tuple2.GetHashCode());  // 330
Console.WriteLine(tuple3.GetHashCode());  // 330

/// As you can see, tuples support value-based Equals method, but the equality operator compares them by
/// reference.
/// Also, they have a value-based GetHashCode method implemented.
///
/// As it turns out, there is another kind of tuples in C sharp, the ValueTuples.
/// On the conceptual level, they serve the same purpose as tuples, so they bundle a couple of values together.
/// But as you probably guessed from their name, they are value types.
/// Let's create a ValueTuple.
/// We could do it with a constructor like this:
///
var valueTuple = new ValueTuple<int, string>(1, "bbb");
// Or we can create them in more easier way:
// As you can see, the creation of a ValueTuple looks much nicer than the creation of a tuple.
var valueTuple2 = (1, "bbb");
Console.WriteLine(valueTuple == valueTuple2);      // True
Console.WriteLine(valueTuple.Equals(valueTuple2)); // True
Console.WriteLine(valueTuple.GetHashCode());  // 741366306
Console.WriteLine(valueTuple.GetHashCode());  // 374136630630

/// 
/// Let's discuss the differences between tuples and value tuples.
/// ValueTuples only support value-based equality since they don't have references.
/// They also have an efficient, value-based GetHashCode implemented. 
/// The fact that regular tuples are reference types can have negative performance implications.
/// Tuples are usually short-lived objects, and if we create many of them, allocating and freeing the
/// memory may take considerable time.
/// 
/// This was one of the reasons why ValueTuples were introduced with C# 7.
/// The next difference that we must be aware of is that tuples are immutable and ValueTuples are mutable.
/// 
/// The difference that probably matters most for us as developers is that when using ValueTuples, we
/// can give names to the fields they contain and we don't need to use those awkward Item1 and Item2
///
var valueTuple3 = (Number: 10, Text: "Hiiii");
valueTuple3.Text = "How are you";
valueTuple3.Item1 = 6;
/// 
/// As you can see, we still can use Item1 or Item2, but we can also use named tuple items.
/// 
/// The last difference is that we can create ValueTuples with more than eight elements.
/// 
/// When a lot of short-lived tuples are created, it may decrease the performance of the application as
/// the memory management for reference types is more demanding than for value types.
///