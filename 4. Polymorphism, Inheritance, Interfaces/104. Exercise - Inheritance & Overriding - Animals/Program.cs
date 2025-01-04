/*
In the code, you will see the GetCountsOfAnimalsLegs method. 
It iterates a List of Animals containing a Lion, a Tiger, a Duck, and a Spider.

This List is iterated, and the NumberOfLegs of each animal is added to the result List, 
which is then returned from this method.

Your job is to define the following classes:
Animal (base class)
Lion (derived from Animal)
Tiger (derived from Animal)
Duck (derived from Animal)
Spider (derived from Animal)
...in such a way that the result List will contain the following numbers:
4 (Lion)
4 (Tiger)
2 (Duck)
8 (Spider)
Since we have two animals that have 4 legs, 
consider setting the NumberOfLegs in the base class to 4 and only override it in classes representing Animals 
with different numbers of legs.
 */
using System;

namespace Coding.Exercise
{
    public class Exercise
    {

        public List<int> GetCountsOfAnimalsLegs()
        {
            var animals = new List<Animal>
            {
                new Lion(),
                new Tiger(),
                new Duck(),
                new Spider()
            };

            var result = new List<int>();
            foreach (var animal in animals)
            {
                result.Add(animal.NumberOfLegs);
            }
            return result;
        }
    }

    //your code goes here
    public class Animal
    {
        // public access modifier because we are using this class in Exercise class.
        public virtual int NumberOfLegs { get; } = 4;
    }
    public class Lion : Animal
    {
    }
    public class Tiger : Animal
    {
    }
    public class Duck : Animal
    {
        public override int NumberOfLegs { get; } = 2;
    }
    public class Spider : Animal
    {
        public override int NumberOfLegs { get; } = 8;
    }
}
// Look how teacher has not used NumberOfLegs for Tiger and Lion since they have 4 legs. 
// That 4 value is used as the base class value.