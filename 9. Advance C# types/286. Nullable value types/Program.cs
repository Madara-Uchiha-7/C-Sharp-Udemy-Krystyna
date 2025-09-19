///
/// We will learn what nullable value types are.
/// In general, nullable types are any types that can be assigned null.
/// 
/// As we learned before, only reference types can be assigned null.
/// for e.g.
/// int number = null; will not work 
/// but
/// string str = null; will work.
/// 
/// That's why here assigning null to an integer doesn't work, but it works fine for string, which is
/// a reference type.
/// From the conceptual point of view, null represents a lack of value or missing value.
/// 
/// Many business cases exist when such a special value could be needed for value types.
/// 
/// But we set null to the int.
/// int? number = null;
/// 
/// We can declare our value type as nullable with a question mark.
/// Please notice that using the question mark is just a syntactic sugar for this:
/// Nullable<bool> boolOrNull = null;
/// 
/// Please note that Nullable of T is a struct, which means Nullable is a value type as all structs are.
/// 
/// But wait a minute.
/// We said that we cannot assign a null to value types.
/// 
/// So how is it possible that we assign all to a variable of nullable struct type?
/// Actually, it's a trick of the C# compiler.
/// 
/// Behind the scenes it interprets this code as this:
/// int? number = new Nullable<int>();
/// 
/// As you can see, it's not really assigning a null.
/// Nullable exposes useful properties like HasValue, which indicates whether the value is null or not,
/// or Value, which unpacks the internal value.
/// 
int? number = null;

if (number.HasValue) // You can also do: if (number is not null) {}
{
    Console.WriteLine("Not null");
}

/// Now let's see what will happen if we try to assign a nullable int to an int. 
//  int number1 = number; 
/// The above line will give the compilation error.
/// Because Nullable int and int are not the same types.
/// To do such an assignment, we must unpack the value from the nullable.
/// We can do that using the .Value property.
/// 
int number2 =  number.Value;
/// But this nullable int actually stores null now.
/// 
/// So what will happen here?
/// On runtime line:
/// int number2 =  number.Value;
/// 
/// will throw the error "Nullable object must have ...."
/// 
/// That's why we should only use the Value property if we are certain that the value is not null, which
/// we can check by either comparing it with null or by using the HasValue property.
/// 
/// 
/// An assignment of a non-null value to a nullable variable will work without any extra code.
Nullable<bool> nullable = true;
/// 
/// 
/// What would happen if we tried to declare a nullable of a reference type?
//  Nullable<string> str = null;
/// Above line will give the compilation error.
/// 
/// Nullable generic struct has a type constraint saying that T can only be a value type.
/// public partial struct Nullable<T> where T : struct
/// 
/// 
/// Average method from LINQ automaticallly skips the null values while doing the calculation. 
/// 