// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

interface IAnimal
{
    void MakeSound();
}

interface IHousePet : IAnimal
{
    
}

interface IFeline : IAnimal
{
    void MakeSound();
}

class DomesticCatImplementingInterface : IFeline, IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Purr Purrr....!");
    }
}


// Since DomesticCatImplementingInterface class is the only place 
// where the MakeSound() method is implementated, there is no confuction of which
// method to call from which interface when object of this class is instantiated.

// We also saw one interface can extend another.
// So the class implementing the child interface will have to 
// declare all the methods,  i.e. of child and of parent interface.

// We added MakeSound() in IFeline also just to show, but it is not neeeded
// since it is present in the parent interface.