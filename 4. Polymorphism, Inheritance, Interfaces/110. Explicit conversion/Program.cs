decimal a1 = 10.11m;

// We can not assign the decimal to int 
// because 0.11 part will get trimmed. So internal conversion will not be possible.
// So we have to do external casting.
int a2 = (int) a1;
// This is risky because if value is to big then int32 will not be able to store it.
// Then this explicit conversion may fail.
// Max int is : 2147 483 647
// Deciaml are much larger number.

// Some explit casts are simply not possible. Like : 
int a3 = 10;
string a4 = (string) a3; //  Error, though ToString() will work here.

// In last lecture we explictly converted the int to enum
// But again it is risk, like if int is bigger than the size of enum.
// Program may not even fail and still run which is risky.
// Note: enum by defualt starts from index 0.
