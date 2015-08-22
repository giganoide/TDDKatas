using FizzBuzzGame;
using NUnit.Framework;

namespace FizzBuzzGameTest
{
    public class FizzBuzzGameTest
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        public void TestPositiveNumber(int number, string expected)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.That(expected, Is.EqualTo(fizzBuzz.GetString(number)));
        }
    }
}
