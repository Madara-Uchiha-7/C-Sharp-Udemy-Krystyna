// Remember how we converted the Ingredient i.e. parent object explicitly and assigned it to the 
// Cheddar class variable.
// e.g. Cheddar cheddar = (Cheddar) ingredient;
// The "as" operator can be used to do the same in the place of cast expression.
// Cheddar cheddar = ingredient as Cheddar;
// If we are using the cast expression then exception may come if case fails.
// For the "as" operator, the result will simply be null. Because the result may be null,
// we can use this operator only to cast those types that can be assigned null.
// Make sure to add the null check in case of the use of the "as".
// Otherwise we will get NullReferenceException.
// For eg. it can not work with int. 