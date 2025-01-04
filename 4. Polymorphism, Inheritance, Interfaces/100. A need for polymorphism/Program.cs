// Lets say we create the application for ordering the pizza
///
/// The User can choose from one of the pizza types and ingredients of
/// each pizza should be shown on the screen. Also after hovering over 
/// each ingedient, we should be able to see details of that ingredient.
/// For e.g. Mozzarella is ingredients which detail may be its expiry date
/// called aged.
/// We can create diff class for each ingredients
/// and we can create main pizza class 
/// in which there will be a list. But this is not a good structure 
/// because list can not hold different types of objects.
/// What we can do is we can create single class for all the ingredients.
/// But this is not a good option either because, the ingredients will have
/// the fields which are the details of ingredients but not all ingredients 
/// will have same details right. 
/// So we need a diff class for each ingredient but we want to handle them 
/// uniformly in the pizza class. We will still have a list of objectes 
/// but each object could be a diff ingredient under the hood. 
/// This is where polymorphism comes into play.
