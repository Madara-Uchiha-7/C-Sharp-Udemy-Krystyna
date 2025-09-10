// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// In this lecture, we will understand why structs should not contain fields or properties of reference
// types and why strings are an exception.
// We've said before that structs should usually not contain fields of reference types.
// We've said before that structs should usually not contain fields of reference types.
// This struct has a property of the list
// type and list is a reference type.


TestStruct test = new TestStruct
{
    List = new List<int> { 1, 2, 3, 4 }
};
TestStruct other = test;

public struct TestStruct
{ 
    public List<int> List { get; set; }
}

// As we know, structs are copied on assignment.
// i.e. TestStruct other = test;
// The operation of copying is nothing complex.
// It is nothing but
// TestStruct other = = new TestStruct
// {
//     List = new List<int> { 1, 2, 3, 4 }
// };
// It simply assigns all fields and properties in the new struct object using the fields and properties
// from the old struct object.
// But let's remember what happens on an assignment like this.
// For reference types only the reference is copied.
// In other words, the list property in the new struct will store the same reference as the list property
// in the old struct.
// This isn't what we expect for structs.
// When one struct is assigned to another, we expect an independent copy to be created.
// If you call the Clear method on the list belonging to the other struct variable,
// it will clear the list in the test struct also.
// That's why it is not recommended for structs to have members of reference types.
// One of the few exceptions is string.
// Strings are fine as properties in structs because they are immutable.
// We cannot modify the string in one of those variables, so it cannot affect the string in the other
// variable.
// You may also think that, hey, we just said a moment ago that strings could be big and they shouldn't
// be stored on the stack.
// So if a string belongs to a struct, won't it be stored on the stack as well?
// No, it will not.
// After all, strings are reference types.
// The structs we have here indeed will be stored on the stack, but they will only have the references
// to strings stored on the heap.
// The reference itself is small, so it's okay to have it on the stack.