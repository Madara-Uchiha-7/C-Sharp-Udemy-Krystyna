///
/// We'll see when we should put code in a try-catch block and what a catch block should do.
/// 
/// We catch exceptions when we have something meaningful to do about them.
/// E.g.
/// We use a library for reading data from a database.
/// It's not our code, and we didn't decide how it behaves.
/// As it turns out, it throws an exception when a person with a given ID is not present in the database,
/// but for our needs,
/// we would rather want this method to return null as we don't consider it an exceptional situation when
/// the person is not present. We are okay with handling the null result.
/// We can adapt the behavior of this method by simply catching this exception and returning null from catch.
/// 
/// Another example could be some retry mechanism.
/// Here we have a method that tries to save a person object in a database, but this database is not local
/// to our machine, but it lives on some remote server.
/// The server may sometimes have a lot of work because many users interact with it in the same time.
/// In this case, this method may throw a timeout exception, meaning that it could not finish its job
/// in a given time.
/// We may decide that we want to try again after waiting for a couple of seconds.
/// We could put this method in a try-catch block which would be placed inside a while loop.
/// If a timeout exception is caught, we reduce the number of retries left by one, wait for some time,
/// and then go back to the beginning of the loop to try to save this object again.
/// 
/// 
/// A special case of error handling is the global try-catch block.
/// It catches all exceptions thrown elsewhere, usually shows them to the user in some well-formatted way,
/// writes to logs and shuts the application gracefully.
/// 
/// Another use case when we may want to catch exceptions is when we want to rethrow them, which means
/// we want to process them somehow and then let them be thrown again.
/// 
/// e.g.
/*
catch(JasnException)
{
    Console.WriteLine("Could Not prase this JSON.");
    throw;
}
*/
/// They will either be caught by some other catch block, or if none other does, so by the global catch.
/// 
/// The question is when it makes sense to rethrow an exception.
/// Let's say we have a very simple method which asks the user to enter a string and then prints the count
/// of characters it consists of to the console.
/// It has a global try-catch block that catches all unhandled exceptions and writes them to the console.
/// That method is called from global try catch.
/// Technically, word.Length line may throw an exception if the user presses Ctrl+Z when asked to enter a word,
/// as in this case, the word variable will be null and using the length property on it will throw
/// a NullReferenceException.
/// 
/// We consider such a scenario exceptional and we don't want to handle it by, for example, asking the
/// user to enter the word again.
/// 
/// We want the application to stop.
/// Our method also has its try catch. In which we catch NullReferenceException.
/// Write some message using Console.WriteLine("The input is null and lenght can not be calculated. Did you press Ctl +Z") 
/// So in this case, the local code block can handle the exception more precisely than the global one.
/// If it isn't the case and the local catch block has nothing more to say than the global one, it's better
/// just not to define it at all and let the exception be caught by the global try catch.
/// So lets not add the thorw; in the local catch in this case.
/// 
/// 
/// Also, it is usually the global catch block that performs logging.
/// E.g. logger.log(ex); in the global catch.
/// 
/// 
/// All right, let's summarize good practices regarding catching exceptions.
/// Locally:
/// At the lowest possible level, which means locally, as close to the place of the exception throwing
/// as possible, we should handle specific exception types.
/// We should do it only when we have something meaningful to do about them.
/// For example, returning a default value from a method, retrying to perform some action or adding more
/// information to the exception by wrapping it in another, more specific type or enriching it with a more
/// detailed message. 
/// 
/// Globally:
/// We should not perform logging in local. At the highest possible level, which means in the global catch block,
/// we should catch all exceptions unhandled elsewhere so the application doesn't crash.
/// We should show the exception to the user in some readable way and apologize for the application issue.
/// We should also log this exception with all the details that may help us understand why it happened.
/// The exception caught in the global catch block always means there is something wrong going on in our application.
/// We should investigate it as soon as we can and decide what we can do to avoid it in the future.
/// 
/// 
/// 
///