using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzGame
{
    public class FizzBuzz
    {
        public string GetString(int number)
        {
            string sReturn = String.Empty;
            sReturn += GetStringIfDivisible(number,3,"Fizz");
            sReturn += GetStringIfDivisible(number, 5, "Buzz");
            return (!sReturn.Equals(string.Empty)) ? sReturn : number.ToString();
        }

        private string GetStringIfDivisible(int number, int divisor, string stringToReturn)
        {
            return IsDivisibleBy(number, divisor) ? stringToReturn : string.Empty;
        }

        private bool IsDivisibleBy(int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}
