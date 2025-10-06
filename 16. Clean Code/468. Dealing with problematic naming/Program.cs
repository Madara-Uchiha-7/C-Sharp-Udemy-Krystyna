///
/// We will discuss what to do when we try to name something, but the clear and expressive
/// name simply cannot be found.
/// 
/// Most often, the inability to find a clear and precise name indicates not the problem with the name
/// itself, but with the class, method or variable.
/// 
/// For example, if a class is responsible for too many things, it is hard to name it precisely.
/// We must first refactor it.
/// 
/// After we do it, naming the new, smaller and more focused classes should be easy.
/// 
/// Let say a method is meant to activate an account and send a notification about it.
/// You can give the name 
/// ActivateAccountAndSendNotification();
/// 
/// The name is not terrible.
/// It is precise and clear, but on the other hand, it is long and hard to pronounce.
/// 
/// The presence of the "and" word in a method's name clearly indicates that this method does two things instead
/// of one.
/// 
/// The method should be split into two: one for activating an account and the other one for sending notifications.
/// This way not only will both be easy to name, but they will also become reusable.
/// We will be able to use the SendNotification method to send other kinds of notifications, not only
/// the one about account activation.
/// 
/// -------------------
/// Lets say a method empties a shopping cart if the user session is inactive.
/// 
/// And you name that method: 
/// EmptyShoppingCartIfSessionInactive()
/// 
/// Again, the name is precise and clear, but it also indicates that two things happen inside the method.
/// We should rather have
/// two methods: IsSessionActive and EmptyShoppingCart and express the conditional action with the if
/// statement.
/// e.g.
/// if(IsSessionActive())
///     EmptyShoppingCart();
///  
/// -------------------   
/// Lets say class name is EmailManager
/// What is email management exactly?
/// Is it sending emails or maybe creating accounts in some email service?
/// As it turns out, this class does both.
/// void SendEmail() {} and void CreateAccount() {}
/// No wonder the author of this class could not come up with a better name.
/// Managing the accounts in an email service and sending them are two very different responsibilities,
/// and they should be defined in two different classes.
/// We could name the first one AccountCreator and it will have a method called Create()
/// We can assume it belongs to a project implementing an email service functionality, so we don't really need
/// to specify that this is an EmailServiceAccountCreator.
/// The context in which classes live is important and also carries some information.
/// There is no need to repeat it in the classes names.
/// The second class could simply be named EmailSender and it will have a method called Send()
/// In this case, we would include the word "email" as we would imagine other sender classes may live in this project,
/// like, for example, some notification sender.
/// 
/// So, as you see, finding a good name became easy once we split the EmailManager class.
/// Generally naming classes that have only one responsibility is always simpler than naming the ones that
/// don't.
/// 
/// It is yet another reason to follow the single responsibility principle.
///