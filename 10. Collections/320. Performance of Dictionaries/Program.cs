///
/// Most of the basic operations of the dictionaries have the excellent performance.
/// Lets see getting the item for certain key:
/// 1. Calculate hash code.
/// 2. Calculate index using hash code % array size in dictionary.
/// 3. The iterate the linked list --> Speed depends on the length of the linked list,
/// 
/// Point 1 and 2 are vary fast with constant time complexity i.e. O(1) 
/// If we implement Hash code very badly making each hash code same then all the items will go in one likned list nodes which will be
/// present at only index of an array.
/// So it is better to or make sure that hash code are created uniformly so the linked lists are created uniformly in array with 
/// equal number of nodes. Making no linked list unnecessarilly big at any array index.
/// So fewer the hash code conflicts, better will be the performance. This getting the right hash code is done by GetHashCode().
/// 
/// Get at key O(1)
/// Check if key exists O(1)
/// Remove at key O(1)
/// Add new item O(1) or O(N)
/// Check if value exist or not : Since hash code will only check if key exists or not using hash, it will not check its value so : O(N)
///