///
/// Remember we had a class Called Ingredient and Cheddar.
/// While Cheddar is child and Ingredient is its parent.
/// So we can create the GeneralType variableName = new ChildClassName();
/// GeneralType is parent class.
/// This is allowed because of inheritance and each Chedder is Ingredient. 
/// This type of casting is called upcasting.
/// Downcasting:
/// Assgning the object of the parent class to the base class variable.
/// Remember : Each ingredient is not the Chedder.
/// Ingredient ingredient = new Cheddar();
/// Chedder chedder = (Chedder) ingredient;
/// This line 12 will work but if line 11 : ingredient variable holds new Mozzarella() object
/// then this will fail. e.g. Remember the Ingredient ingredient was holding multiple child objects.
/// If you want to use the downcasting, but if we want be sure that it will succeed,
/// then we can use "is" operator.
///