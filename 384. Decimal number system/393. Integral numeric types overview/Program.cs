///
/// We will take a close look at integral numeric types.
/// We already know two of them.
/// int and long.
/// Long works like int, but it is stored on 64 bits, not 32.
/// Because of that, its range is much larger, which we can see here.
/// Min value :
/// -9 223 372 036 854 775 808
/// Max value:
/// 9 223 372 036 854 775 807
/// 
/// In case you need to measure the size of the universe in nanometers, you can always use the BigInteger
/// type.
/// 
/// BigInteger type:
/// Bits : Varies
/// Min Value and Max value:
/// This type is actually not stored on a fixed number of bits, and it is only limited by the amount of
/// memory of your computer.
/// 
/// There are two more integral types that are sometimes useful.
/// First is sbyte; a tiny numeric type stored on a single byte.
/// i.e. 8 bits : 
/// Min:
/// -128
/// Max:
/// 127
/// 
/// It is quite handy when we want to save memory and we have numbers that are fine to be limited to very
/// small values.
/// As an example of a use case for a sbyte, teacher once needed to create a number to represent the order in
/// which some calculations would happen.
/// There would be at most 30 of those calculations, so using sbyte was more than enough to describe their
/// order.
/// 
/// If sbyte is too little but integer seems too big, we can also use short.
/// Short occupies two bytes.
/// Min:
/// -32 768
/// Max:
/// 32 767
/// 
/// For example, we could use it to represent the number of subway stations in a city. Byte it would be
/// too small for large cities, but short would be more than enough.
/// 
/// All those numbers also have their unsigned counterparts.
/// They cannot represent negative numbers, but because of that, we don't need to use one bit for the
/// sign.
/// That's why they can represent larger positive numbers.
/// 
/// Type        Min                 Max
/// ulong       0                   18 446 744 073 709 551 615
/// uint        0                   4 294 967 295
/// ushort      0                   65 535
/// byte        0                   255
/// 
/// The smaller types are used mostly in cases when we need to minimize memory usage.
/// Teacher once needed to reduce the amount of memory an application consumed from over 80GB to less than 10.
/// In the original implementation, all integral numbers were represented as longs. Changing some numeric
/// types to ints shorts or bytes in places where it was safe
/// actually saved me a couple of gigabytes because this application was processing huge data sets full
/// of numbers and it was loading them all into memory.
/// Type        Memory Used 
/// ulong       x
/// uint        1/2 x
/// ushort      1/4 x
/// byte        1/8 x
/// 
/// So as we see, we have quite a lot of types to represent numbers, but none of the ones we see here
/// can store fractions.
/// Let's talk about numbers like that in the following lecture.
/// 
/// 
/// 
/// 
///