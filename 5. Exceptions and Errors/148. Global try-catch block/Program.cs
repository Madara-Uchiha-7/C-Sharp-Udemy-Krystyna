// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// If the assumptions a method operates on are not met, it is fine to throw an exception
// because it is a situation when a developer made a mistake that needs to be fixed.
// We also said that a method should only handle an exception when it can do it in a reasonable way.
// If it can't, the exception should not be caught at all or it should be rethrown.
// Those two things together may mean that some exceptions in our application will simply be unhandled.
// But if an exception is not handled, the application will
// crash, confusing the user and not giving them a chance to understand what happened.
// The solution is to add a global try-catch block that can catch an exception not caught elsewhere, show
// it to the user and then shut the application down gracefully.
// This is the last resort of error handling, we must expect any exceptions.
// A global try-catch block is a special place where catching the System.Exception is fine.
// Write try {// Main code logic} catch(Exception ex) {// log the error : ex.Message property is used to get the message in the error.} 


// Adding a global try catch block allows us to catch the exception
// that is not caught elsewhere.
// It should surround the entry point of the application.
// Entry point is the first method that is called which also calls
// other methods.
// In the console application it is the main method in the program class.
// For e.g. there will be other calls to the methods which are present in other class files.
// But if the call to those methods are going from the Main method then the code in the main method or
// the code which is calling the method should go in the try catch block.


