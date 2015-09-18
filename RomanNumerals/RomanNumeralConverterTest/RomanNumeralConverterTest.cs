using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RomanNumeral;
using NUnit.Framework;

namespace RomanNumeralConverterTest
{
    [TestFixture]
    public class RomanNumeralConverterTest
    {
        [TestCase(1, "I")]
        public void Convert_a_number_to_a_roman_numeral(int number, string expected)
        {
            Assert.That(expected, Is.EqualTo(RomanNumeralConverter.Convert(number)));
        }
    }
}
