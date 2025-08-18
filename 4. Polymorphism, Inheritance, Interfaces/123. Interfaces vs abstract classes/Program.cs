// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// Interface
/*
 * Defines the set of opeations that implementing type must provide.
 * It does not provide an implementation on its own.
 * It does not contain any data.
 * Can not be initiated.
 * All methods are implicitely public. 
 * Can not contain sealed and static method.
 * Methods are implicitly virtual.
 * Can only contain methods or property definitions.
 * Interface can not be static.
 * 
 * Abstract class:
 * Blueprint for derived classes, representing a general category of things.
 * May provide the implementations in non-abstract methods. Can also have abstract methods.
 * Can contain data.
 * Can not be initiated.
 * Non-Abstract methods can have diff. access modifiers.
 * Can contain sealed and static method.
 * Non-Abstract methods are not implicitly virtual.
 * Can also have implementations, fields and constructor.
 * Abstract can not be static.
 */


// List class uses the ICollectionn interface, which has Add, Contains, Remove, Clear...etc.
// Like List some other collections also uses ICollection.