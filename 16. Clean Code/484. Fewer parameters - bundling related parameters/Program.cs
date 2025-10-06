///
/// Let's now talk about how to reduce the number of method parameters by bundling multiple parameters together.
/// It is often the case that when a method takes many parameters, some of them are closely related and
/// could be bundled in a dedicated data structure.
/// 
/// Let's consider this simple method.
/// This method is a constructor of a Circle class and it takes three parameters.
/// The first two represent the coordinates of the middle of the circle, and the third one is the circle
/// radius.
/// We could reduce the number of parameters by aggregating the first two into a data structure called Point.
/// It makes sense.
/// Those two values represent point coordinates, so bundling them is only logical.
/// This not only reduces the number of parameters in this constructor, it also makes it easier to understand.
/// As now it is clear right away that a circle is described by its central point and its radius.
/// 
/// 
/// Additionally, we now have the Point data structure which can be easily reused in other places in this
/// application.
/// 
/// One more e.g.
/// This method is used to establish a database connection.
/// It takes five parameters, which is a disturbing number.
/// Let's think about how to bundle them in a logical way.
/// 
/// databaseName, databaseServerName, databaseClusterName
/// Those three simply ask to be bundled together.
/// Even their names are similar, which hints that they have much to do with each other.
/// 
/// We could enclose them in some DatabaseIdentity struct type.
/// 
/// The first two parameters userName and password are also closely related.
/// The username and the password are both pieces of authentication data, so it would make sense to bundle
/// them in a new struct type called, for example, UserCredentials.
/// 
/// Again, those types could be easily reused in other places of the code.
/// 
///