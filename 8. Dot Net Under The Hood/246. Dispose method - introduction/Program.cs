// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------


// The Dispose method is used to free unmanaged resources.
// Well, in C# we distinguish two types of resources: managed and unmanaged.
// Managed resources, as their name suggests, are managed by the Common Language Runtime.
// Most objects we deal in our programs are managed resources.
// The garbage collector is aware of their existence.
// Once they are no longer needed, it will free the memory they occupy.
// This means we don't need to worry about managed resources cleanup as it is done automatically.
// Unmanaged resources are beyond the realm of the CLR.
// The garbage collector doesn't know about them, so it will not perform any cleanup on them.
// Examples of unmanaged resources include database connections, file handlers, or open network connections.
// We as developers are responsible for performing the clean up after we are done with those resources.
// If we don't, bad things may happen.
// For example, if we open a file to read it and we don't close it, the next attempt to open the same
// file will fail with an error saying that the file is currently in use.
// But how to perform this clean up?
// Well, suppose we have a class that uses some unmanaged resources.
// In that case, it should implement the IDisposable interface and provide an implementation of the Dispose Method.
// The Dispose method should contain the code that frees the unmanaged resource.
// For example, closes the database connection.
// Or if you are writing in the file using code and your writing work is done and you have not closed the object,
// then others or you can not edit that file from the file explorer, while saving you will get the error.
