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
            sReturn += GetFizz(number);
            sReturn += GetBuzz(number);
            return (!sReturn.Equals(string.Empty)) ? sReturn : number.ToString();

        }

        private string GetBuzz(int number)
        {
            return IsDivisibleBy(number, 5) ? "Buzz" : string.Empty;
        }

        private string GetFizz(int number)
        {
            return IsDivisibleBy(number, 3) ? "Fizz" : string.Empty;
        }

        private bool IsDivisibleBy(int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}
