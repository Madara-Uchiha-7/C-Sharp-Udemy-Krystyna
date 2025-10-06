///
/// We will talk about boolean parameters in methods and why it is often better to avoid
/// them.
/// 
/// We said before that methods often have too many parameters because they do too many things.
/// A special category of such methods are the ones that take boolean parameters and do one thing when its
/// value is true and another when it is false.
/// 
/// Lets say you have:
/// var distance1 = CalculateDistance(point1, point2, true);
/// var distance2 = CalculateDistance(point1, point2, false);
/// 
/// Would you know what the difference between those results will be?
/// To understand this code, we would need to take a look at the CalculateDistance method.
/// So lets say, it seems that depending on the boolean parameter, the result is either in kilometers or miles.
/// This is a very poor design. We were forced to look into a method to know what it does.
/// 
/// Moreover, it does two things.
/// It calculates the distance between points and it transforms it from kilometers to miles if needed.
/// Since this method initially calculates the distance in kilometers, let it do this thing only.
/// We could also rename it to CalculateDistanceInKilometers so there is no chance of misunderstanding.
/// Now, if we have a need to express this distance in miles, we should create a separate method whose
/// job is doing this unit conversion.
/// Now we have two methods truly focused on their tasks.
/// 
/// Of course, not all Boolean parameters are bad.
/// 
/// e.g. ley say a  method decides whether a user is authorized to perform some action or not.
/// If they are administrators, they are always authorized.
/// Otherwise, we check if they belong to some collection of authorized users.
/// So when you see a Boolean parameter, ask yourself if the method does two different things depending
/// on its value.
/// If so, make sure to refactor it.
/// 
///