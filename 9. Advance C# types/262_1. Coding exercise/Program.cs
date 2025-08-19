/*
Immutable struct - Time
Implement the Time structs according to the following requirements:

It should be a struct

It should be immutable

It should have two get-only int properties: Hour and Minute

It should have a single constructor taking an hour and minute parameters. 
This constructor shall throw ArgumentOutOfRangeException when:

The hour is smaller than 0 or larger than 23

The minute is smaller than 0 or larger than 59

It should override the ToString method to return time formatted as HH:MM, for example:

For hour equal to 12 and minute equal to 20, it should give "12:20"

For hour equal to 14 and minute equal to 1, it should give "14:01"

For hour equal to 7 and minute equal to 12, it should give "07:12"

For hour equal to 2 and minute equal to 3, it should give "02:03"

Tip: To pad an integer with zeros when transforming it to a string, we can use: number.ToString("00"). 
*/
using System;

namespace Coding.Exercise
{
    //your code goes here
    public struct Time
    {
        public int Hour { get; }
        public int Minute { get; }

        public Time(int hour, int minute)
        {
            if ((hour < 0 || hour > 23) || (minute < 0 || minute > 59))
            {
                throw new ArgumentOutOfRangeException("Hours or minutes is wrong.");
            }
            Hour = hour;
            Minute = minute;
        }
        public override string ToString() => $"{Hour.ToString("00")}:{Minute.ToString("00")}";
    }
}

/*
It overrides the ToString method. To format single-digit hours and minutes correctly, 
it uses the overload of the ToString method for ints, which takes a desired format.
*/
