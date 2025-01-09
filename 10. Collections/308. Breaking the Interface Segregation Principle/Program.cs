/// 
/// 
/// 

int[] array = new int[] { 1, 2, 3};

// For "implementedInterfaces" line try adding a breakpoint below it and check what comes in implementedInterfaces.
// You will see System.Collections.Generic.ICollection at one place which says that array implements the 
// ICollection of int interface. But this interface includes the Add method. Which means array must have implemented it.
// But if you try to do array.Add() it won't work.
// This is possible because array imeplements the ICollection<T> interface but it does that explicitly.
// This means we can only call this method if we operate on a variable of the ICollection<T> of int type.
// Example after below line.
Type[] implementedInterfaces = array.GetType().GetInterfaces();

ICollection<int> arrayAsCollection = array;
arrayAsCollection.Add(1);
// "arrayAsCollection" reference is still an Array under the hood. We only used it in the polymorphic way.
// This above is possible because the Array implements the ICollection<T> interface.
// But the line "arrayAsCollection.Add(1);" will fail at compile time. because the array size is fixed.
// This is called as the bad designing. Because this is the violation of SOLID Principle.
// So only implementation which could be provided in such situation is an implementation stab that looks like :
// Code from Array Class
// private void Add<T>(T _)
// {
//     // Not meaningful for arrays.
//     ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_FixedSizeCollection);
// } 

Console.ReadKey();

