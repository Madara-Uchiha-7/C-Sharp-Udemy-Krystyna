/*
Which of the following could not be assigned the value of DateTime.Now (current date and time)?


Ans :
A const field of DateTime type

why:
Correct! Const fields can only be assigned compile-time constant values, 
and DateTime.Now cannot be known at the compile time.


It can be done if field is readonly.
---------------------

*/
