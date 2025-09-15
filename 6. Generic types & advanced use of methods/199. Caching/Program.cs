///
/// Caching is a mechanism that allows storing data in a temporary storage area.
/// So next time it is needed, it can be served faster.
/// 
/// Imagine an app for analyzing personal data.
/// It might be the case that we keep opening a tab with someone's data repeatedly because we keep having
/// something to do about this particular person.
/// In this case, the request to access personal data identified by some specific ID will be repeated many
/// times.
/// So instead of downloading the resource identified by a given ID many times, we could download it once
/// and store it in memory.
/// 
/// Of course, assuming the underlying data has not changed.
/// But this is what we assume here.
/// Next time some resource is needed, it will be served immediately from memory instead of being downloaded
/// Such a mechanism is called caching.
/// 
/// Since all the cached items will be stored in memory,
/// memory consumption will increase.
/// 
/// So caching is like a trade.
/// We agree to use more memory and in exchange we get faster execution time.
/// 
/// This means caching is not always a good idea.
/// 
/// Remember, the program memory occupies your computer's random access memory called RAM.
/// But there are ways to reduce the cache size.
/// 
/// For example, items that were added to the cache a long time ago can be removed to make room for new
/// items.
/// 
/// Caching is great, but for some scenarios only. Suppose we don't retrieve the data identified by the
/// same key repeatedly, but we keep using different keys to access different data all the time.
/// In that case, caching doesn't give us anything, but it still increases memory consumption.
/// So use caching when it really makes sense.
/// 
/// Caching is most often used to retrieve data from some external sources, but remember that even the
/// data calculated locally can be cached.
/// For example, imagine your program does some performance-costly mathematical operations, or some complex
/// image processing that takes a lot of time.
/// In this case, you could consider caching the results instead of calculating the same thing repeatedly.
/// 
/// Also, remember that the underlying data can change after it has been first retrieved and stored in
/// the cache.
/// 
/// It means the cache will be providing us with stale data.
/// That's why caching is best when the underlying data doesn't change often.
/// 
/// In this case, we could have some mechanism that removes the piece of data from the cache after some
/// specific time has passed.
/// 
/// Also, some data sources can give us information about when was the last time the data identified by
/// some key has changed.
/// In this case, we can compare this time with the time of the storing this data in the cache to know
/// if it is stale or not.
/// 
/// 
///