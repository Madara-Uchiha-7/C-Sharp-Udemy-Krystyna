using System;

namespace Coding.Exercise
{
   public static class NumericTypesDescriber
    {
        public static string Describe(object someObject)
        {
            //your code goes here
            if (someObject is int)
            {
                return $"Int of value {someObject}";
            } 
            else if (someObject is double)
            {
                return $"Double of value {someObject.ToString()}";
            } 
            else if (someObject is decimal asDecimal)
            {
                return $"Decimal of value {asDecimal}";
            }
            else
            {
                return null;
            }
        }
    }
}