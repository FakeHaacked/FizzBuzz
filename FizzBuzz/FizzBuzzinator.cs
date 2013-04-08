using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzinator
    {
        public IEnumerable<string> Generate()
        {
            return from number in Enumerable.Range(1, 100)
                   select GetValue(number);
        }

        private static string GetValue(int number)
        {
            return number % 15 == 0
                ? "FizzBuzz"
                : (number % 3 == 0
                    ? "Fizz"
                    : (number % 5 == 0
                        ? "Buzz"
                        : number.ToString(CultureInfo.InvariantCulture)));
        }
    }
}

