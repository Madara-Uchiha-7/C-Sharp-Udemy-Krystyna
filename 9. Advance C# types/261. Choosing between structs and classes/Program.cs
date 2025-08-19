///
/// Choose struct over class if:
/// 1. When you want to use value type semantics.
/// 
/// 2. Typically, we use struct to design data-centric types that provide little or no 
/// behavior. Since structs are stored in stacks and frequently copied, they should be small.
/// Below is the example that should rather be struct.
/// Since it is basically a container for only 2 integers. 
/// Also if we don't want a situation when I pass a Point to a method, and this method modifies 
/// it, it alters my original point.
/// 
struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString() => $"X: {X}, Y: {Y}";
}

/// 
/// 3. If we check 2 reference type objects for equality, the reference get compared. 
/// That is 2 seperate objects are compared even if they have the same data. So it will return the false.
/// So, 
/// Person p1 = new Person(1, "John");
/// Person p2 = new Person(1. "John");
/// p1 == p2 will return the false.
/// This is not the case with the Structs. So here if Person is the struct object then it will return 
/// the true.
/// 
/// 4. We know that boxing and unboxing come with a performance penalty. 
/// Suppose the type we design to be often treated as an object, in that case we should not 
/// make it a struct because as such it would need to be boxed frequently, which will impact the 
/// performance. Here in point 4, sentence "often treated as an object", I think means we make pass 
/// the struct to some methods which are considering i.e. they have the logic which is written for 
/// the references. So, each time passing the Struct, will have to make the struct object a
/// reference using the boxing.
/// 
/// 5. If type is a container for data of reference types, it is fishy to make it a struct and 
/// that type should rather be a class. For example:
///
struct FishyStruct
{
    // As you can see FishyStruct is struct type and Numbers is the reference type.
    public List<int> Numbers { get; init; }
}
///
/// Now if you create the instance of this struct and assign it to another instance.
/// FishyStruct fishyStruct1 = new FishyStruct { Numbers = new List <int> {1, 2, 3} };
/// FishyStruct fishyStruct2 = fishyStruct1;
/// Now fishyStruct1 is a value type and it has value type symatics, so if you change the 
/// list from fishyStruct2, it will change the list from the fishyStruct1 also.
/// Since the List is of reference type, only reference of this list is copied when struct is copied.
/// There is a exception to this. Strings are reference types but often behaves like the reference types.
/// Teacher did not go to details for this string part because there is a whole section dedicated 
/// for the strings. So main thing is, having a string in a Struct is fine even though it is a
/// reference type.
/// 
/// Note : It is a good practice to make a struct immutable. So if we are certain that a type we 
/// define should be mutable, we should rather make it a class.
///