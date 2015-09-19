using System.Collections.Generic;
using System.Linq;

namespace RomanNumeral
{
    public class RomanNumeralConverter
    {
        /*
        Symbol 	Value
            I 	1
            V 	5
            X 	10
            L 	50
            C 	100
            D 	500
            M 	1,000
        */
        static Dictionary<int, string> map = new Dictionary<int, string> { { 1, "I" }, { 5, "V" }, { 10, "X" }, { 50, "L" }, { 100, "C" }, { 500, "D" }, { 1000, "M" } };

        public static string Convert(int number)
        {
            string romanNumber = string.Empty;

            foreach (KeyValuePair<int, string> i in map.OrderByDescending(x => x.Key))
            {
                if (number >= i.Key)
                {
                    romanNumber += i.Value;
                    number -= i.Key;
                }
            }
            
            for (int i = 0; i < number; i++)
                romanNumber += "I";
            return romanNumber;
        }
    }
}
;