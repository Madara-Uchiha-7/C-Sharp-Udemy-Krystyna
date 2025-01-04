// There is a possibility that method calling other method and so on
// becomes very big then stack trace can not keep up.
// This mostly happens with the recurssive methods if we messed up the stopping condition.
// If this happens then you will get StackOverflowException.

