
// Continuation of 399 and 400.
// The observer design pattern allows objects to notify other objects about changes in their state.
// But before we add a code, let's identify which of those classes is the observable and which is the observer.
// As those names suggest, the observable is the object that is being observed by other objects.
// So the GoldPriceReader is the observable here and it is observed by two observers.
// First of all, we want to decouple the GoldPriceReader, so the observable, from the price change notifiers,
// so the observers. We will need to define interfaces over which they can communicate.
// The first question we need to ask is: what data will be sent from the observable to the observers?
// In our case, it will be the current gold price.
// Price is best represented with a decimal.
// Still, the interfaces we will define will be generic so they can work with any payload.
// First, let's define the IObserver interface which will be implemented by the price change
// notifiers.

// This interface contains a single Update method which will be called by the observable to send the data.
// In this case, the Update method is already implemented in our classes.
// In general, the Update method is the one that receives the notification from the observable and decides
// what to do with it.
// Now let's define the IObservable interface.
// Lets implement it in the GoldPriceReader;
// Also define the collection of observer in the GoldPriceReader.
// We will remove : 
// private readonly EmailPriceChangeNotifier _emailPriceChangeNotifier;
// private readonly PushPriceChangeNotifier _pushPriceChangeNotifier;
// and its GoldPriceReader constuctor.


const int threshold = 30_000;
EmailPriceChangeNotifier emailPriceChangeNotifier = new EmailPriceChangeNotifier(threshold);
PushPriceChangeNotifier psuhPriceChangeNotifier = new PushPriceChangeNotifier(threshold);
GoldPriceReader goldPriceReader = new GoldPriceReader();
goldPriceReader.AttachObserver(emailPriceChangeNotifier);
goldPriceReader.AttachObserver(psuhPriceChangeNotifier);
for (int i = 0; i < 3; i++)
{
    goldPriceReader.ReadCurrentPrice();
}
Console.ReadKey();

public interface IObservable<TData>
{
    // The first two methods attach or detach the observer to the observable.
    // This way we will have a control over who is notified.
    // We can detach or unsubscribe the observer at any time
    // if it is no longer interested in receiving the notifications from the observable.
    void AttachObserver(IObserver<TData> observer);
    void DetachObserver(IObserver<TData> observer);

    // This method will be executed to send the notification to all subscribed observers.
    void NotifyObserver();
}

public interface IObserver<TData>
{
    void Update(TData data);
}
public class GoldPriceReader : IObservable<decimal>
{
    private int _currentGoldPrice;

    private readonly List<IObserver<decimal>>  _observers = new List<IObserver<decimal>>();

    public void ReadCurrentPrice()
    {
        _currentGoldPrice = new Random().Next(20_000, 50_000);
        NotifyObserver();
    }

    public void AttachObserver(IObserver<decimal> observer)
    {
        _observers.Add(observer);
    }

    public void DetachObserver(IObserver<decimal> observer)
    {
        _observers.Remove(observer);
    }


    // The NotyfyObservers method will iterate this list of observers and execute the update method on them.
    public void NotifyObserver()
    {
        foreach (IObserver<decimal> observer in _observers)
        {
            observer.Update(_currentGoldPrice);
        }
    }
}


public class EmailPriceChangeNotifier : IObserver<decimal>
{
    private readonly decimal _notificationThreshold;

    public EmailPriceChangeNotifier(decimal notificationThreshold)
    {
        _notificationThreshold = notificationThreshold;
    }

    // It takes the current price of gold, and if it is above this threshold, it sends the email to the user.
    public void Update(decimal price)
    {
        if (price > _notificationThreshold)
        {
            Console.WriteLine(@$"Sending an email saying that 
                                the gold price exceeded {_notificationThreshold} 
                                and is now {price}\n");
        }
    }
}

public class PushPriceChangeNotifier : IObserver<decimal>
{
    private readonly decimal _notificationThreshold;
    public PushPriceChangeNotifier(decimal notificationThreshold)
    {
        _notificationThreshold = notificationThreshold;
    }
    public void Update(decimal price)
    {
        if (price > _notificationThreshold)
        {
            Console.WriteLine(@$"Sending an email saying that 
                                the gold price exceeded {_notificationThreshold} 
                                and is now {price}\n");
        }
    }
}



// Lets review the changes we made:
// The price change notifier classes now implements the IObserver interface.
// This interface forces them to have the Update method which takes the current gold price.
// Those observers
// can be added to the observers list owned by the observable.
// In our case, the gold price reader.
// They are added or removed from this list using AttachObserver and DetachObserver methods.
// When the observable wants to notify the observers, it simply iterates this list and executes the
// Update method on each observer.
// In our case this happens when the latest gold price is read.
// Now we can easily control the observers of the GoldPriceReader class.
// We can detach the PushPriceChangeNotifier, and then execute the loop again.

// Now,
// As it turns out, C#has a built-in mechanism that allows us to achieve a similar result.
// This mechanism is called events, and we will learn about them in the next lecture.