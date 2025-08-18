// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// All static classes are implicitly sealed.
// So we can not have the classes derived from them.
// Why?
///
/// Static classes contains only static methods.
/// and static methods can not be overriden (even if they does not belong to 
/// staic class). 
/// Why we can not override the static methods:
/// The whole point of overriding is to have a specific implementation of method
/// used when executed on specific instance. 
/// But static methods are not called on instances, they are same of any instance of class.
/// Because there no specific implementation to a certain type of instance.
/// So overriding does not make sense.
/// Since static classes can only contain static methods, there is not point 
/// in inheriting from static class.
/// So static classes are always sealed.
///