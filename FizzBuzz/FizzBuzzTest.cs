using System;
using System.Text;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private string FizzBuzz(int n)
        {
            var builder = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                var value = String.Empty;
                if (i % 2 == 0)
                    value += "fizz";
                if (i % 3 == 0)
                    value += "buzz";
                if (string.IsNullOrEmpty(value))
                    value = i.ToString();

                builder.AppendFormat("{0} ", value);
            }

            return builder.ToString().TrimEnd();
        }

        [Test]
        public void Test()
        {
            Assert.AreEqual("1", FizzBuzz(1));
            Assert.AreEqual("1 fizz", FizzBuzz(2));
            Assert.AreEqual("1 fizz buzz", FizzBuzz(3));
            Assert.AreEqual("1 fizz buzz fizz 5", FizzBuzz(5));
            Assert.AreEqual("1 fizz buzz fizz 5 fizzbuzz", FizzBuzz(6));
            Assert.AreEqual("1 fizz buzz fizz 5 fizzbuzz 7 fizz buzz", FizzBuzz(9));
        }
    }
}
