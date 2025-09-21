// Raising an event simply means invoking all methods stored in the event delegate.
// PriceRead(price); will be highlighted in the VS. I.e. It will give us warning.
// This is because before at least one method is added to the event, it will be null.
// And in this case, PriceRead(price); line will throw the NullReferenceException.
// We can avoid this by using the Invoke method and the null propagating operator.
// Invoke method:
// We will add PriceRead.Invoke(price); instead of PriceRead(price);.
// This method does exactly the same thing as PriceRead(price); line.
// It invokes all methods from the event, but since we use the
// member access operator, so simply the dot, we can do one more thing.
// i.e. adding the null proagating operator. : ?
// So, we will change PriceRead.Invoke(price); to PriceRead?.Invoke(price)
// Its purpose is simple. If PriceRead object is null, nothing will happen.
// If it is not null, then this method will be called.
// We can use it on any objects, not only events to conditionally call methods or access properties.
// anyObject?.SomeMethod(); anyObject?.SomeProperty;
// 


const int threshold = 30_000;
EmailPriceChangeNotifier emailPriceChangeNotifier = new EmailPriceChangeNotifier(threshold);
PushPriceChangeNotifier psuhPriceChangeNotifier = new PushPriceChangeNotifier(threshold);
GoldPriceReader goldPriceReader = new GoldPriceReader();
goldPriceReader.PriceRead += emailPriceChangeNotifier.Update;
goldPriceReader.PriceRead += psuhPriceChangeNotifier.Update;
for (int i = 0; i < 3; i++)
{
    goldPriceReader.ReadCurrentPrice();
}
Console.ReadKey();
Console.ReadKey();

public delegate void PriceRead(decimal price);
public class GoldPriceReader
{
    public event PriceRead? PriceRead;

    public void ReadCurrentPrice()
    {
        int currentGoldPrice = new Random().Next(20_000, 50_000);
        OnPriceRead(currentGoldPrice);
    }

    private void OnPriceRead(decimal price)
    {
        // PriceRead(price);
        PriceRead?.Invoke(price);
    }
}

public class EmailPriceChangeNotifier
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

public class PushPriceChangeNotifier
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


/*
All right, Let's summarize what happened in this class.
We declared an event that is of a delegate type, as all events are.
When the gold price is read, we raise the event so all subscribers are notified.
Let's move on to the subscribers.
Each subscriber must contain a method that is compatible with the event delegate.
In our case, a void method that accepts a decimal as a parameter.
Luckily we have such methods in the notifier classes i.e. The Update method.
We use them here:
goldPriceReader.PriceRead += emailPriceChangeNotifier.Update;
goldPriceReader.PriceRead += psuhPriceChangeNotifier.Update;

The PriceRead event now stores the Update methods from the notifiers.
When the ReadCurrentPrice method is called the event is invoked.
And as a result, the Update methods are called with the current gold price.
*/