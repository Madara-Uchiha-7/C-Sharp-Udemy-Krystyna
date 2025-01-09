///
/// This will also teach us what hash tables are.
/// We will also know why overriding the GetHashCode and Equals methods together is so important.
/// 
/// Underlying data structure of Dictionary is a hash table. It is basically an array of linked list.
/// For each index one whole linked list will be present. Some of those linked lists will be empty and some will have different lengths.
/// 
/// When we create a new dictionary, it will be empty. It creates a array of empty linked lists and it has a certain initial length. 
/// What length exactly will be the implementation detail.
/// Lets assume that it is 5.
/// If we say dict.Add("Usa" , "Usd");
/// It will start calculating the hash code of the key. Lets say the hash code is 123 for "USA". Since this is not the valid index in the array
/// the dictionary will calculate the modulo of hash code i.e. index = hash % arrayLength;
/// Here 123 % 5 will be 3. This means the dictionary will palce the valus "Usd" in the linked list stored under the index 3. 
/// Key = "Usa" hash = 123 value = "Usd" index = 3
/// Lets say you add more like 
/// For index 0 : key : poland, hash : 110, value = PLN 
/// For index 4 : key : italy, hash : 44, value = EUR
/// And assume that next one is 
/// Key Brazil with hash 103. Now the 103 is again comes under index 3 by doing % 5. 
/// So this time the old linked list will get new node. 
/// It may also happen that same hash code is there for new entries too. In such cases the value will be placed in the same list with these
/// same hash code nodes. 
///  
/// When you try to access the dictionary value using the key then 
/// it calculates the hash for that key. Then does that hash % 5 = index.
/// Then it goes to that index. This way it knows in which linked list to search the value. 
/// If there are more that 1 nodes in the linked list then it will have to traverse the linked list.
/// While iterating it will check node.hashValue == dict.key.hashValue or not. 
/// If not same then it moves to the next node. If the hash code matches then it checks if the node.key == dict.key using Equals method.
/// Like node.key.Equals(dict.key)
/// It has to check the keys also because duplicate hash may present. 
/// 
/// Why use hash to compare then check the key:
/// Because directly comparing the Key using the Equals() takes more time than checking the hash value.
/// Remember keys are not necessarily strings every time, they can be more complex like class objects.
/// 
/// This is why GetHashCode and Equals methods must be overriden together.
/// If 2 objects are considered equal, their hash codes must be the same (i.e. the object in dictionary and the object i.e. node in list).
/// If they are not then it means that after we identify the linked list using the hash code % index, no item to the key will be found in that list.
/// In simple terms, since before equal we need a hash code, while overriding we will also need to implement the GetHashCode and then 
/// overriding of Equals too to check the keys.
/// 
/// Dictionaries are not ordered collection.
///
