// If the properties of the class are setable,
// then we can use object initalizer when creating new objects

/* Instead of Person person = new Person()
 * We used {} because we have used setter in our class
 * This is called Object Initializer
 * So we dont need to call the default constructor using ()
 * We can skip it and directly call out setter using {}
 * We dont need to set all the properties here
 * For e.g. if we do not set YearOfBirth then default value will be used for that type
 * i.e. YearOfBirth will be set to 0
 * Using Object Initializer does not mean we can not use ()
 * We can do Person person = new Person("Chinmay"){YearOfBirth = 1981};
 * In above like constructor will take parameter "Chinmay" and assign it to the name.
 * (Note: Obviously you need to define the constructor in the class for this)
 * If we set the same value in constructor and in Object Initializer then 
 * Object Initializer's one will get used.
 * This is because the constructor is called first.
 * If you remove setter i.e. set; or make the Setter private then 
 * Object Initializer will not work.
 * Making setter is not a good thing because user can still set the value
 * from outside (e.g. obj.setterGetterName = value), so most of the time the setter 
 * will be private. To tackle this new accessor is introduced in C# called as the 
 * init.
 * To use init, change "public string Name { get; set; }" to
 * "public string Name { get; init; }" This will make setter private after Object Creation.
 * Now, the value to the property is set only during Object Construction.
 * When using the constructor we must provide all the required parameters.
 * While in Object Initializer its not the case. 
 * Also, since we have to define the name of the Proerty in Object Initializer,
 * it is more understandable than constructor.
 * Constructors are better if no. of parameters are small and parameters show the meaning
 * of what is getting passed.
 */
Person person = new Person
{
    Name = "John",
    YearOfBirth = 1981
};


public class Person
{
    public string Name { get; set; }
    public int YearOfBirth { get; set; }
}
