///
/// The purpose of binary search algorithm is to check if item exist in the
/// sorted collection and if so then return its index.
/// If the collection is not sorted then we can not use the binary search.
/// 
/// Working : 
/// Create one varibale for left bound number.
/// then one for right bound number.
/// The left bound will keep the index number  0.
/// The right bound will keep the index number "collection.length - 1".
/// When loop starts we will keep the index (i.e. i from for loop) at
/// (left bound index number + right bound index number) /2.
/// That is we will point at the mid of the collection. 
/// If the input item which we are searching in the collection is not present
/// at mid of colletion then we will check if that input item value is greater than
/// that mid value of collection or smaller.
/// If greater then we will do left bound number = (mid index i.e. i) + 1
/// If smaller then we will do right bound number = (mid index i.e. i) - 1
/// 
/// This reduces the size of the collection by half.
/// When both right bound and left bound becomes same i.e. point to the same
/// index means that will be the last index we are going to check.
/// 
/// If the value is not present at all when both bounds point to the same index
/// then if the value at that index is bigger than the input item 
/// then left bound by index + 1 o.w. right bound by index - 1.
/// But this does not make since to keep going now, 
/// So codition to stop will be left bound index number > right bound index number.
/// 
/// This algorithm is called as divide and conqure strategy.
///