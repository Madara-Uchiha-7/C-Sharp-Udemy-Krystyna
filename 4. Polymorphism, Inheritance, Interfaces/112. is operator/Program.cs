// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// Checks if some object is of a given type.
// e.g. in JS it is known as "type of" operator.

string word = "String";
bool isString = word is string;
bool isInt = word is int;

///
/// Now we can do 
/// Ingredient ingredient = new Chedder(10, 20);
/// Ingredient randomIngredient = GenerateRandomIngredient(); 
/// GenerateRandomIngredient() gives new Chedder() or new Mozzarella() or TomatoSauce() randomly.
/// 
/// Console.WriteLine(ingredient is object); True
/// Console.WriteLine(ingredient is Ingredient); True
/// Console.WriteLine(ingredient is Chedder); True
/// Console.WriteLine(ingredient is Mozzarella); False
/// Console.WriteLine(ingredient is TomatoSauce); False
/// Below check will help in down casting.
/// if (randomIngredient is Cheddar) 
/// { 
///     Chedder chedder = (Chedder) randomIngredient;
///     Console.WriteLine("Cheddar Object: " + chedder);
/// }
/// Above if has the shorter syntax:
/// if (randomIngredient is Cheddar chedder) 
/// { 
///     Console.WriteLine("Cheddar Object: " + chedder);
/// }
/// 

// Using downcasting shows the problems in the design.


