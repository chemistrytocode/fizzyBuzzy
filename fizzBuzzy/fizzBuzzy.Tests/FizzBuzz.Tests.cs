using System;
using NUnit.Framework;

namespace fizzBuzzy.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void Buzzer_When1_Return()
        {
            int input = 1;
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("1", output);
        }
    }
}
