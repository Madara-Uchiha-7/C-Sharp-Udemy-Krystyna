
// Continuation of 399.
// In this lecture, we will review the design issues with the notification mechanism we have.
// We will also think about the characteristics of a good notifications mechanism.
// First, this code tightly couples the GoldPriceReader with the two other classes.
// The price reader should not even know those classes exist.
// Also, suppose we introduce a new notifier like some TextMessagePriceChangeNotifier.
// In that case, we will need to add another field to the GoldPriceReader class.
// Secondly, currently we only notify a single EmailPriceChangeNotifier object and a single
// PushPriceChangeNotifier.
// What if we want to notify a whole group of them?
// Lastly, what if some of those objects are no longer interested in being informed about the price changes?
// Now we can't just stop notifying one of those objects.
// 
// Let's summarize the things we would like to achieve here.
// We would like to decouple the classes that notify about some event from the classes that process this
// Also, we would like to easily add new objects to be notified, either of a new type or just more objects
// And finally, we would like to have means to stop sending notifications to some of those objects.
// We can achieve all those things using the observer design pattern.