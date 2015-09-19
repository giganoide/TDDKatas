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
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(5, "V")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(10, "X")]
        [TestCase(13, "XIII")]
        [TestCase(50, "L")]
        public void Convert_a_number_to_a_roman_numeral(int number, string expected)
        {
            Assert.That(expected, Is.EqualTo(RomanNumeralConverter.Convert(number)));
        }
    }
}
