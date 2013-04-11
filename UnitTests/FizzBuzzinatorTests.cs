using System.Linq;
using FizzBuzz;
using Xunit;

namespace UnitTests
{
    public class FizzBuzzinatorTests
    {
        public class TheGenerateMethod
        {
            [Fact]
            public void GeneratesTheRightValues()
            {
                var fizzBuzz = new FizzBuzzinator();

                string[] values = fizzBuzz.Generate().Take(5).ToArray();

                Assert.Equal("1", values[0]);
                Assert.Equal("2", values[1]);
                Assert.Equal("Fizz", values[2]);
                Assert.Equal("4", values[3]);
                Assert.Equal("Buzz", values[4]);
            }
        }
    }
}